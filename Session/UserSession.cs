namespace ATMSimulator.Session
{
    public class UserSession
    {
        private static UserSession _instance;
        private static readonly object _lock = new object();

        private Guid _cardId;

        public Guid CardId
        {
            get { return _cardId; }
            set
            {
                if (!IsLoggedIn())
                {
                    _cardId = value;
                }
            }
        }

        private UserSession()
        {
            
        }

        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new UserSession();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Logout()
        {
            _cardId = Guid.Empty;
        }

        public bool IsLoggedIn()
        {
            return _cardId != Guid.Empty;
        }

        public void SetUserParameters(Guid cardId)
        {
            if (!IsLoggedIn())
            {
                _cardId = cardId;
            }
        }
    }
}
