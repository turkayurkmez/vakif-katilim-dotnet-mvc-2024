namespace eshop.MVC.Models
{
    public class PagingInfo
    {
        public int CurrentPage { get; set; }

        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalPages { get => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
    }
}
