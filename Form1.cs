using System.Data;
using MySql.Data.MySqlClient;

namespace ToDoApplication
{
    // Form utama aplikasi ToDo
    public partial class Form1 : Form
    {
        // Konstruktor untuk inisialisasi komponen form
        public Form1()
        {
            InitializeComponent();
        }

        // DataTable untuk menampung data todo dari database
        DataTable todoList = new DataTable();

        // Variabel untuk menandakan apakah sedang dalam mode edit
        bool isEditing = false;

        // Fungsi untuk mendapatkan koneksi ke database MySQL
        private MySqlConnection GetConnection()
        {
            // Mengembalikan koneksi ke database 'todo_db' dengan username 'root' dan tanpa password
            return new MySqlConnection("Server=localhost;Database=todo_db;Uid=root;Pwd=;");
        }

        // Event handler ketika form pertama kali dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); // Panggil fungsi untuk memuat data dari database
            toDoListView.DataSource = todoList; // Menampilkan data todo ke ListView
        }

        // Fungsi untuk memuat data dari database ke DataTable
        private void LoadData()
        {
            using (var connection = GetConnection())  // Membuka koneksi ke database
            {
                connection.Open();  // Membuka koneksi
                string query = "SELECT id, Time, Title, Description FROM todos";  // Query untuk mengambil data todo

                using (var cmd = new MySqlCommand(query, connection))  // Menjalankan query
                using (var adapter = new MySqlDataAdapter(cmd))  // Menggunakan DataAdapter untuk mengisi DataTable
                {
                    todoList.Clear();  // Menghapus data yang ada sebelumnya di DataTable
                    adapter.Fill(todoList);  // Mengisi DataTable dengan data dari database
                }
            }
        }

        // Event handler ketika tombol 'Save' diklik
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var connection = GetConnection())  // Membuka koneksi ke database
            {
                connection.Open();  // Membuka koneksi
                string query = isEditing
                    // Jika sedang edit, lakukan UPDATE
                    ? "UPDATE todos SET Time=@Time, Title=@Title, Description=@Description WHERE id=@Id"
                    // Jika tidak sedang edit, lakukan INSERT
                    : "INSERT INTO todos (Time, Title, Description) VALUES (@Time, @Title, @Description)";

                using (var cmd = new MySqlCommand(query, connection))  // Menjalankan query
                {
                    // Menambahkan parameter ke query
                    cmd.Parameters.AddWithValue("@Time", timeTextBox.Text);
                    cmd.Parameters.AddWithValue("@Title", titleTextBox.Text);
                    cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);

                    // Jika sedang dalam mode edit, tambahkan parameter ID
                    if (isEditing)
                        cmd.Parameters.AddWithValue("@Id", todoList.Rows[toDoListView.CurrentCell.RowIndex]["id"]);

                    cmd.ExecuteNonQuery();  // Menjalankan query untuk menyimpan data
                }
            }

            LoadData();  // Memuat ulang data setelah menyimpan
            ClearFields();  // Membersihkan form input setelah menyimpan
        }

        // Fungsi untuk membersihkan field input
        private void ClearFields()
        {
            timeTextBox.Text = "";  // Mengosongkan text box waktu
            titleTextBox.Text = "";  // Mengosongkan text box judul
            descriptionTextBox.Text = "";  // Mengosongkan text box deskripsi
            isEditing = false;  // Mengubah mode ke tidak edit
        }

        // Event handler ketika tombol 'Edit' diklik
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditing = true;  // Mengubah mode ke edit

            // Mengisi form input dengan data yang dipilih dari ListView
            timeTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex]["Time"].ToString();
            titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"].ToString();
            descriptionTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"].ToString();
        }

        // Event handler ketika tombol 'Delete' diklik
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var connection = GetConnection())  // Membuka koneksi ke database
            {
                connection.Open();  // Membuka koneksi
                string query = "DELETE FROM todos WHERE id=@Id";  // Query untuk menghapus data berdasarkan ID

                using (var cmd = new MySqlCommand(query, connection))  // Menjalankan query
                {
                    // Menambahkan parameter ID untuk menghapus data yang sesuai
                    cmd.Parameters.AddWithValue("@Id", todoList.Rows[toDoListView.CurrentCell.RowIndex]["id"]);
                    cmd.ExecuteNonQuery();  // Menjalankan query untuk menghapus data
                }
            }

            LoadData();  // Memuat ulang data setelah menghapus
        }
    }
}
