using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Clase19.Entidades;
namespace Clase20.Formularios
{
    public partial class FrmListado : Form
    {
        private List<Persona> _personas;
        private DataTable _tabla;
        public FrmListado()
        {
            InitializeComponent();
            

        }

        private void FrmListado_Load(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            this._tabla = datos.TraerTablaPersonas();
            this._personas = datos.TraerTodos();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            this.dataGridView1.DataSource = this._personas;
            this.dataGridView1.Show();
        }
        // data source es un origine de datos idependiente.
    }
}
