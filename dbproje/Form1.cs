namespace dbproje
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbprojeContext _db = new dbprojeContext(); // veritabaný hakkýnda her þeyi bilen nesne.

            try // Hatakaydý için try catch yazdýk.
            {
                Araba araba = new Araba() { MarkaAdý = txtMarkaAdý.Text, KasaTipi = txtKasaTipi.Text, VitesTipi = txtVitesTipi.Text, ModelYýlý = Convert.ToInt32(txtModelYýlý.Text) };
                _db.Add(araba);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                metodlarým.HataKaydý(ex);
                throw;
            }



            List<Araba> arabalistesi = _db.Arabalar.ToList();
            dataGridView1.DataSource = arabalistesi;
            dataGridView1.Refresh();
        }

        private void Lstbtn_Click(object sender, EventArgs e)
        {
            dbprojeContext _db = new dbprojeContext();
            List<Araba> arabalistesi = _db.Arabalar.ToList();
            dataGridView1.DataSource = arabalistesi; // veritabanýyla  datagridviewi birbirine baðlar.
            dataGridView1.Refresh();
        }

        private void slbtn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            dbprojeContext _db = new dbprojeContext();
            var seçiliaraba = _db.Arabalar.FirstOrDefault(a => a.ArabaID == ID);
            if (seçiliaraba != null)
            {
                _db.Remove(seçiliaraba);
                _db.SaveChanges();
                List<Araba> arabalistesi = _db.Arabalar.ToList();
                dataGridView1.DataSource = arabalistesi; // veritabanýyla  datagridviewi birbirine baðlar.
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Böyle bir araç bulunamadý.");
            }
            //entity,sqlserver,tools indirdik. PAcket manager kýsmýndan add-migration bir ve update-database yaptýk. eskisini silmek için drop-database çýkan ekrana a.
        }
    }
}
