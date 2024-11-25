using SegundoParcialPrestamos.Entidades;
using SegundoParcialPrestamos.Windows.Helpers;

namespace SegundoParcialPrestamos.Windows
{
    public partial class frmPrestamoAE : Form
    {
        private Prestamo prestamo;
        private TipoPrestamo tipo;

        public frmPrestamoAE()
        {
            InitializeComponent();
        }

        internal Prestamo GetPrestamo()
        {
            return prestamo;
        }

        private void rbtDolares_CheckedChanged(object sender, EventArgs e)
        {
            tipo = TipoPrestamo.Dolares;
            plazosTasas = PrestamoDolares.TasasPorPlazo;
            cboPlazos.SelectedIndex = 0;
            MostrarTasaInteres();
        }

        private void rbtPesos_CheckedChanged(object sender, EventArgs e)
        {
            tipo = TipoPrestamo.Pesos;
            plazosTasas = PrestamoPesos.TasasPorPlazo;
            cboPlazos.SelectedIndex = 0;
            MostrarTasaInteres();


        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
