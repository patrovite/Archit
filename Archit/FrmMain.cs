using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Xml;

namespace Archit
{
  public partial class FrmMain : Form
  {
    public StoreProjets lstprj = new StoreProjets();
    public string AppDir, AppDataDir;
    public string Version;
    //public string dirname = "c:/tmp/";
    public String filename = "archit_db.json";
    public Config settings;
    public string TranslateFilename;

    public FrmMain()
    {
      InitializeComponent();
    }


    private void FrmMain_Load(object sender, EventArgs e)
    {
      //-- Récupération du répertoire de l'application
      //AppDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
      AppDir = Utils.GetAppDir();
      AppDir = AppDir.Replace("\\", "/");

      AppDataDir = Utils.GetAppDataDir() + "/Archit";
      AppDataDir = AppDataDir.Replace("\\", "/");



      //-- Le répertoire User existe? Non on le crée
      if (!System.IO.Directory.Exists(AppDir))
        System.IO.Directory.CreateDirectory(AppDir);

      //StoreProjets lstprj = new StoreProjets();
      lstprj.Projets = new List<Archit.Projet>();

      //-- On récupère la version de l'application qui défini dans Projet>Propriété>Application>Information sur l'assembly
      Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
      //Text = "Archit V" + Version;

      lbVersion.Text = "-- \u00A9 Pierre Delore - Version " + Version + " --";

      //-- Chargement config
      settings = new Config(AppDataDir, "config.cfg");
      settings.Load();

      //-- Chargement traduction
      TranslateFilename = AppDir + "/lng/texts." + settings.langue.ToString() + ".xml";
      Translate(TranslateFilename);

      //..
      LoadDB();
      RefreshListbox();
      RefreshFields(true);
    }


    /// <summary>
    /// Load project database
    /// </summary>
    public void LoadDB()
    {
      if (File.Exists(AppDataDir + "/" + filename))
      {
        string jsonString = File.ReadAllText(AppDataDir + "/" + filename);
        lstprj = JsonSerializer.Deserialize<StoreProjets>(jsonString);
      }
    }


    /// <summary>
    /// Save project database
    /// </summary>
    public void SaveDB()
    {
      string jsonString;
      jsonString = JsonSerializer.Serialize(lstprj);
      File.WriteAllText(AppDir + filename, jsonString);
    }


    /// <summary>
    /// Compress
    /// </summary>
    public bool Archive()
    {
      bool ok = true;
      //..
      if (lbSrcVal.Text.Length == 0) ok = false;
      if (lbDstVal.Text.Length == 0) ok = false;
      if (lbResultVal.Text.Length == 0) ok = false;
      //..
      if (!System.IO.Directory.Exists(lbSrcVal.Text))
        ok = false;
      if (!System.IO.Directory.Exists(lbDstVal.Text))
        ok = false;
      //..
      RefreshFields(false);
      //..
      if (ok)
      {
        string s = lbDstVal.Text + "\\" + lbResultVal.Text + ".zip";
        if (File.Exists(s))
        {
          if (MessageBox.Show("Le fichier existe. Voulez-vous le remplacer?", "Archit", MessageBoxButtons.YesNo)==DialogResult.Yes)
          {
            File.Delete(s);
          }
          else
          {
            return false;
          }
        }
        //..
        Cursor.Current = Cursors.WaitCursor;
        Application.DoEvents();
        //..
        ZipFile.CreateFromDirectory(lbSrcVal.Text, s);
        //..
        Cursor.Current = Cursors.Default;
        Application.DoEvents();
        //..
        return true;
      }
      else
      {
        MessageBox.Show("Impossible de générer l'archive.\nContrôlez le chemin des répertoires source et destination.", "Archit", MessageBoxButtons.OK);
        return false;
      }
    }


    public void RefreshListbox()
    {
      listBoxProjets.Items.Clear();
      foreach(Projet prj in lstprj.Projets)
      {
        listBoxProjets.Items.Add(prj.Nom);
      }
      listBoxProjets.EndUpdate();
    }


    public void RefreshFields(bool clearCommentField)
    {
      int p = listBoxProjets.SelectedIndex;
      if (p >= 0)
      {
        lbSrcVal.Text = lstprj.Projets[p].Src;
        lbDstVal.Text = lstprj.Projets[p].Dst;
        if (clearCommentField)
          edComment.Text = "";
        lbResultVal.Text = Utils.GenereNomArchive(lstprj.Projets[p].Format, edComment.Text);
      }
      else
      {
        lbSrcVal.Text = "";
        lbDstVal.Text = "";
        edComment.Text = "";
        lbResultVal.Text = "";
      }
    }


