using System;
using System.Collections.Generic;

namespace EFEdDbLib
{
    public partial class Assignment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ClassId { get; set; }

        public virtual Clas Class { get; set; }
    }
}
