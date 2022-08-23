using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LoginDTO
    {
        public LoginDTO(string Email, int Password)
        {
            EmailGrab = Email;
            PasswordSet = Password;
        }
          public string EmailGrab { get; set; }
            public int PasswordSet { get; set; }

        

    }
}
