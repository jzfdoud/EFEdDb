﻿using System;
using System.Collections.Generic;

namespace EFEdDbLib
{
    public partial class StudentClass
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public string ClassGradeValue { get; set; }

        public virtual Clas Class { get; set; }
        public virtual ClassGrade ClassGradeValueNavigation { get; set; }
        public virtual Student Student { get; set; }
    }
}
