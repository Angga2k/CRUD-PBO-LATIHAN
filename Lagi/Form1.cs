using Lagi.Helper;
using Lagi.Model;
using Npgsql;
using System.Data;
using System.Globalization;

namespace Lagi
{
    public partial class Form1 : Form
    {
        Mahasiswa mahasiswa = new Mahasiswa();
        public List<Mahasiswa> listMahasiswas = new List<Mahasiswa>();

        Model.ContextMahasiswa mhsContext;
        List<Prodi> Prodis = new List<Prodi>();

        public Form1()
        {
            InitializeComponent();
            mhsContext = new Model.ContextMahasiswa();

            DataProdi();
            CreateDataMahasiswa();
            DataMahasiswa();
        }



        private void DataProdi()
        {
            Prodis.Add(new Prodi() { KdProdi = "1", NamaProdi = "Sistem Informasi" });
            Prodis.Add(new Prodi() { KdProdi = "2", NamaProdi = "Teknologi Informasi" });
            Prodis.Add(new Prodi() { KdProdi = "3", NamaProdi = "Informatika" });

            comboBox1.DataSource = Prodis;
            comboBox1.ValueMember = "KdProdi";
            comboBox1.DisplayMember = "NamaProdi";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }
        public void DataMahasiswa()
        {

            string mainTable = "mahasiswa";
            string joinTable = "prodi";
            string joinCondition = "mahasiswa.kd_prodi= prodi.kd_prodi";
            DataTable Mahasiswas = DatabaseHelpers.GetInstance().ReadJoin(mainTable, joinTable, joinCondition,null);
            DataTableReader reader = Mahasiswas.CreateDataReader();
            listMahasiswas.Clear();
            while (reader.Read())
            {
                Mahasiswa newMaha = new Mahasiswa();

                newMaha.NIM = (string)reader["NIM"];
                newMaha.Nama = (string)reader["nama"];
                newMaha.Alamat = (string)reader["alamat"];
                newMaha.TglLahir = DateOnly.FromDateTime((DateTime)reader["tgl_lahir"]);
                newMaha.KdProgramStudi= (string)reader["kd_prodi"];
                newMaha.ProgramStudi = (string)reader["nama_prodi"];
                newMaha.UKT = (decimal)reader["ukt"];
                newMaha.isActive = (bool)reader["is_active"];
                listMahasiswas.Add(newMaha);
            }
            mhsContext.ctxListMahasiswa = listMahasiswas;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mhsContext.ctxListMahasiswa;

        }
        private Model.Mahasiswa CreateDataMahasiswa()
        {
            mahasiswa.NIM = textBox1.Text;
            mahasiswa.Nama = textBox2.Text;
            mahasiswa.Alamat = textBox3.Text;
            mahasiswa.TglLahir = DateOnly.Parse(dateTimePicker1.Value.ToShortDateString());
            mahasiswa.KdProgramStudi = ((Prodi)comboBox1.SelectedItem).KdProdi;
            mahasiswa.ProgramStudi = ((Prodi)comboBox1.SelectedItem).NamaProdi;

            mahasiswa.UKT = decimal.Parse(textBox4.Text);

            mahasiswa.isActive = checkBox1.Checked;
            
            return mahasiswa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Mahasiswa mahasiswa = CreateDataMahasiswa();
            mhsContext.InsertMahasiswa(mahasiswa);
            dataGridView1.DataSource = null;
            DataMahasiswa();
        }
    }
}