﻿using System;
using System.Collections.Generic;
using System.Text;

namespace People.Data.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Payment { get; set; }
        public int IdKindService { get;set; }
        public int IdResidence { get; set; }

        public KindService KindService { get; set; }
        public Residence Residence { get; set; }
    }
}
