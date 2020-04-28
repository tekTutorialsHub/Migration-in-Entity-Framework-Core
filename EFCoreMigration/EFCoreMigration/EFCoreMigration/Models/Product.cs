using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMigration.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }

        public int VendorID { get; set; }
    }
}
