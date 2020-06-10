using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace Archit
{
    public partial class FrmSettings : Form
    {
      Config settings;
      String appDir;

      public FrmSettings(Config settings, String appDir)
      {
        this.settings = settings;
        this.appDir = appDir;
        InitializeComponent();
      }

      public void setLanguage(string lang)
      {
          if (lang=="fr")
          {
              rbFrench.Checked = true;
              rbEnglish.Checked = false;
          }
          else if (lang == "en")
          {
              rbFrench.Checked = false;
              rbEnglish.Checked = true;
          }
      }

      public string getLanguage()
      {
          if (rbFrench.Checked)
              return "fr";
          if (rbEnglish.Checked)
              return "en";
          return "fr";
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
              groupBoxLanguage.Text = Utils.ReadKey(key, "GROUPBOXLANGUAGE", groupBoxLanguage.Text);
              btValide.Text = Utils.ReadKey(key, "BTVALIDE", btValide.Text);
              btCancel.Text = Utils.ReadKey(key, "BTCANCEL", btCancel.Text);
            } //Boucle clés
          } //Section choisi

        } // Boucle section
      }  //Translate

    private void FrmSettings_Shown(object sender, EventArgs e)
    {
      //-- Load translation
      Translate(appDir + "/lng/texts." + settings.langue.ToString() + ".xml");
    }

  } //class
} //namespace
