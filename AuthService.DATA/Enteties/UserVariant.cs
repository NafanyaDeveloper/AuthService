using System;
using System.Collections.Generic;
using System.Text;

namespace AuthService.DATA.Enteties
{
    public class UserVariant
    {
        public Guid UserId { get; set; }

        public Guid VariantId { get; set; }

        public User User { get; set; }

        public Variant Variant { get; set; }
    }
}
