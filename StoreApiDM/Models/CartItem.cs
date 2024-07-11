using System.ComponentModel.DataAnnotations;

namespace StoreApiDM.Services;

public partial class CartItem
{
    [Key]
    public int CartItemId { get; set; }

    public Guid CartItemGuid { get; set; }

    public string? CartId { get; set; }
    public int ProductId { get; set; }
    public int? Count { get; set; }
    public DateTime? DateCreated { get; set; }
}
