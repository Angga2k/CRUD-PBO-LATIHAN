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
        private int? CurrentIDMahasiswa;

        #region Properties
        public List<Mahasiswa> ctxListMahasiswa = new List<Mahasiswa>();
        #endregion

        public bool InsertMahasiswa(Mahasiswa mahasiswa)
        {
            bool isSuccess = false;
            int affectedRows = 0;
            if (CurrentIDMahasiswa == null)
            {
                affectedRows = DatabaseHelpers.GetInstance().Create("mahasiswa", mahasiswa.ToJson());
                
            }


            return isSuccess;
        }
    }
}
