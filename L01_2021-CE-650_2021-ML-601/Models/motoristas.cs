using System.ComponentModel.DataAnnotations;

namespace L01_2021_CE_650_2021_ML_601.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public string nombreMotorista { get; set; }
    }
}
