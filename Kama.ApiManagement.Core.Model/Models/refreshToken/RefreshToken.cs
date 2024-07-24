using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kama.ApiManagement.Core.Model
{
    public class RefreshToken : Model
    {
        public int Total { get; set; }

        public Guid UserID { get; set; }

        public DateTime IssuedDate { get; set; }

        public DateTime ExpireDate { get; set; }

        public string ProtectedTicket { get; set; }

        public string SsoTicket { get; set; }

        public bool Expired => DateTime.Now > ExpireDate;

        public OperatingSystemType OS { get; set; }

        public string OSVersion { get; set; }

        public BrowserType Browser { get; set; }

        public string BrowserVersion { get; set; }

        public DeviceType DeviceType { get; set; }

    }
}
