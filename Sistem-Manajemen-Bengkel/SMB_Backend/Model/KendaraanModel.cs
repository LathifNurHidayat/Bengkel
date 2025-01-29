﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class KendaraanModel
    {
        public int id_kendaraan { get; set; }
        public int no_ktp { get; set; }
        public string no_polisi { get; set; }
        public string merek { get; set; }
        public string transmisi { get; set; }
        public int kapasitas_mesin { get; set; }
        public int tahun { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}