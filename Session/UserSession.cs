namespace ATMSimulator.Session
{
    public class UserSession
    {
        private static UserSession _instance;
        private static readonly object _lock = new object();

        private int _cardId;

        public int CardId
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
            _cardId = 0;
        }

        public bool IsLoggedIn()
        {
            return _cardId != 0;
        }

        public void SetUserParameters(int cardId)
        {
            if (!IsLoggedIn())
            {
                _cardId = cardId;
            }
        }
    }
}
