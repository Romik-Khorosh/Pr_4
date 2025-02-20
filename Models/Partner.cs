using System;
using System.Collections.Generic;

namespace Pr_4.Models;

public partial class Partner
{
    public int Id { get; set; }

    public int IdTypeOfPartner { get; set; }

    public string Name { get; set; } = null!;

    public string LegalAddress { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string FullNameOfTheDirector { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Rating { get; set; }

    public virtual TypesOfPartner IdTypeOfPartnerNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
