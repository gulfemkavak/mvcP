using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcP.Models
{
	public class Admin
	{
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName ="Varchar(50)")]
        public string Kullanici { get; set; }
        [Column(TypeName ="Varchar(50)")]
        public string Password { get; set; }
        
    }
}
