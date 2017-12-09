using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Benner.Microondas.Site.Models
{
  public class MicroondasModel
  {
    public string Status { get; set; }

    [DisplayName("Tempo de Cozimento")]
    [Required(ErrorMessage = "Informe o tempo de cozimento")]
    public TimeSpan Tempo { get; set; }

    [DisplayName("Potência")]
    [Required(ErrorMessage = "Informe a potência")]
    public int Potencia { get; set; }
  }
}