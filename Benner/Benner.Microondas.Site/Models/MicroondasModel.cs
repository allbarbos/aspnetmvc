using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Benner.MicroondasOnline.Site.Models
{
  public class MicroondasModel
  {
    public bool Rapido { get; set; }

    [DisplayName("Tempo de Cozimento")]
    [Required(ErrorMessage = "Informe o tempo de cozimento")]
    public TimeSpan Tempo { get; set; }

    [DisplayName("Potência")]
    [Required(ErrorMessage = "Informe a potência")]
    public int Potencia { get; set; }

    public string Status { get; set; }
  }
}