namespace Archit
{
  partial class FrmEdit
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdit));
      this.lbNomProjet = new System.Windows.Forms.Label();
      this.lbSrcVal = new System.Windows.Forms.Label();
      this.lbSrc = new System.Windows.Forms.Label();
      this.lbDestVal = new System.Windows.Forms.Label();
      this.lbDest = new System.Windows.Forms.Label();
      this.edNomProjet = new System.Windows.Forms.TextBox();
      this.btValide = new System.Windows.Forms.Button();
      this.btCancel = new System.Windows.Forms.Button();
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.edFormat = new System.Windows.Forms.TextBox();
      this.lbFormat = new System.Windows.Forms.Label();
      this.lbHelp = new System.Windows.Forms.Label();
      this.lbHelpTitre = new System.Windows.Forms.Label();
      this.lbExempleTitre = new System.Windows.Forms.Label();
      this.lbExemple = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // lbNomProjet
      // 
      this.lbNomProjet.BackColor = System.Drawing.Color.DarkGray;
      this.lbNomProjet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbNomProjet.Location = new System.Drawing.Point(12, 13);
      this.lbNomProjet.Name = "lbNomProjet";
      this.lbNomProjet.Size = new System.Drawing.Size(134, 20);
      this.lbNomProjet.TabIndex = 7;
      this.lbNomProjet.Text = "Nom projet";
      this.lbNomProjet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbSrcVal
      // 
      this.lbSrcVal.AutoEllipsis = true;
      this.lbSrcVal.BackColor = System.Drawing.Color.Linen;
      this.lbSrcVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbSrcVal.Location = new System.Drawing.Point(12, 75);
      this.lbSrcVal.Name = "lbSrcVal";
      this.lbSrcVal.Size = new System.Drawing.Size(500, 20);
      this.lbSrcVal.TabIndex = 11;
      this.lbSrcVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.toolTip1.SetToolTip(this.lbSrcVal, "Cliquez pour choisir le répertoire source");
      this.lbSrcVal.Click += new System.EventHandler(this.lbSrcVal_Click);
      // 
      // lbSrc
      // 
      this.lbSrc.BackColor = System.Drawing.Color.DarkGray;
      this.lbSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbSrc.Location = new System.Drawing.Point(12, 56);
      this.lbSrc.Name = "lbSrc";
      this.lbSrc.Size = new System.Drawing.Size(134, 20);
      this.lbSrc.TabIndex = 10;
      this.lbSrc.Text = "Répertoire source";
      this.lbSrc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbDestVal
      // 
      this.lbDestVal.AutoEllipsis = true;
      this.lbDestVal.BackColor = System.Drawing.Color.Linen;
      this.lbDestVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbDestVal.Location = new System.Drawing.Point(12, 118);
      this.lbDestVal.Name = "lbDestVal";
      this.lbDestVal.Size = new System.Drawing.Size(500, 20);
      this.lbDestVal.TabIndex = 14;
      this.lbDestVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.toolTip1.SetToolTip(this.lbDestVal, "Cliquez pour choisir le répertoire destination");
      this.lbDestVal.Click += new System.EventHandler(this.lbDestVal_Click);
      // 
      // lbDest
      // 
      this.lbDest.BackColor = System.Drawing.Color.DarkGray;
      this.lbDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbDest.Location = new System.Drawing.Point(12, 99);
      this.lbDest.Name = "lbDest";
      this.lbDest.Size = new System.Drawing.Size(134, 20);
      this.lbDest.TabIndex = 13;
      this.lbDest.Text = "Répertoire destination";
      this.lbDest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // edNomProjet
      // 
      this.edNomProjet.Location = new System.Drawing.Point(12, 32);
      this.edNomProjet.Name = "edNomProjet";
      this.edNomProjet.Size = new System.Drawing.Size(500, 20);
      this.edNomProjet.TabIndex = 16;
      // 
      // btValide
      // 
      this.btValide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btValide.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btValide.Image = global::Archit.Properties.Resources.Valid;
      this.btValide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btValide.Location = new System.Drawing.Point(265, 403);
      this.btValide.Name = "btValide";
      this.btValide.Size = new System.Drawing.Size(90, 30);
      this.btValide.TabIndex = 18;
      this.btValide.Text = "Valider";
      this.btValide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btValide.UseVisualStyleBackColor = true;
      // 
      // btCancel
      // 
      this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancel.Image = global::Archit.Properties.Resources.supprimer;
      this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btCancel.Location = new System.Drawing.Point(169, 403);
      this.btCancel.Name = "btCancel";
      this.btCancel.Size = new System.Drawing.Size(90, 30);
      this.btCancel.TabIndex = 17;
      this.btCancel.Text = "Annuler";
      this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btCancel.UseVisualStyleBackColor = true;
      // 
      // edFormat
      // 
      this.edFormat.Location = new System.Drawing.Point(12, 161);
      this.edFormat.Name = "edFormat";
      this.edFormat.Size = new System.Drawing.Size(500, 20);
      this.edFormat.TabIndex = 20;
      this.edFormat.TextChanged += new System.EventHandler(this.edFormat_TextChanged);
      // 
      // lbFormat
      // 
      this.lbFormat.BackColor = System.Drawing.Color.DarkGray;
      this.lbFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbFormat.Location = new System.Drawing.Point(12, 142);
      this.lbFormat.Name = "lbFormat";
      this.lbFormat.Size = new System.Drawing.Size(134, 20);
      this.lbFormat.TabIndex = 19;
      this.lbFormat.Text = "Format nom fichier";
      this.lbFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbHelp
      // 
      this.lbHelp.BackColor = System.Drawing.Color.FloralWhite;
      this.lbHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbHelp.Location = new System.Drawing.Point(12, 204);
      this.lbHelp.Name = "lbHelp";
      this.lbHelp.Size = new System.Drawing.Size(500, 123);
      this.lbHelp.TabIndex = 21;
      this.lbHelp.Text = resources.GetString("lbHelp.Text");
      this.lbHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbHelpTitre
      // 
      this.lbHelpTitre.BackColor = System.Drawing.Color.DarkGray;
      this.lbHelpTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbHelpTitre.Location = new System.Drawing.Point(12, 185);
      this.lbHelpTitre.Name = "lbHelpTitre";
      this.lbHelpTitre.Size = new System.Drawing.Size(134, 20);
      this.lbHelpTitre.TabIndex = 22;
      this.lbHelpTitre.Text = "Aide format";
      this.lbHelpTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbExempleTitre
      // 
      this.lbExempleTitre.BackColor = System.Drawing.Color.DarkGray;
      this.lbExempleTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbExempleTitre.Location = new System.Drawing.Point(12, 331);
      this.lbExempleTitre.Name = "lbExempleTitre";
      this.lbExempleTitre.Size = new System.Drawing.Size(134, 20);
      this.lbExempleTitre.TabIndex = 23;
      this.lbExempleTitre.Text = "Exemple de nom fichier";
      this.lbExempleTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbExemple
      // 
      this.lbExemple.AutoEllipsis = true;
      this.lbExemple.BackColor = System.Drawing.Color.Linen;
      this.lbExemple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbExemple.Location = new System.Drawing.Point(12, 350);
      this.lbExemple.Name = "lbExemple";
      this.lbExemple.Size = new System.Drawing.Size(500, 20);
      this.lbExemple.TabIndex = 24;
      this.lbExemple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // FrmEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(522, 446);
      this.Controls.Add(this.lbExemple);
      this.Controls.Add(this.lbExempleTitre);
      this.Controls.Add(this.lbHelpTitre);
      this.Controls.Add(this.lbHelp);
      this.Controls.Add(this.edFormat);
      this.Controls.Add(this.lbFormat);
      this.Controls.Add(this.btValide);
      this.Controls.Add(this.btCancel);
      this.Controls.Add(this.edNomProjet);
      this.Controls.Add(this.lbDestVal);
      this.Controls.Add(this.lbDest);
      this.Controls.Add(this.lbSrcVal);
      this.Controls.Add(this.lbSrc);
      this.Controls.Add(this.lbNomProjet);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmEdit";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Shown += new System.EventHandler(this.FrmEdit_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lbNomProjet;
    private System.Windows.Forms.Label lbSrcVal;
    private System.Windows.Forms.Label lbSrc;
    private System.Windows.Forms.Label lbDestVal;
    private System.Windows.Forms.Label lbDest;
    private System.Windows.Forms.TextBox edNomProjet;
    private System.Windows.Forms.Button btCancel;
    private System.Windows.Forms.Button btValide;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    private System.Windows.Forms.TextBox edFormat;
    private System.Windows.Forms.Label lbFormat;
    private System.Windows.Forms.Label lbHelp;
    private System.Windows.Forms.Label lbHelpTitre;
    private System.Windows.Forms.Label lbExempleTitre;
    private System.Windows.Forms.Label lbExemple;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}