using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Cart.Domain
{
    public class CartHeader
    {
        [Key]
        public int CartHeaderId { get; set; }

        public string? UserId { get; set; }

        public bool LoyaltyMembershipOpted { get; set; }

        [NotMapped]
        public double CartTotal { get; set; }
    }
}
