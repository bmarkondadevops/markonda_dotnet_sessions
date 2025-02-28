namespace RegistrationFormValidationUsingJQuery.Services
{
    public class AuthenticationLogin
        {
            private Dictionary<string, string> userDetails = new Dictionary<string, string>()
        {
            {"Markonda","Pass1" },
            {"Preethi","Pass2" },
            {"Kannan","Pass3" }
        };

            public bool IsValid(string username, string password)
            {
                if (userDetails.ContainsKey(username) && (userDetails[username] == password))
                {
                    return true;
                }
                return false;
            }
        }


    }
