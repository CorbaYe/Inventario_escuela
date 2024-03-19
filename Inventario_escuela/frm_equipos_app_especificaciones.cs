using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_escuela
{
    public partial class frm_equipos_app_especificaciones : Form
    {
        public frm_equipos_app_especificaciones()
        {
            InitializeComponent();
        }
        
        private void frm_equipos_app_especificaciones_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txt_espeficicaciones.Focus();
        }
        public bool sw = true;
        public bool getEstado
        {
            get { return sw; }
            set { sw = value; }
        }
        public string getEspeficaciones
        {
           get { return txt_espeficicaciones.Text; }
           set { txt_espeficicaciones.Text = value; }
        }
        public string getAplicaciones
        {
            get { return txt_aplicaciones.Text; }
            set { txt_aplicaciones.Text = value; }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            getEstado = false;
            txt_aplicaciones.Text = string.Empty;
            txt_espeficicaciones.Text = string.Empty;
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_espeficicaciones.Text != "")
            {
                this.Close();
            }
        }


    }
}
