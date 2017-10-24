namespace Models
{
    public class HearthStoneCard
    {
        public string CardId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Faction { get; set; }

        public string Rarity { get; set; }

        public string Cost { get; set; }

        public int Attack { get; set; }

        public int Health { get; set; }

        public string Text { get; set; }

        public string Flavor { get; set; }

        public bool Collectible { get; set; }

        public bool Elite { get; set; }

        public string Race { get; set; }

        public string Locale { get; set; }

        public override string ToString()
        {
            return "Card ID: " + CardId + ". Name: " + Name;
        }
    }
    
}