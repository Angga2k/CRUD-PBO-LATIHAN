using Lagi.Helper;
using Lagi.Model;
using Npgsql;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Lagi
{
    public partial class Form1 : Form
    {
        public string CurrentIDMahasiswa;
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
            SetDataGrid();
        }

        private void SetDataGrid()
        {
            dataGridView1.Columns["NIM"].HeaderText = "NIM";
            dataGridView1.Columns["Nama"].HeaderText = "Nama";
            dataGridView1.Columns["Alamat"].HeaderText = "Alamat";
            dataGridView1.Columns["TglLahir"].HeaderText = "Tanggal Lahir";
            dataGridView1.Columns["KdProgramStudi"].HeaderText = "Kode Program Studi";
            dataGridView1.Columns["ProgramStudi"].HeaderText = "Program Studi";
            dataGridView1.Columns["UKT"].HeaderText = "UKT";
            dataGridView1.Columns["isActive"].HeaderText = "Aktif";
            dataGridView1.Columns["Delete"].DisplayIndex = 8;
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
            DataTable Mahasiswas = DatabaseHelpers.GetInstance().ReadJoin(mainTable, joinTable, joinCondition, null);
            DataTableReader reader = Mahasiswas.CreateDataReader();
            listMahasiswas.Clear();
            while (reader.Read())
            {
                Mahasiswa newMaha = new Mahasiswa();

                newMaha.NIM = (string)reader["NIM"];
                newMaha.Nama = (string)reader["nama"];
                newMaha.Alamat = (string)reader["alamat"];
                newMaha.TglLahir = DateOnly.FromDateTime((DateTime)reader["tgl_lahir"]);
                newMaha.KdProgramStudi = (string)reader["kd_prodi"];
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
            if (CurrentIDMahasiswa == "")
            {
                mhsContext.InsertMahasiswa(mahasiswa);

            }
            else
            {
                mhsContext.UpdateMahasiswa(mahasiswa);
            }
            dataGridView1.DataSource = null;
            DataMahasiswa();
            SetDataGrid();
            ClearCurrentLaptopEditing();
        }
        private void OndataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Point clickLocation = dataGridView1.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hit = dataGridView1.HitTest(clickLocation.X, clickLocation.Y);
            if (hit.Type == DataGridViewHitTestType.Cell)
            {
                textBox1.Enabled = false;
                Mahasiswa mahasiswa = listMahasiswas[e.RowIndex];
                CurrentIDMahasiswa = mahasiswa.NIM;
                textBox1.Text = mahasiswa.NIM;
                textBox2.Text = mahasiswa.Nama;
                textBox3.Text = mahasiswa.Alamat;
                dateTimePicker1.Value = new DateTime(mahasiswa.TglLahir.Year, mahasiswa.TglLahir.Month, mahasiswa.TglLahir.Day);
                comboBox1.SelectedValue = mahasiswa.KdProgramStudi;
                textBox4.Text = mahasiswa.UKT.ToString();
                checkBox1.Checked = mahasiswa.isActive;
            }
            else if (hit.Type == DataGridViewHitTestType.ColumnHeader)
            {

            }
        }
        public void ClearCurrentLaptopEditing()
        {
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "0";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            checkBox1.Checked = false;
            CurrentIDMahasiswa = null;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnButtonResetClick(object sender, EventArgs e)
        {
            ClearCurrentLaptopEditing();
        }
    }
}