namespace ATMSimulator.Session
{
    public class UserSession
    {
        private static UserSession _instance;
        private static readonly object _lock = new object();

        private Guid _accountId;
        private Guid _cardId;

        public Guid AccountId
        {
            get { return _accountId; }
            set
            {
                if (!IsLoggedIn())
                {
                    _accountId = value;
                }
            }
        }

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
            // Private constructor to prevent external instantiation
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
            _accountId = Guid.Empty;
            _cardId = Guid.Empty;
        }

        public bool IsLoggedIn()
        {
            return _accountId != Guid.Empty 
                && _cardId != Guid.Empty;
        }

        public void SetUserParameters(Guid accountId, Guid cardId)
        {
            if (!IsLoggedIn()) // Only set if not already logged in
            {
                _accountId = accountId;
                _cardId = cardId;
            }
        }
    }
}
