namespace PSuite.Models
{
    public class User
    {
        private int userID;
        private string userName;
        private string password;
        private string isValid;

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string IsValid
        {
            get
            {
                return isValid;
            }

            set
            {
                isValid = value;
            }
        }

       
    }
}
