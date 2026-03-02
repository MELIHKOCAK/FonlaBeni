namespace FonlaBeni.Domain.Entites;

public class CampaignImage : BaseEntity
{
    public string Url { get; set; } = default!;
    public Campaign Campaign { get; set; } = default!;

    //Foreign Key
    public Guid CampaignId { get; set; }
}
