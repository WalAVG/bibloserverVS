using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Dto.Get
{
    public class AddressDTO
    {
        public String nation { get; set; }

        public String region { get; set; }

        public String city { get; set; }

        public int id { get; set; }
    }
}
