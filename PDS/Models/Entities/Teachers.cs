﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDS.Models.Entities
{
    public class Teachers :Persons
    {
        public Int64 idTeacher { get; set; }
        List<Followers> followers { get; set; }
    }
}