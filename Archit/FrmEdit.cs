using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archit
{
  public partial class FrmEdit : Form
  {
    public Projet prj;

    public FrmEdit()
    {
      InitializeComponent();
    }

    private void FrmEdit_Shown(object sender, EventArgs e)
    {
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
  } //class
} //Namespace
