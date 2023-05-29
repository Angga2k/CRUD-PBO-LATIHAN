using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lagi.Model
{
    public class Mahasiswa
    {
        public string? NIM { get; set; }
        public string? Nama { get; set; }
        public string? Alamat { get; set; }
        public DateOnly TglLahir { get; set; }
        public string? KdProgramStudi { get; set; }
        public string? ProgramStudi { get; set; }
        public decimal UKT { get; set; }
        public Boolean isActive { get; set; }

        public Dictionary<string, object> ToJson() => new Dictionary<string, object>
        {
            { "nim", NIM },
            { "nama", Nama },
            { "alamat", Alamat },
            { "tgl_lahir", TglLahir.ToString("yyyy-MM-dd") },
            { "kd_prodi", KdProgramStudi },
            { "ukt", UKT },
            { "is_active", isActive }
        };
    }
}
