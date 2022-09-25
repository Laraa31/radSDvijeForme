using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace radSDvijeForme
{
    public partial class FormStudenti : Form
    {
        public FormStudenti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();
            DialogResult rez= frm.ShowDialog();

            if (rez == System.Windows.Forms.DialogResult.OK)
            {
                lbStudenti.Items.Add(frm.student1.ToString());
            }
        }

        private void btnObrisiSve_Click(object sender, EventArgs e)
        {
            lbStudenti.Items.Clear();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (!(lbStudenti.SelectedIndex < 0))
            {
                lbStudenti.Items.RemoveAt(lbStudenti.SelectedIndex);
            }
        }
    }
}
