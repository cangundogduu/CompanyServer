using Microsoft.AspNetCore.Authorization;

namespace Company.API.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
