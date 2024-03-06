using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlador;

namespace Inventario_escuela
{
    public partial class frm_principal : Form
    {
        //Declaración de variables para mover el formulario sin bordes
        private bool moviendoFormulario;
        private Point posicionActualPuntero;

        public frm_principal()
        {
            InitializeComponent();
            cmb_estado_sala.SelectedIndex = 0;
            cmb_tipo.SelectedIndex = 0;
            cmb_estado_equipo.SelectedIndex = 0;
            cmb_estado_sala.SelectedIndex = 0;
            lbl_fecha.ForeColor = Color.White;
            tm_fecha.Tick += tm_fecha_Tick;

        }
        private void tm_fecha_Tick(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual del sistema
            DateTime ahora = DateTime.Now;
            // Mostrar la fecha y hora en el label con el formato deseado
            lbl_fecha.Text = ahora.ToString("dd/MM/yyyy hh:mm:ss");
        }

        //Registrar equipos
        private void ptb_registrar_MouseEnter(object sender, EventArgs e)
        {
            ptb_registrar.BackColor = Color.FromArgb(104,125,155);
            btn_registrar.BackColor = Color.FromArgb(104, 125, 155);

        }
        private void ptb_registrar_MouseLeave(object sender, EventArgs e)
        {
            ptb_registrar.BackColor = Color.FromArgb(116, 140, 173);
            btn_registrar.BackColor = Color.FromArgb(116, 140, 173);
        }

        private void btn_registrar_MouseEnter(object sender, EventArgs e)
        {
            ptb_registrar.BackColor = Color.FromArgb(104, 125, 155);
            btn_registrar.BackColor = Color.FromArgb(104, 125, 155);
        }

        private void btn_registrar_MouseLeave(object sender, EventArgs e)
        {
            ptb_registrar.BackColor = Color.FromArgb(116, 140, 173);
            btn_registrar.BackColor = Color.FromArgb(116, 140, 173);
        }


        //Registrar salas

        private void ptb_salas_MouseEnter(object sender, EventArgs e)
        {
            ptb_salas.BackColor = Color.FromArgb(104, 125, 155);
            btn_salas.BackColor = Color.FromArgb(104, 125, 155);
        }

        private void ptb_salas_MouseLeave(object sender, EventArgs e)
        {
            ptb_salas.BackColor = Color.FromArgb(116, 140, 173);
            btn_salas.BackColor = Color.FromArgb(116, 140, 173);
        }

        private void btn_salas_MouseEnter(object sender, EventArgs e)
        {
            ptb_salas.BackColor = Color.FromArgb(104, 125, 155);
            btn_salas.BackColor = Color.FromArgb(104, 125, 155);
        }

        private void btn_salas_MouseLeave(object sender, EventArgs e)
        {
            ptb_salas.BackColor = Color.FromArgb(116, 140, 173);
            btn_salas.BackColor = Color.FromArgb(116, 140, 173);
        }

        //Consultar
        private void btn_buscar_MouseEnter(object sender, EventArgs e)
        {
            ptb_buscar.BackColor = Color.FromArgb(104, 125, 155);
            btn_buscar.BackColor = Color.FromArgb(104, 125, 155);
        }

        private void btn_buscar_MouseLeave(object sender, EventArgs e)
        {
            ptb_buscar.BackColor = Color.FromArgb(116, 140, 173);
            btn_buscar.BackColor = Color.FromArgb(116, 140, 173);
        }

        private void ptb_buscar_MouseEnter(object sender, EventArgs e)
        {
            ptb_buscar.BackColor = Color.FromArgb(104, 125, 155);
            btn_buscar.BackColor = Color.FromArgb(104, 125, 155);
        }

        private void ptb_buscar_MouseLeave(object sender, EventArgs e)
        {
            ptb_buscar.BackColor = Color.FromArgb(116, 140, 173);
            btn_buscar.BackColor = Color.FromArgb(116, 140, 173);
        }

        private void mostrar_sala(String panel)
        {
            if (panel == "Modulo equipo")
            {
                if (pnl_equipos.Visible)
                {
                    pnl_equipos.Visible = false;
                    pnl_salas.Visible = false;
                }
                else
                {
                    pnl_equipos.Visible = true;
                    pnl_salas.Visible = false;
                }
            }else if(panel == "Modulo sala"){
                if (pnl_salas.Visible)
                {
                    pnl_equipos.Visible = false;
                    pnl_salas.Visible = false;
                }
                else
                {
                    pnl_equipos.Visible = false;
                    pnl_salas.Visible = true;
                }
            }

            ///

            pnl_salas.Location = new Point(198, 95);
            pnl_salas.Size = new Size(809, 558);
            pnl_equipos.Location = new Point(198, 95);
            pnl_equipos.Size = new Size(809, 558);

        }

        private void btn_salas_Click(object sender, EventArgs e)
        {
            mostrar_sala("Modulo sala");
        }

        private void lbl_cerrar_MouseEnter(object sender, EventArgs e)
        {
            lbl_cerrar.ForeColor = Color.Red;

        }

        private void lbl_cerrar_MouseLeave(object sender, EventArgs e)
        {
            lbl_cerrar.ForeColor = Color.Black;
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            mostrar_sala("Modulo equipo");
        }

        //Mover formulario
        private void pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moviendoFormulario = true;
                posicionActualPuntero = new Point(e.X, e.Y);
            }
            else
            {
                moviendoFormulario = false;
            }
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendoFormulario)
            {
                Point nuevoPunto;

                nuevoPunto = PointToScreen(new Point(e.X, e.Y));
                nuevoPunto.Offset(-posicionActualPuntero.X, -posicionActualPuntero.Y);

                Location = nuevoPunto;
            }
        }

        private void pnl_titulo_MouseUp(object sender, MouseEventArgs e)
        {
            moviendoFormulario = false;
        }
        //Fin mover formulario
        private void fnt_registrar(String id, String nombre, String estado)
        {
            cls_salas obj_registrar = new cls_salas();
            obj_registrar.fnt_registrar(id,nombre,estado);
        }
        private void btn_guardar_sala_Click(object sender, EventArgs e)
        {
            fnt_registrar(txt_id.Text, txt_nombre_sala.Text, Convert.ToString(cmb_estado_sala.SelectedIndex + 1));
        }
        private void btn_consultar_sala_Click(object sender, EventArgs e)
        {
            cls_salas objConsultar = new cls_salas();
            objConsultar.fnt_consultar(txt_id.Text);
            txt_nombre_sala.Text = objConsultar.getNombre();
            txt_cantidad_equipos.Text = Convert.ToString(objConsultar.getCantidad());
            cmb_estado_sala.SelectedIndex = Convert.ToInt32(objConsultar.getEstado()) - 1;
        }
    }
}
