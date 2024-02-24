using System.ComponentModel.DataAnnotations;

namespace L01_2021_CE_650_2021_ML_601.Models
{
    public class platos
    {
        [Key]
        public int platoId { get; set; }
        public string nombrePlato { get; set; }
        public int? precio { get; set;}
    }
}
