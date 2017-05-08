using System;
using System.Collections.Generic;
using System.Text;

namespace SharePlay.Entities
{
    public class BaseClass
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedDate {get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
