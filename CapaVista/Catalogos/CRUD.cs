using CapaControlador.Catalogos;
using CapaDatos.CatPersona;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using CapaDatos.Enumerations;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class CRUD : Form
    {
        Mensajes mensajes = new Mensajes();

        public CRUD()
        {
            InitializeComponent();
        }

        #region Eventos

        #endregion

        #region Metodos

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtFolio.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtPaterno.Text = string.Empty;
            this.txtMaterno.Text = string.Empty;
            this.txtCalle.Text = string.Empty;
            this.txtCasa.Text = string.Empty;
            this.txtColonia.Text = string.Empty;
        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = PersonaController.Show(CapaDatos.Program.ConfigViewModel);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = PersonaController.SearchName(txtBuscar.Text.Trim());
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void Binding()
        {
            CapaDatos.Program.ConfigViewModel = new CapaDatos.CatPersona.Persona();
            txtFolio.DataBindings.Add(new Binding("Text", CapaDatos.Program.ConfigViewModel, "ID", true, DataSourceUpdateMode.OnPropertyChanged));
            txtNombre.DataBindings.Add(new Binding("Text", CapaDatos.Program.ConfigViewModel, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged));
            txtPaterno.DataBindings.Add(new Binding("Text", CapaDatos.Program.ConfigViewModel, "Paterno", true, DataSourceUpdateMode.OnPropertyChanged));
            txtMaterno.DataBindings.Add(new Binding("Text", CapaDatos.Program.ConfigViewModel, "Materno", true, DataSourceUpdateMode.OnPropertyChanged));
            txtCalle.DataBindings.Add(new Binding("Text", CapaDatos.Program.ConfigViewModel, "Calle", true, DataSourceUpdateMode.OnPropertyChanged));
            txtCasa.DataBindings.Add(new Binding("Text", CapaDatos.Program.ConfigViewModel, "Numero", true, DataSourceUpdateMode.OnPropertyChanged));
            txtColonia.DataBindings.Add(new Binding("Text", CapaDatos.Program.ConfigViewModel, "Colonia", true, DataSourceUpdateMode.OnPropertyChanged));
            txtBuscar.DataBindings.Add(new Binding("Text", CapaDatos.Program.ConfigViewModel, "Textobuscar", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        #endregion
        private void CRUD_Load(object sender, EventArgs e)
        {
            this.Binding();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            CapaDatos.Program.ConfigViewModel.Clear();
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool rpta = false;

                if (CapaDatos.Program.ConfigViewModel.isValid())
                {
                    MessageBox.Show(CapaDatos.Program.ConfigViewModel.Error, mensajes.Formulario);
                }
                else
                {
                    rpta = PersonaController.Save(CapaDatos.Program.ConfigViewModel);

                    switch (rpta)
                    {
                        case true:
                            MessageBox.Show(mensajes.Ok, mensajes.Dp);
                            break;
                        case false:
                            MessageBox.Show(mensajes.Error, mensajes.Dp);
                            break;
                    }

                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtFolio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtPaterno.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["paterno"].Value);
            this.txtMaterno.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["materno"].Value);
            this.txtCalle.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["calle"].Value);
            this.txtCasa.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["numero_casa"].Value);
            this.txtColonia.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["colonia"].Value);
            this.tabControl1.SelectedIndex = 0;
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtPaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtMaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtCalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtCasa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtColonia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedIndex)
            {
                case 1:
                    Mostrar();
                    break;
            }

        }
    }
}