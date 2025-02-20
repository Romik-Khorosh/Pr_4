using System;
using System.Collections.Generic;

namespace Pr_4.Models;

public partial class Product
{
    public int Id { get; set; }

    public int IdTypeProduct { get; set; }

    public string Name { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal MinimumCostForApartner { get; set; }

    public virtual TypesProduct IdTypeProductNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
