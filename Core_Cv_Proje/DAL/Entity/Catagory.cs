using System.ComponentModel.DataAnnotations;

namespace Core_Cv_Proje.DAL.Entity
{

    public class Catagory
    {
        [Key]
        public int CatagoryID { get; set; }
        public string? CatagoryName { get; set; }

    }
}
