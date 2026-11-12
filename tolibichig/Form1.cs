using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace tolibichig
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=toli.db;";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM words";
                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Өгөгдөл ачаалахад алдаа гарлаа: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEng.Text) || string.IsNullOrWhiteSpace(txtMon.Text))
            {
                MessageBox.Show("Англи болон Монгол утгыг заавал оруулна уу!");
                return;
            }

            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO words (eng, mon, rus) VALUES (@eng, @mon, @rus)";
                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eng", txtEng.Text.Trim());
                        cmd.Parameters.AddWithValue("@mon", txtMon.Text.Trim());
                        cmd.Parameters.AddWithValue("@rus", txtRus.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Амжилттай нэмэгдлээ!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Нэмэхэд алдаа гарлаа: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["id"].Value == null) return;
                string id = selectedRow.Cells["id"].Value.ToString();

                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE words SET eng = @eng, mon = @mon, rus = @rus WHERE id = @id";
                        using (SqliteCommand cmd = new SqliteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@eng", txtEng.Text.Trim());
                            cmd.Parameters.AddWithValue("@mon", txtMon.Text.Trim());
                            cmd.Parameters.AddWithValue("@rus", txtRus.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Амжилттай засагдлаа!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Засахад алдаа гарлаа: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Засах мөрөө хүснэгтээс сонгоно уу!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["id"].Value == null) return;
                string id = selectedRow.Cells["id"].Value.ToString();

                DialogResult dr = MessageBox.Show("Энэ үгийг устгахдаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqliteConnection conn = new SqliteConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM words WHERE id = @id";
                            using (SqliteCommand cmd = new SqliteCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }
                            LoadData();
                            ClearFields();
                            MessageBox.Show("Амжилттай устгагдлаа!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Устгахад алдаа гарлаа: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Устгах мөрөө хүснэгтээс сонгоно уу!");
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string keyword = "%" + txtSearch.Text.Trim() + "%";
                    string query = "SELECT * FROM words WHERE eng LIKE @kw OR mon LIKE @kw OR rus LIKE @kw";

                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kw", keyword);
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception)
                {
                    // Хайлтын үеийн түр зуурын алдааг алгасах
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadData();
        }

        private void ClearFields()
        {
            txtEng.Clear();
            txtMon.Clear();
            txtRus.Clear();
            txtSearch.Clear();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtEng.Text = row.Cells["eng"].Value?.ToString() ?? "";
                txtMon.Text = row.Cells["mon"].Value?.ToString() ?? "";
                txtRus.Text = row.Cells.Contains("rus") && row.Cells["rus"].Value != null ? row.Cells["rus"].Value.ToString() : "";
            }
        }
    }
}