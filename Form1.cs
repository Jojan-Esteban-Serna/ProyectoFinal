using ProyectoFinal.logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmArtistas : Form
    {
        public frmArtistas()
        {
            InitializeComponent();
        }

        private AsociacionArtistas asoArtistas = new AsociacionArtistas();
        private Artista artista = new Artista();
        private Vincula vincula = new Vincula();

        private void tpRegistroVinculacion_Enter(object sender, EventArgs e)
        {
            DataSet resAsociacion = new DataSet();
            DataSet resArtista = new DataSet();

            resAsociacion = asoArtistas.consultarAsociacionesArtistas();
            resArtista = artista.consultarArtistas();
            dgvSeleccionAsociacion.DataSource = resAsociacion;
            dgvSeleccionAsociacion.DataMember = "ResultadoDatos";

            dgvSeleccionArtista.DataSource = resArtista;
            dgvSeleccionArtista.DataMember = "ResultadoDatos";
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void frmArtistas_Load(object sender, EventArgs e)
        {
            cbxTipoArte.SelectedIndex = 0;
        }

        private void btnRegistrarAsociacion_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int asoArtNit = 0;
            string asoArtNombre = "";
            string asoArtModalidad = "";

            // verificar espacio vacio
            if (txtNit.Text.Length > 0)
            {
                try
                {
                    asoArtNit = int.Parse(txtNit.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el NIT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            // texto seleccionado
            if (rbConAnimoDeLucro.Checked)
            {
                asoArtModalidad = rbConAnimoDeLucro.Text;
            }
            else
            {
                asoArtModalidad = rbSinAnimoDeLucro.Text;
            }

            // verificar espacio vacio

            if (txtNombre.Text.Length > 0)
            {
                asoArtNombre = txtNombre.Text;
            }
            else
            {
                MessageBox.Show("Ingrese el Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //realizar el registro
            try
            {
                resultado = asoArtistas.registrarAsociacionArtistas(asoArtNit, asoArtNombre, asoArtModalidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (resultado > 0)
            {
                MessageBox.Show("Asociacion registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asociacion NO registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarArtista_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int artCodigo = 0;
            string artTipoArte = "";
            string artNombreArtistico = "";
            int artAnioNacimiento;

            //verificar espacio vacio
            if (txtCodigo.Text.Length > 0)
            {
                try
                {
                    artCodigo = int.Parse(txtCodigo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Codigo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            //obtener item seleccionado
            artTipoArte = cbxTipoArte.SelectedItem.ToString();
            //verificar espacio vacio
            if (txtNombreArtistico.Text.Length > 0)
            {
                artNombreArtistico = txtNombreArtistico.Text;
            }
            else
            {
                MessageBox.Show("Ingrese el Nombre Artistico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //parsear el año
            artAnioNacimiento = int.Parse(dtpAnioNacimiento.Text);

            try
            {
                resultado = artista.registrarArtista(artCodigo, artTipoArte, artNombreArtistico, artAnioNacimiento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (resultado > 0)
            {
                MessageBox.Show("Artista registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Artista NO registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarVinculacion_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int vinId = 0;
            int asoArtNit;
            int artCodigo;
            string vinfechaInicio = "";
            string vinFechaFin = "";
            // Verificar espacio vacion
            if (txtId.Text.Length > 0)
            {
                try
                {
                    vinId = int.Parse(txtId.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //verificar que se selecciona un valor de la primera tabla
            if (!lblNitAsociacionSeleccionada.Text.Equals("----"))
            {
                asoArtNit = int.Parse(lblNitAsociacionSeleccionada.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un campo de la tabla de Asociaciones Artisticas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //verificar que se selecciona un valor de la segunda tabla
            if (!lblCodigoArtistaSeleccionado.Text.Equals("----"))
            {
                artCodigo = int.Parse(lblCodigoArtistaSeleccionado.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un campo de la tabla de Artistas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            vinfechaInicio = dtpFechaInicio.Value.ToString("dd/MM/yyyy");
            if (chkFechaFin.Checked)
            {
                vinFechaFin = dtpFechaFin.Value.ToString("dd/MM/yyyy");
            }
            try
            {
                resultado = vincula.registrarVinculacion(vinId, asoArtNit, artCodigo, vinfechaInicio, vinFechaFin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (resultado > 0)
            {
                MessageBox.Show("Vinculacion registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vinculacion NO registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNumPintores_Click(object sender, EventArgs e)
        {
            lblNumeroPintores.Text = "Numero de pintores: " + artista.consultarCantidadPor("artTipoArte", "'pintura'");
        }

        private void btnConsultaPorFechaVinculacion1_Click(object sender, EventArgs e)
        {
            DataSet resVinculacion = new DataSet();
            try
            {
                resVinculacion = vincula.consultarVinculacionesPorFechaInicio(dtpConsFechaInicioVinculacion.Value.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvSeleccionVinculacion.DataSource = resVinculacion;
            dgvSeleccionVinculacion.DataMember = "ResultadoDatos";
        }

        private void dgvSeleccionAsociacion_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dgvSeleccionAsociacion.Rows[e.RowIndex];
                lblNitAsociacionSeleccionada.Text = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void dgvSeleccionArtista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dgvSeleccionArtista.Rows[e.RowIndex];
                lblCodigoArtistaSeleccionado.Text = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void tpRegistroVinculacion_Leave(object sender, EventArgs e)
        {
            lblNitAsociacionSeleccionada.Text = "----";
            lblCodigoArtistaSeleccionado.Text = "----";
        }
    }
}