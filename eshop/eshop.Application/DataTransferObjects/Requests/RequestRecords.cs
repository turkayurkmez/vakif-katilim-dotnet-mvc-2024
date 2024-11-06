using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application.DataTransferObjects.Requests
{
    public record CreateNewProductRequest(
        [Required(ErrorMessage = "Ürün Adını belirtiniz")] string Name,
        string? Description,
        decimal? Price,
        string? ImageUrl,
        int? CategoryId
     );

    public record UpdateExistingProductRequest(
        int Id,
        [Required(ErrorMessage = "Ürün Adını belirtiniz")] string Name,
        string? Description,
        decimal? Price,
        string? ImageUrl,
        int? StockCount,
        int? CategoryId
        );

}
