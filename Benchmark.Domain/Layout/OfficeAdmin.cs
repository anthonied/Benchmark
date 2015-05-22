using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAuthentication.Domain;

namespace Benchmark.Domain.Layout
{
    public class OfficeAdmin: User
    {
            public OfficeAdmin(User baseUser)
            {
                BaseId = baseUser.BaseId;
                EmailAddress = baseUser.EmailAddress;
                Password = baseUser.Password;
                FullName = baseUser.FullName;
                Surname = baseUser.Surname;
                UserTypeId = baseUser.UserTypeId;
                Confirmed = baseUser.Confirmed;
                EmailId = baseUser.EmailId;
                ResetPasswordId = baseUser.ResetPasswordId;
                UserType = baseUser.UserType;
                StartPage = baseUser.StartPage;
        }
    }
}
