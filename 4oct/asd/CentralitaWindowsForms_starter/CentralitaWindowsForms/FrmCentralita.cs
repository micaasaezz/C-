using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita.V2;

namespace CentralitaWindowsForms
{
    public partial class FrmCentralita : Form
    {
        public Centralita.V2.Centralita centralita;

        public FrmCentralita()
        {
            InitializeComponent();
            this.centralita = new Centralita.V2.Centralita("Telefilgo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLocal frmLocal = new FrmLocal();
            

            if (frmLocal.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //this.centralita.AgregarLlamadas(frmLocal.Llamadas);

                this.centralita.Llamadas += frmLocal.Llamadas;

                
            }
        }
        private void Mostrar()
        {
            this.lstVisor.Items.Clear();
            foreach (Llamada i in this.centralita.Llamadas)
            {
                this.lstVisor.Items.Add(i.ToString());
            }
        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProvincial frmProvincial;
            frmProvincial = new FrmProvincial();
            frmProvincial.ShowDialog();

            if (frmProvincial.DialogResult == DialogResult.OK)
            {
                //this.centralita.AgregarLlamadas(frmProvincial.Llamadas);

                this.lstVisor.Items.Clear();
                foreach (Llamada i in this.centralita.Llamadas)
                {
                    this.lstVisor.Items.Add(i);
                }

            }
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
