using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Service
{
    interface ILoginService
    {
        void login(String email,String password);
    }
}
