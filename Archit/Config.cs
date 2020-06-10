
namespace Archit
{
    public class Config
    {
        public string langue;
        public string CfgDir;
        public string CfgName;

        public Config(string dir, string name)
        {
            this.CfgDir = dir;
            this.CfgName = name;
            langue = "fr";
        }


        //=========================================================================
        /// <summary>
        /// Lecture de la configuration
        /// </summary>
        public void Load()
        {
            if (System.IO.File.Exists(CfgDir + "/" + CfgName) == false) return;

            var Ini = new IniFile(CfgDir + "/" + CfgName);

            langue = Ini.Read("Language", "en", "General");


        }


        /// <summary>
        /// Ecriture de la configuration
        /// </summary>
        public void Save()
        {
            //-- Le répertoire n'existe pas? On le crée
            if (!System.IO.Directory.Exists(CfgDir))
            {
                System.IO.Directory.CreateDirectory(CfgDir);
            }

            var Ini = new IniFile(CfgDir + "/" + CfgName);

            Ini.Write("Language", langue, "General");
        }

    } //class

} //namespace
