﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {
        public string  regNo { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }

        public string GetfullName()
        {
            return firstName + lastName;
        }
    }
}
