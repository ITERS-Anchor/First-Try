using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public enum LoginResult
    {
        InvalidUserName,
        InvalidPassword,
        StateError,
        LoginSuccessful
    }
}
