using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Ecomm_5_2.Models
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public double price { get; set; }

        public List<string> tags { get; set; }
        public Dimensions dimensions { get; set; }

        public List<Review> reviews { get; set; }

        public Product()
        {
            dimensions=new Dimensions();
            reviews = new List<Review>();
        }

    }
    public class Dimensions
    {
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }
    }
    public class Review
    {
        public int rating { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
        public string reviewerName { get; set; }
        public string reviewerEmail { get; set; }
    }
}
