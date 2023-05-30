using Lagi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagi.Model
{
    public class ContextMahasiswa
    {
        private string? CurrentIDMahasiswa;

        #region Properties
        public List<Mahasiswa> ctxListMahasiswa = new List<Mahasiswa>();
        #endregion

        public bool InsertMahasiswa(Mahasiswa mahasiswa)
        {
            bool isSuccess = false;
            DatabaseHelpers.GetInstance().Create("mahasiswa", mahasiswa.ToJson());

            return isSuccess;
        }

        public bool UpdateMahasiswa(Mahasiswa mahasiswa)
        {
            bool isSuccess = false;
            CurrentIDMahasiswa = mahasiswa.NIM;
            DatabaseHelpers.GetInstance().UpdateWhereString("mahasiswa", mahasiswa.ToJson(), "nim", CurrentIDMahasiswa);
            return isSuccess;
        }
    }
}
