using Partial_view_and_view_component.DataAccessLayer.Entites;

namespace Partial_view_and_view_component.Models
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