    private void btPlus_Click(object sender, EventArgs e)
    {
      FrmEdit frm = new FrmEdit(settings, AppDir);
      frm.prj = new Projet();
      if (frm.ShowDialog() == DialogResult.OK)
      {
        frm.UpdatePrj();
        lstprj.Projets.Add(frm.prj);
        SaveDB();
        RefreshListbox();
        RefreshFields(true);
      }
    }


    private void btEdit_Click(object sender, EventArgs e)
    {
      int p = listBoxProjets.SelectedIndex;
      if (p == -1) return;

      FrmEdit frm = new FrmEdit(settings, AppDir);
      frm.prj = lstprj.Projets[p];
      if (frm.ShowDialog() == DialogResult.OK)
      {
        frm.UpdatePrj();
        SaveDB();
        RefreshListbox();
        //.. On repositionne le curseur
        listBoxProjets.SelectedIndex = p;
        //.. 
        RefreshFields(true);
      }
    }


    private void btDel_Click(object sender, EventArgs e)
    {
      int p = listBoxProjets.SelectedIndex;
      if (p == -1) return;
      if (MessageBox.Show("Voulez-vous supprimer le projet?", "Archit", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        lstprj.Projets.RemoveAt(p);
        SaveDB();
        RefreshListbox();
        RefreshFields(true);
      }
    }


    private void btDown_Click(object sender, EventArgs e)
    {
      int p = listBoxProjets.SelectedIndex;
      if (p == -1) return;

      if (p < lstprj.Projets.Count - 1)
      {
        Projet prj = lstprj.Projets[p];
        lstprj.Projets.Remove(prj);
        lstprj.Projets.Insert(p + 1, prj);
        SaveDB();

        RefreshListbox();
        //p = listBoxProjets.SelectedIndex;
        listBoxProjets.SelectedIndex = p+1;

        RefreshFields(true);
      }
    }


    private void btUp_Click(object sender, EventArgs e)
    {
      int p = listBoxProjets.SelectedIndex;
      if (p > 0)
      {
        Projet prj = lstprj.Projets[p];
        lstprj.Projets.Remove(prj);
        lstprj.Projets.Insert(p - 1, prj);
        SaveDB();

        RefreshListbox();
        //p = listBoxProjets.SelectedIndex;
        listBoxProjets.SelectedIndex = p-1;

        RefreshFields(true);
      }
    }


    private void btArchiver_Click(object sender, EventArgs e)
    {
      Archive();
    }


    private void btArchiverFermer_Click(object sender, EventArgs e)
    {
      if (Archive())
        Close();
    }


    private void listBoxProjets_SelectedIndexChanged(object sender, EventArgs e)
    {
      RefreshFields(true);
    }


    private void edComment_TextChanged(object sender, EventArgs e)
    {
      int p = listBoxProjets.SelectedIndex;
      if (p >= 0)
      {
        RefreshFields(false);
      }
    }

    private void picSettings_Click(object sender, EventArgs e)
    {
        FrmSettings frm = new FrmSettings(settings, AppDir);
        frm.setLanguage(settings.langue);
        if (frm.ShowDialog() == DialogResult.OK)
        {
          settings.langue = frm.getLanguage();
          settings.Save();
          Translate(AppDir + "/lng/texts." + settings.langue.ToString() + ".xml");
      }
    }


    private void Translate(string name)
    {
      XmlDocument XmlDoc = new XmlDocument();

      //-- Open the XML file --
      if (System.IO.File.Exists(name) == false) return;

      XmlDoc.Load(name);

      //-- Recherche de la section node --
      foreach (XmlNode section in XmlDoc.ChildNodes)
      {
        //-- SECTION
        if (section.Name.ToUpper() == "MAIN")
        {

          //-- CLES
          foreach (XmlNode key in section.ChildNodes)
          {
            lbSrc.Text = Utils.ReadKey(key, "LBSRC", lbSrc.Text);
            lbDst.Text = Utils.ReadKey(key, "LBDST", lbDst.Text);
            lbComment.Text = Utils.ReadKey(key, "LBCOMMENT", lbComment.Text);
            lbResult.Text = Utils.ReadKey(key, "LBRESULT", lbResult.Text);
            grpbListeProjets.Text = Utils.ReadKey(key, "GRPLISTEPROJETS", grpbListeProjets.Text);
            btArchiver.Text = Utils.ReadKey(key, "BTARCHIVER", btArchiver.Text);
            btArchiverFermer.Text = Utils.ReadKey(key, "BTARCHIVERFERMER", btArchiverFermer.Text);
          } //Boucle clés
        } //Section choisi

      } // Boucle section
    }  //Translate





  } //Class
} //Namespace
