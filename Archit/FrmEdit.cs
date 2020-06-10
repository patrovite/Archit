using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Archit
{
  public partial class FrmEdit : Form
  {
    public Projet prj;
    Config settings;
    String appDir;

    public FrmEdit(Config settings, String appDir)
    {
      this.settings = settings;
      this.appDir = appDir;
      InitializeComponent();
    }

    private void FrmEdit_Shown(object sender, EventArgs e)
    {
      //-- Load translation
      Translate(appDir + "/lng/texts." + settings.langue.ToString() + ".xml");

      Refresh();
    }

    private void Refresh()
    {
      edNomProjet.Text = prj.Nom;
      lbSrcVal.Text = prj.Src;
      lbDestVal.Text = prj.Dst;
      edFormat.Text = prj.Format;
    }

    public bool UpdatePrj() 
    {
      prj.Nom = edNomProjet.Text.Trim();
      prj.Src = lbSrcVal.Text.Trim();
      prj.Dst = lbDestVal.Text.Trim();
      prj.Format = edFormat.Text.Trim();
      return ( (prj.Nom.Length != 0) && (prj.Src.Length != 0) && (prj.Dst .Length != 0) );
    }

/*
    private void btSrc_Click(object sender, EventArgs e)
    {
      folderBrowserDialog.Description = "Sélectionnez le répertoire source";
      folderBrowserDialog.SelectedPath = lbSrcVal.Text;
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        lbSrcVal.Text = folderBrowserDialog.SelectedPath.Trim();
      }
    }

    private void btDest_Click(object sender, EventArgs e)
    {
      folderBrowserDialog.Description = "Sélectionnez le répertoire destination";
      folderBrowserDialog.SelectedPath = lbDestVal.Text;
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        lbDestVal.Text = folderBrowserDialog.SelectedPath.Trim();
      }
    }
*/

    private void edFormat_TextChanged(object sender, EventArgs e)
    {
      lbExemple.Text = Utils.GenereNomArchive(edFormat.Text, "Comment");
    }

    private void lbSrcVal_Click(object sender, EventArgs e)
    {
      folderBrowserDialog.Description = "Sélectionnez le répertoire source";
      folderBrowserDialog.SelectedPath = lbSrcVal.Text;
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        lbSrcVal.Text = folderBrowserDialog.SelectedPath.Trim();
      }
    }

    private void lbDestVal_Click(object sender, EventArgs e)
    {
      folderBrowserDialog.Description = "Sélectionnez le répertoire destination";
      folderBrowserDialog.SelectedPath = lbDestVal.Text;
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        lbDestVal.Text = folderBrowserDialog.SelectedPath.Trim();
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
            lbNomProjet.Text = Utils.ReadKey(key, "LBNOMPROJET", lbNomProjet.Text);
            lbSrc.Text = Utils.ReadKey(key, "LBSRC", lbSrc.Text);
            lbDest.Text = Utils.ReadKey(key, "LBDEST", lbDest.Text);
            lbFormat.Text = Utils.ReadKey(key, "LBFORMAT", lbFormat.Text);
            lbHelpTitre.Text = Utils.ReadKey(key, "LBHELPTITRE", lbHelpTitre.Text);
            lbHelp.Text = Utils.ReadKey(key, "LBHELP", lbHelp.Text);
            lbExempleTitre .Text = Utils.ReadKey(key, "LBEXEMPLETITRE", lbExempleTitre.Text);

            btValide.Text = Utils.ReadKey(key, "BTVALIDE", btValide.Text);
            btCancel.Text = Utils.ReadKey(key, "BTCANCEL", btCancel.Text);
          } //Boucle clés
        } //Section choisi

      } // Boucle section
    }  //Translate

  } //class
} //Namespace
