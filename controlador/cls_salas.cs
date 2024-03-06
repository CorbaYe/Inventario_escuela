﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace controlador
{
    public class cls_salas
    {
        private String id_estado;
        private String nombre_estado;
        private int cantidad_equipos;
        private String codigo_estado;
        cls_conexion objConectar = new cls_conexion();
        public void fnt_registrar(string id, string nombre, string codigo)
        {
            if (id == "" || nombre == "")
            {
                MessageBox.Show("Debe ingresar la información solicitada", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    objConectar.fnt_conectar();
                    string sql = "insert into tbl_sala(pk_id,nombre,cantidad_equipos,fk_codigo_tbl_estado) " +
                    "Values('" + id + "','" + nombre + "',0,'" + codigo + "')";
                    MySqlCommand comando = new MySqlCommand(sql, objConectar.conex);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Sala registrada con éxito", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConectar.fnt_Desconectar();
                }
                catch { MessageBox.Show("Problemas con el registro de la sala contactar con el administrador", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        public void fnt_consultar(string id)
        {
            if (id == "")
            {
                MessageBox.Show("Debe ingresar el código de la sala", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objConectar.fnt_conectar();
                String sql = "select * from tbl_sala where pk_id ='" + id + "'";
                MySqlCommand comando = new MySqlCommand(sql, objConectar.conex);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    nombre_estado = reader["nombre"].ToString();
                    cantidad_equipos = Convert.ToInt32(reader["cantidad_equipos"].ToString());
                    codigo_estado = reader["fk_codigo_tbl_estado"].ToString();
                }
                else { MessageBox.Show("No se encontraron registros", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        public string getId() { return this.id_estado; }
        public string getNombre() { return this.nombre_estado; }
        public string getEstado() { return this.codigo_estado; }
        public int getCantidad() { return this.cantidad_equipos; }
    }
}
