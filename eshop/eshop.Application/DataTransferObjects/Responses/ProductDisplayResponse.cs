using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application.DataTransferObjects.Responses
{
    public record ProductDisplayResponse(int Id, string Name, string? Description, decimal? Price, string? ImageUrl,int? CategoryId, string? CategoryName );
   
}
