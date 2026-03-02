namespace FonlaBeni.Domain.Entites;
public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }

    public ICollection<Campaign> Campaigns { get; set; }
}
