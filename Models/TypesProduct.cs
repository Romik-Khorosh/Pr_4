using System;
using System.Collections.Generic;

namespace Pr_4.Models;

public partial class TypesProduct
{
    public int Id { get; set; }

    public string TypeProduct { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
