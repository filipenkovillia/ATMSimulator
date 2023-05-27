using ATMSimulator.Model.Enum;

namespace ATMSimulator.Model.Entities
{
    public class Card : BaseEntity
    {
        public Guid AccountId { get; set; }
        public string Number { get; set; }
        public string PIN { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CardHolderName { get; set; }
        public CardType CardType { get; set; }
    }
}
