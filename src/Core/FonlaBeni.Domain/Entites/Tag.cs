namespace FonlaBeni.Domain.Entites;

public class Tag:BaseEntity
{
    public string Name { get; set; }
    public string Slug { get; set; }

    //Navigation Property
    public ICollection<CampaignTags> CampaignTags { get; set; }
}
