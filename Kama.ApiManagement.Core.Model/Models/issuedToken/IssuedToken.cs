using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kama.ApiManagement.Core.Model
{
    public class IssuedToken : Model
    {
        public int Total { get; set; }

        public Guid? UserID { get; set; }

        public Guid ClientID { get; set; }

        public Guid RefreshTokenID { get; set; }

        public DateTime IssuedDate { get; set; }

        public DateTime ExpireDate { get; set; }

        public string Token { get; set; }

        public bool Expired => ExpireDate < DateTime.Now;    // && RefrshTokenExpireDate < DateTime.Now;

        public Guid? RefrshTokenID { get; set; }

        public DateTime? RefrshTokenExpireDate { get; set; }

    }
}
