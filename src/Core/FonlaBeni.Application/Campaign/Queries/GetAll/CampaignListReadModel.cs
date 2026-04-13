using System;
using System.Collections.Generic;
using System.Text;

namespace FonlaBeni.Application.Campaign.Queries.GetAll
{
    public class CampaignListReadModel
    {
        public Guid Id { get; init; }
        public string Title { get; init; }
        public decimal GoalAmount { get; init; }
        public decimal CurrentAmount { get; init; }
        public string CategoryName { get; init; }
        public string CreatorFullName { get; init; }
        public decimal ProgressPercentage { get; init; }
    }
}
