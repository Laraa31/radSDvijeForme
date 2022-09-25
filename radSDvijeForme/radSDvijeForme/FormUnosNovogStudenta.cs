using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radSDvijeForme
{

    public partial class FormUnosNovogStudenta : Form
    {
        private Student student1;

        
        public FormUnosNovogStudenta()
        {
            InitializeComponent();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            student1 = new Student();

            

            student1.Ime = txtBoxIme.Text;

            student1.Prezime = txtBoxPrezime.Text;

            student1.BrojIndeksa = txtBoxIndeks.Text;

            student1.Smjer = cmbSmjer.SelectedItem.ToString();

            student1.DatumRodjenja =
            dtpDatum.Value;

            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUnosNovogStudenta_Load(object sender, EventArgs e)
        {

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
