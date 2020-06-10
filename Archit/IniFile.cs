/*
___________________________________________________________
Projet CATS - L'OREAL
Copyright EKIUM
___________________________________________________________
Objet : Gestion fichiers ".ini"
___________________________________________________________
Auteur(s):
- Pierre Delore
___________________________________________________________
*/


using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;


/*
How to use it
Open the INI file in one of the 3 following ways:

// Creates or loads an INI file in the same directory as your executable
// named EXE.ini (where EXE is the name of your executable)
var MyIni = new IniFile();

// Or specify a specific name in the current dir
var MyIni = new IniFile("Settings.ini");

// Or specify a specific name in a specific dir
var MyIni = new IniFile(@"C:\Settings.ini");
You can write some values like so:

MyIni.Write("DefaultVolume", "100");
MyIni.Write("HomePage", "http://www.google.com");
To create a file like this:

[MyProg]
DefaultVolume=100
HomePage=http://www.google.com
To read the values out of the INI file:

var DefaultVolume = IniFile.Read("DefaultVolume");
var HomePage = IniFile.Read("HomePage");
Optionally, you can set [Section]'s:

MyIni.Write("DefaultVolume", "100", "Audio");
MyIni.Write("HomePage", "http://www.google.com", "Web");
To create a file like this:

[Audio]
DefaultVolume=100

[Web]
HomePage=http://www.google.com
You can also check for the existence of a key like so:

if(!MyIni.KeyExists("DefaultVolume", "Audio"))
{
    MyIni.Write("DefaultVolume", "100", "Audio");
}
You can delete a key like so:

MyIni.DeleteKey("DefaultVolume", "Audio");
You can also delete a whole section (including all keys) like so:

MyIni.DeleteSection("Web");
Please feel free to comment with any improvements!
*/


public class IniFile
{
  string Path;
  string EXE = Assembly.GetExecutingAssembly().GetName().Name;

  [DllImport("kernel32")]
  static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

  [DllImport("kernel32")]
  static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

  public IniFile(string IniPath = null)
  {
    Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
  }

  public string Read(string Key, string Default, string Section = null)
  {
    var RetVal = new StringBuilder(255);
    GetPrivateProfileString(Section ?? EXE, Key, Default, RetVal, 255, Path);
    return RetVal.ToString();
  }

  public void Write(string Key, string Value, string Section = null)
  {
    WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
  }

  public void DeleteKey(string Key, string Section = null)
  {
    Write(Key, null, Section ?? EXE);
  }

  public void DeleteSection(string Section = null)
  {
    Write(null, null, Section ?? EXE);
  }

  public bool KeyExists(string Key, string Section = null)
  {
    return Read(Key, Section).Length > 0;
  }



    /// <summary>
    /// Lit un entier dans un fichier ini
    /// </summary>
    /// <param name="f">Handle du fichier ini à lire</param>
    /// <param name="Item">Chaine contenant le nom de l'élément à lire</param>
    /// <param name="Section">Chaine contenant la section de l'élément à lire</param>
    /// <param name="ValeurParDefaut">Valeur par défaut</param>
    /// <param name="Etat">Référence sur le booleen qui indique l'état de la lecture du fichier ini. Cette variable n'est modifié qu'en cas de problème de lecture</param>
    /// <param name="Etat">Référence sur la chaine contenant l'erreur sous forme "[Section] - Elément"</param>
    /// <returns></returns>
    public int ReadInt(string Item, string Section, int ValeurParDefaut, ref bool Etat, ref string EtatErreurStr)
    {
      string s = Read(Item, "", Section);
      int v = ValeurParDefaut;
      if (s != "")
      {
        v = ValeurParDefaut;
        try
        {
          v = int.Parse(s);
          return v;
        }
        catch (System.Exception ex)
        {
          DoNothing(ex);
        }
      }
      EtatErreurStr = "[" + Section + "] - " + Item;
      Etat = false;
      return v;
    }


  /// <summary>
  /// Lit un entier dans un fichier ini
  /// </summary>
  /// <param name="f">Handle du fichier ini à lire</param>
  /// <param name="Item">Chaine contenant le nom de l'élément à lire</param>
  /// <param name="Section">Chaine contenant la section de l'élément à lire</param>
  /// <param name="ValeurParDefaut">Valeur par défaut</param>
  /// <returns></returns>
  public int ReadInt(string Item, string Section, int ValeurParDefaut)
  {
    string s = Read(Item, "", Section);
    int v = ValeurParDefaut;
    if (s != "")
    {
      v = ValeurParDefaut;
      try
      {
        v = int.Parse(s);
        return v;
      }
      catch (System.Exception ex)
      {
        DoNothing(ex);
      }
    }
    return v;
  }

  /// <summary>
  /// Lit un double dans un fichier ini
  /// </summary>
  /// <param name="f">Handle du fichier ini à lire</param>
  /// <param name="Item">Chaine contenant le nom de l'élément à lire</param>
  /// <param name="Section">Chaine contenant la section de l'élément à lire</param>
  /// <param name="ValeurParDefaut">Valeur par défaut</param>
  /// <returns></returns>
  public double ReadDouble(string Item, string Section, double ValeurParDefaut)
  {
    string s = Read(Item, "", Section);
    double v = ValeurParDefaut;
    if (s != "")
    {
      v = ValeurParDefaut;
      try
      {
        v = double.Parse(s, CultureInfo.CreateSpecificCulture("en-GB"));
        return v;
      }
      catch (System.Exception ex)
      {
        DoNothing(ex);
      }
    }
    return v;
  }


  /// <summary>
  /// Lit un double dans un fichier ini
  /// </summary>
  /// <param name="f">Handle du fichier ini à lire</param>
  /// <param name="Item">Chaine contenant le nom de l'élément à lire</param>
  /// <param name="Section">Chaine contenant la section de l'élément à lire</param>
  /// <param name="ok">Référence sur une variable boolèene qui va indiquer si on a eu une 
  /// erreur de lecture (item non trouvé ou erreur de conversion). La valeur n'est modifiée que 
  /// si il y a un problème. Il faut donc mettre la variable à true avant l'utilisation. Cela 
  /// permet d'enchainer plusieurs conversion et de savoir à la fin si tout c'est bien passé.
  /// <returns>Valeur lue</returns>
  public double ReadDoubleEx(string Item, string Section, ref bool ok)
  {
    string s = Read(Item, "", Section);
    double v = -9999999;
    IFormatProvider provider=CultureInfo.CreateSpecificCulture("en-GB"); ;

    if (s != "")
    {
      try
      {
        v = double.Parse(s,provider);
        return v;
      }
      catch (System.Exception ex)
      {
        ok = false;
        DoNothing(ex);
      }
    }
    else
      ok = false;
    return v;
  }


  /// <summary>
  /// function juste pour supprimer un warning de compilation
  /// </summary>
  /// <param name="ex"></param>
  private void DoNothing(System.Exception ex)
  {

  }

}

