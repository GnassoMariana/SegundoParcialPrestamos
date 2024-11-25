using SegundoParcialPrestamos.Datos;
using SegundoParcialPrestamos.Entidades;

namespace SegundoParcialPrestamos.Windows
{
    public partial class frmPrestamos : Form
    {
        EntidadFinanciera entidad;
        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPrestamoAE frm = new frmPrestamoAE();
            DialogResult = frm.ShowDialog();

            Prestamo prestamo = frm.GetPrestamo();

            if( prestamo != null )
            {
               var resultado= entidad.AgregarPrestamo( prestamo );
               if(resultado.resultado)
               {
                    MessageBox.Show($"{resultado.mensaje}", "Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                    MessageBox.Show($"{resultado.mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
        }
    }
}
