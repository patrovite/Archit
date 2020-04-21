using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Diagnostics;
using System.Drawing;

namespace Archit
{
  public partial class FrmMain : Form
  {
    public StoreProjets lstprj = new StoreProjets();
    public string AppDir;
    public string Version;
    //public string dirname = "c:/tmp/";
    public String filename = "archit_db.json"; 

    public FrmMain()
    {
      InitializeComponent();
    }


    private void FrmMain_Load(object sender, EventArgs e)
    {
      //-- Récupération du répertoire de l'application
      AppDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Archit/";
      AppDir = AppDir.Replace("\\", "/");

      //-- Le répertoire User existe? Non on le crée
      if (!System.IO.Directory.Exists(AppDir))
        System.IO.Directory.CreateDirectory(AppDir);

      //StoreProjets lstprj = new StoreProjets();
      lstprj.Projets = new List<Archit.Projet>();

      //-- On récupère la version de l'application qui défini dans Projet>Propriété>Application>Information sur l'assembly
      Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
      //Text = "Archit V" + Version;

      lbVersion.Text = "-- \u00A9 Pierre Delore - Version " + Version + " --";

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
      if (File.Exists(AppDir + filename))
      {
        string jsonString = File.ReadAllText(AppDir + filename);
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
      FrmEdit frm = new FrmEdit();
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

      FrmEdit frm = new FrmEdit();
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

  } //Class
} //Namespace
