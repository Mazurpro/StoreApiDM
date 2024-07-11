using System.ComponentModel.DataAnnotations;


public partial class Store
{
    [Key]
    public int StoreId { get; set; }

    public Guid StoreGuid { get; set; }

    public string? Name { get; set; }
}