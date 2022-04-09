using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.DataAccess.Entity
{
    public class Category
    {
        [Key]
        public int CategoryID{ get; set; }
        public string CategoryName { get; set; }
    }
}
