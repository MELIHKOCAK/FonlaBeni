namespace FonlaBeni.Domain.Entites;

public class CampaignTags
{
    public Guid CampaignId { get; set; }
    public Guid TagId { get; set; }
    public Campaign Campaign { get; set; }
    public Tag Tag { get; set; }
}
