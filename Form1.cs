using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public class SinhVien
        {
            public string MaSinhVien { get; set; }
            public string HoTen { get; set; }
            public string LopHoc { get; set; }
        }

        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect=false;

        }
        private void HienThiDanhSach()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSinhVien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSinhVien = textBox1.Text,
                HoTen = textBox2.Text,
                LopHoc = textBox3.Text
            };
            danhSachSinhVien.Add(sv);
            HienThiDanhSach();
            xoa();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void xoa()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                danhSachSinhVien[index].MaSinhVien = textBox1.Text;
                danhSachSinhVien[index].HoTen = textBox2.Text;
                danhSachSinhVien[index].LopHoc = textBox3.Text;
                HienThiDanhSach();
                xoa();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                danhSachSinhVien.RemoveAt(index);
                HienThiDanhSach();
                xoa();
            }
        }
    }
}