using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace controlador
{
    public class cls_salas
    {
        private String id;
        private String nombre;
        private int cantidad;
        private String codigo_estado;
        cls_conexion objConectar = new cls_conexion();
        public void fnt_registrar(string id, string nombre, string codigo_estado, string cantidad)
        {
            if (id == "" || nombre == "" || codigo_estado == "Selecionar estado")
            {
                MessageBox.Show("Debe ingresar la información solicitada", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    objConectar.fnt_conectar();
                    string sql = "insert into tbl_sala (pk_id,nombre,cantidad_equipos,fk_codigo_tbl_estado) " +
                        "values ('" + id + "','" + nombre + "',0,'" + codigo_estado + "')";
                    MySqlCommand comando = new MySqlCommand(sql, objConectar.conex);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Sala registrada con éxito", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConectar.fnt_Desconectar();
                }
                catch { MessageBox.Show("Problemas con el registro de la sala contactar con el administrador", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
