namespace Archit
{
    partial class FrmSettings
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
      this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
      this.rbEnglish = new System.Windows.Forms.RadioButton();
      this.rbFrench = new System.Windows.Forms.RadioButton();
      this.btValide = new System.Windows.Forms.Button();
      this.btCancel = new System.Windows.Forms.Button();
      this.groupBoxLanguage.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBoxLanguage
      // 
      this.groupBoxLanguage.Controls.Add(this.rbEnglish);
      this.groupBoxLanguage.Controls.Add(this.rbFrench);
      this.groupBoxLanguage.Location = new System.Drawing.Point(12, 12);
      this.groupBoxLanguage.Name = "groupBoxLanguage";
      this.groupBoxLanguage.Size = new System.Drawing.Size(97, 63);
      this.groupBoxLanguage.TabIndex = 18;
      this.groupBoxLanguage.TabStop = false;
      this.groupBoxLanguage.Text = "Langue";
      // 
      // rbEnglish
      // 
      this.rbEnglish.Appearance = System.Windows.Forms.Appearance.Button;
      this.rbEnglish.AutoSize = true;
      this.rbEnglish.Image = global::Archit.Properties.Resources.flag_en_32;
      this.rbEnglish.Location = new System.Drawing.Point(50, 19);
      this.rbEnglish.Name = "rbEnglish";
      this.rbEnglish.Size = new System.Drawing.Size(38, 38);
      this.rbEnglish.TabIndex = 1;
      this.rbEnglish.TabStop = true;
      this.rbEnglish.UseVisualStyleBackColor = true;
      // 
      // rbFrench
      // 
      this.rbFrench.Appearance = System.Windows.Forms.Appearance.Button;
      this.rbFrench.AutoSize = true;
      this.rbFrench.Image = global::Archit.Properties.Resources.flag_fr_32;
      this.rbFrench.Location = new System.Drawing.Point(6, 19);
      this.rbFrench.Name = "rbFrench";
      this.rbFrench.Size = new System.Drawing.Size(38, 38);
      this.rbFrench.TabIndex = 0;
      this.rbFrench.TabStop = true;
      this.rbFrench.UseVisualStyleBackColor = true;
      // 
      // btValide
      // 
      this.btValide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btValide.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btValide.Image = global::Archit.Properties.Resources.Valid;
      this.btValide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btValide.Location = new System.Drawing.Point(105, 112);
      this.btValide.Name = "btValide";
      this.btValide.Size = new System.Drawing.Size(90, 30);
      this.btValide.TabIndex = 20;
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
      this.btCancel.Location = new System.Drawing.Point(9, 112);
      this.btCancel.Name = "btCancel";
      this.btCancel.Size = new System.Drawing.Size(90, 30);
      this.btCancel.TabIndex = 19;
      this.btCancel.Text = "Annuler";
      this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btCancel.UseVisualStyleBackColor = true;
      // 
      // FrmSettings
      // 
      this.AcceptButton = this.btValide;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btCancel;
      this.ClientSize = new System.Drawing.Size(205, 154);
      this.Controls.Add(this.btValide);
      this.Controls.Add(this.btCancel);
      this.Controls.Add(this.groupBoxLanguage);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmSettings";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.FrmSettings_Shown);
      this.groupBoxLanguage.ResumeLayout(false);
      this.groupBoxLanguage.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbFrench;
        private System.Windows.Forms.Button btValide;
        private System.Windows.Forms.Button btCancel;
    }
}