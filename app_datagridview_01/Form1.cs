using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_datagridview_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
          

           if (txt_nombre.Text == "" || txt_Correo.Text == "")
            {
                MessageBox.Show("Debe rellenar los campos para guardarlos","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_nombre.Focus();
            }
            else
            {
                 dgv_datos.Rows.Add(txt_nombre.Text,txt_Correo.Text);
            txt_nombre.Clear();
            txt_Correo.Clear();
            txt_nombre.Focus();
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            int fila;
            fila = dgv_datos.CurrentRow.Index;
            DialogResult respuesta;

          
          
                respuesta = MessageBox.Show("Desea eliminar este registro?", "Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                dgv_datos.Rows.RemoveAt(fila);
                MessageBox.Show("Registro eliminado.", "Existo");
            }
           
            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_Correo.Clear();
            dgv_datos.Rows.Clear();
        }
    }
}
