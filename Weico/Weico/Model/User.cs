using System;
using System.Collections.Generic;

namespace Weico.Model
{
    public partial class User
    {
        public int Uid { get; set; }
        public string NickName { get; set; }
        public string RealName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? AddressId { get; set; }
        public string LoginName { get; set; }
        public string PassWord { get; set; }
        public DateTime? RegisterTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
    }
}
