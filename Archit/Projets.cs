using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archit
{
  public class StoreProjets
  {
    //public DateTimeOffset Date { get; set; }
    //public int TemperatureCelsius { get; set; }
    //public string Summary { get; set; }
    //public string SummaryField;
    //public IList<DateTimeOffset> DatesAvailable { get; set; }
    public List<Projet> Projets { get; set; }
    //public string[] SummaryWords { get; set; }
  }

  public class Projet
  {
    public string Nom { get; set; }
    public string Src { get; set; }
    public string Dst { get; set; }
    public string Format { get; set; }

  }

} //namespace
