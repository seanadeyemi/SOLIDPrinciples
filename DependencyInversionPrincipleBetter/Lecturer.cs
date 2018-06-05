﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department Department { get; set; }

        public List<Course> Courses { get; set; }


    }
}
