namespace ATMSimulator.Model.Entities
{
    public class AuthorizationLog : BaseEntity
    {
        public string CardNumber { get; set; }
        public bool Result { get; set; }
    }
}
