namespace LoginMiddlewareExcerciseClassOriented.Models
{
    public class LoginDataBase
    {
        public string userName { get; set; }
        public string password { get; set; }

        public IDictionary<string, string> dataBase {  get{ return userDatabase(); } }



        public IDictionary<string, string> userDatabase()
        {
            IDictionary<string, string> userDataBase = new Dictionary<string, string>();        
            userDataBase.Add(new KeyValuePair<string, string>("preethi", "Password"));
            userDataBase.Add(new KeyValuePair<string, string>("minu", "Password"));
            return userDataBase;
        }
        
        public bool isAuthenticated (string userName)
        {
           var userlist = userDatabase();
           bool isAuthenticated = false;
           foreach(var user in userlist)
            {
                if (userName == user.Key)
                {
                    isAuthenticated= true;
                    break;
                }
                
            }
            return isAuthenticated;
           
        }
        public bool isAuthorised(string password)
        {
            var userlist = userDatabase();
            bool isAuthenticated = false;
            foreach (var pass in userlist)
            {
                if (password == pass.Value)
                {
                    isAuthenticated = true;
                    break;
                }

            }
            return isAuthenticated;

        }
    }
}
