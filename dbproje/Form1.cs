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
            dbprojeContext _db = new dbprojeContext(); // veritaban� hakk�nda her �eyi bilen nesne.

            try // Hatakayd� i�in try catch yazd�k.
            {
                Araba araba = new Araba() { MarkaAd� = txtMarkaAd�.Text, KasaTipi = txtKasaTipi.Text, VitesTipi = txtVitesTipi.Text, ModelY�l� = Convert.ToInt32(txtModelY�l�.Text) };
                _db.Add(araba);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                metodlar�m.HataKayd�(ex);
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
            dataGridView1.DataSource = arabalistesi; // veritaban�yla  datagridviewi birbirine ba�lar.
            dataGridView1.Refresh();
        }

        private void slbtn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            dbprojeContext _db = new dbprojeContext();
            var se�iliaraba = _db.Arabalar.FirstOrDefault(a => a.ArabaID == ID);
            if (se�iliaraba != null)
            {
                _db.Remove(se�iliaraba);
                _db.SaveChanges();
                List<Araba> arabalistesi = _db.Arabalar.ToList();
                dataGridView1.DataSource = arabalistesi; // veritaban�yla  datagridviewi birbirine ba�lar.
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("B�yle bir ara� bulunamad�.");
            }
            //entity,sqlserver,tools indirdik. PAcket manager k�sm�ndan add-migration bir ve update-database yapt�k. eskisini silmek i�in drop-database ��kan ekrana a.
        }
    }
}
