using System;
using System.Collections.Generic;

namespace DM_helper.Models
{
    public class Campaign
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<CampaignNote> Notes { get; set; }
        public List<Session> Sessions { get; set; }
    }

    public class CampaignNote
    {
        public int ID { get; set; }
        public string NoteText { get; set; }
        public DateTime Timestamp { get; set; }
        public Campaign Campaign { get; set; }
    }
}