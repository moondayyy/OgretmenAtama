﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgretmenAtama.Domain.Entities.Concrete
{
    public class KurumlarAlanlar:Base
    {
        public string KurumKodu { get; set; }
        public string AlanKodu { get; set; }
        public string BosKontenjan { get; set; }
    }
}
