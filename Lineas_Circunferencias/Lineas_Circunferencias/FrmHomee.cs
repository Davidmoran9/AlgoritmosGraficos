using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lineas_Circunferencias
{
    public partial class FrmHomee : Form
    {
        public FrmHomee()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void RenderForm(Form form)
        {

            // Ocultar los labels del formulario principal
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == form.GetType())
                {
                    child.BringToFront();
                    return;
                }
            }

            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();
        }
        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);

            if (this.ActiveMdiChild == null)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
        }
        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDDA = frmDDA.GetInstance();
            RenderForm(formDDA);
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formBres = frmBresenham.GetInstance();
            RenderForm(formBres);
        }

        private void discretizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formBres = frmCircunferencia.GetInstance();
            RenderForm(formBres);
        }

        private void rellenoPorInundaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formBres = frmRelleno.GetInstance();
            RenderForm(formBres);
        }

    }
}

