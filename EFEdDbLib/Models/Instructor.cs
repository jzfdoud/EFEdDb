﻿using System;
using System.Collections.Generic;

namespace EFEdDbLib
{
    public partial class Instructor
    {
        public Instructor()
        {
            Class = new HashSet<Clas>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int YearsExperience { get; set; }
        public bool IsTenured { get; set; }

        public virtual ICollection<Clas> Class { get; set; }
    }
}
