using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archit
{
  public static class Utils
  {
    public static string GenereNomArchive(string format, string comment)
    {
      string res="";
      int i = 0;

      while (i < format.Length)
      {
        if (format[i] == '%')
        {
          i++;
          if (i < format.Length)
          {
            switch (format[i])
            {
              case 'Y':  //%Y :Année 4 chiffres (2008)
                res = res + DateTime.Now.ToString("yyyy");
                break;
              case 'y':  //%y :Année 2 chiffres (08)
                res = res + DateTime.Now.ToString("yy");
                break;
              case 'M':  //%M :Mois (00 à 12)
                res = res + DateTime.Now.ToString("MM");
                break;
              case 'J':  //%J :Jour (01 à 31)
                res = res + DateTime.Now.ToString("dd");
                break;
              case 'h':  //%h :heure (00 à 23)
                res = res + DateTime.Now.ToString("HH");
                break;
              case 'm':  //%m :minute (00 à 59)
                res = res + DateTime.Now.ToString("mm");
                break;
              case 's':  //%s :seconde (00 à 59)
                res = res + DateTime.Now.ToString("ss");
                break;
              case 'C':  //%C :Chaine saisie dans le champ commentaire
                res = res + comment;
                break;
            }
          }
        }
        else
          res = res + format[i];
        i++;
      }
      return res;
    }

  } //class
} //namespace
