using System.Collections.Generic;

namespace API.Dto
{
    public class BasketDto
    {
         public string ClientId {get; set;}
         public List<BasketItemDto> Items {get; set;}

    }
}