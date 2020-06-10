namespace Archit
{
  partial class FrmMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.grpbListeProjets = new System.Windows.Forms.GroupBox();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.listBoxProjets = new System.Windows.Forms.ListBox();
            this.lbSrc = new System.Windows.Forms.Label();
            this.lbSrcVal = new System.Windows.Forms.Label();
            this.lbDstVal = new System.Windows.Forms.Label();
            this.lbDst = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this.edComment = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbResultVal = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btArchiverFermer = new System.Windows.Forms.Button();
            this.btArchiver = new System.Windows.Forms.Button();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.grpbListeProjets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbListeProjets
            // 
            this.grpbListeProjets.Controls.Add(this.btUp);
            this.grpbListeProjets.Controls.Add(this.btDown);
            this.grpbListeProjets.Controls.Add(this.btDel);
            this.grpbListeProjets.Controls.Add(this.btEdit);
            this.grpbListeProjets.Controls.Add(this.btPlus);
            this.grpbListeProjets.Controls.Add(this.listBoxProjets);
            this.grpbListeProjets.Location = new System.Drawing.Point(12, 12);
            this.grpbListeProjets.Name = "grpbListeProjets";
            this.grpbListeProjets.Size = new System.Drawing.Size(187, 426);
            this.grpbListeProjets.TabIndex = 0;
            this.grpbListeProjets.TabStop = false;
            this.grpbListeProjets.Text = "Projets";
            // 
            // btUp
            // 
            this.btUp.AutoSize = true;
            this.btUp.Image = global::Archit.Properties.Resources.monter;
            this.btUp.Location = new System.Drawing.Point(150, 389);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(30, 30);
            this.btUp.TabIndex = 5;
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.AutoSize = true;
            this.btDown.Image = global::Archit.Properties.Resources.descendre;
            this.btDown.Location = new System.Drawing.Point(114, 389);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(30, 30);
            this.btDown.TabIndex = 4;
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btDel
            // 
            this.btDel.AutoSize = true;
            this.btDel.Image = global::Archit.Properties.Resources.supprimer;
            this.btDel.Location = new System.Drawing.Point(78, 389);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(30, 30);
            this.btDel.TabIndex = 3;
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.AutoSize = true;
            this.btEdit.Image = global::Archit.Properties.Resources.modifier;
            this.btEdit.Location = new System.Drawing.Point(42, 389);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(30, 30);
            this.btEdit.TabIndex = 2;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btPlus
            // 
            this.btPlus.AutoSize = true;
            this.btPlus.Image = global::Archit.Properties.Resources.ajouter;
            this.btPlus.Location = new System.Drawing.Point(6, 389);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(30, 30);
            this.btPlus.TabIndex = 1;
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // listBoxProjets
            // 
            this.listBoxProjets.FormattingEnabled = true;
            this.listBoxProjets.Location = new System.Drawing.Point(6, 19);
            this.listBoxProjets.Name = "listBoxProjets";
            this.listBoxProjets.Size = new System.Drawing.Size(174, 368);
            this.listBoxProjets.TabIndex = 0;
            this.listBoxProjets.SelectedIndexChanged += new System.EventHandler(this.listBoxProjets_SelectedIndexChanged);
            // 
            // lbSrc
            // 
            this.lbSrc.BackColor = System.Drawing.Color.DarkGray;
            this.lbSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSrc.Location = new System.Drawing.Point(218, 18);
            this.lbSrc.Name = "lbSrc";
            this.lbSrc.Size = new System.Drawing.Size(134, 20);
            this.lbSrc.TabIndex = 1;
            this.lbSrc.Text = "Répertoire source";
            this.lbSrc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSrcVal
            // 
            this.lbSrcVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSrcVal.AutoEllipsis = true;
            this.lbSrcVal.BackColor = System.Drawing.Color.Linen;
            this.lbSrcVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSrcVal.Location = new System.Drawing.Point(218, 37);
            this.lbSrcVal.Name = "lbSrcVal";
            this.lbSrcVal.Size = new System.Drawing.Size(651, 20);
            this.lbSrcVal.TabIndex = 2;
            this.lbSrcVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDstVal
            // 
            this.lbDstVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDstVal.AutoEllipsis = true;
            this.lbDstVal.BackColor = System.Drawing.Color.Linen;
            this.lbDstVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDstVal.Location = new System.Drawing.Point(218, 80);
            this.lbDstVal.Name = "lbDstVal";
            this.lbDstVal.Size = new System.Drawing.Size(651, 20);
            this.lbDstVal.TabIndex = 8;
            this.lbDstVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDst
            // 
            this.lbDst.BackColor = System.Drawing.Color.DarkGray;
            this.lbDst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDst.Location = new System.Drawing.Point(218, 61);
            this.lbDst.Name = "lbDst";
            this.lbDst.Size = new System.Drawing.Size(134, 20);
            this.lbDst.TabIndex = 7;
            this.lbDst.Text = "Répertoire destination";
            this.lbDst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbComment
            // 
            this.lbComment.BackColor = System.Drawing.Color.DarkGray;
            this.lbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbComment.Location = new System.Drawing.Point(218, 104);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(134, 20);
            this.lbComment.TabIndex = 9;
            this.lbComment.Text = "Commentaire";
            this.lbComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edComment
            // 
            this.edComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edComment.Location = new System.Drawing.Point(218, 123);
            this.edComment.MaxLength = 30;
            this.edComment.Name = "edComment";
            this.edComment.Size = new System.Drawing.Size(651, 20);
            this.edComment.TabIndex = 11;
            this.edComment.TextChanged += new System.EventHandler(this.edComment_TextChanged);
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.DarkGray;
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.Location = new System.Drawing.Point(218, 147);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(134, 20);
            this.lbResult.TabIndex = 12;
            this.lbResult.Text = "Résultat";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbResultVal
            // 
            this.lbResultVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResultVal.AutoEllipsis = true;
            this.lbResultVal.BackColor = System.Drawing.Color.Linen;
            this.lbResultVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultVal.Location = new System.Drawing.Point(218, 166);
            this.lbResultVal.Name = "lbResultVal";
            this.lbResultVal.Size = new System.Drawing.Size(651, 20);
            this.lbResultVal.TabIndex = 13;
            this.lbResultVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(577, 434);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(300, 12);
            this.lbVersion.TabIndex = 16;
            this.lbVersion.Text = "-- Archit - (C) Pierre Delore - Version 1.0 --";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btArchiverFermer
            // 
            this.btArchiverFermer.BackColor = System.Drawing.Color.GreenYellow;
            this.btArchiverFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArchiverFermer.Image = global::Archit.Properties.Resources.compress_exit;
            this.btArchiverFermer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btArchiverFermer.Location = new System.Drawing.Point(568, 362);
            this.btArchiverFermer.Name = "btArchiverFermer";
            this.btArchiverFermer.Size = new System.Drawing.Size(194, 69);
            this.btArchiverFermer.TabIndex = 15;
            this.btArchiverFermer.Text = "Archiver et Fermer";
            this.btArchiverFermer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btArchiverFermer.UseVisualStyleBackColor = false;
            this.btArchiverFermer.Click += new System.EventHandler(this.btArchiverFermer_Click);
            // 
            // btArchiver
            // 
            this.btArchiver.BackColor = System.Drawing.Color.GreenYellow;
            this.btArchiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArchiver.Image = global::Archit.Properties.Resources.compress32;
            this.btArchiver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btArchiver.Location = new System.Drawing.Point(357, 362);
            this.btArchiver.Name = "btArchiver";
            this.btArchiver.Size = new System.Drawing.Size(194, 69);
            this.btArchiver.TabIndex = 14;
            this.btArchiver.Text = "Archiver";
            this.btArchiver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btArchiver.UseVisualStyleBackColor = false;
            this.btArchiver.Click += new System.EventHandler(this.btArchiver_Click);
            // 
            // picSettings
            // 
            this.picSettings.Image = global::Archit.Properties.Resources.settings;
            this.picSettings.Location = new System.Drawing.Point(857, 411);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(20, 20);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSettings.TabIndex = 18;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.picSettings);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.btArchiverFermer);
            this.Controls.Add(this.btArchiver);
            this.Controls.Add(this.lbResultVal);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.edComment);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.lbDstVal);
            this.Controls.Add(this.lbDst);
            this.Controls.Add(this.lbSrcVal);
            this.Controls.Add(this.lbSrc);
            this.Controls.Add(this.grpbListeProjets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archit";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpbListeProjets.ResumeLayout(false);
            this.grpbListeProjets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox grpbListeProjets;
    private System.Windows.Forms.ListBox listBoxProjets;
    private System.Windows.Forms.Label lbSrc;
    private System.Windows.Forms.Label lbSrcVal;
    private System.Windows.Forms.Label lbDstVal;
    private System.Windows.Forms.Label lbDst;
    private System.Windows.Forms.Label lbComment;
    private System.Windows.Forms.TextBox edComment;
    private System.Windows.Forms.Label lbResult;
    private System.Windows.Forms.Label lbResultVal;
    private System.Windows.Forms.Button btArchiver;
    private System.Windows.Forms.Button btPlus;
    private System.Windows.Forms.Button btUp;
    private System.Windows.Forms.Button btDown;
    private System.Windows.Forms.Button btDel;
    private System.Windows.Forms.Button btEdit;
    private System.Windows.Forms.Button btArchiverFermer;
    private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.PictureBox picSettings;
    }
}

