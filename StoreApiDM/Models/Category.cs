﻿using System.ComponentModel.DataAnnotations;

namespace StoreApiDM.Models;

public partial class Category
{
    [Key]
    public int CategoryId { get; set; }

    public Guid CategoryGuid { get; set; }

    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}
