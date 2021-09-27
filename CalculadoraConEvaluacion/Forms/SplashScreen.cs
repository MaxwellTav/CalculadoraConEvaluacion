using System;
using System.Windows.Forms;

namespace CalculadoraConEvaluacion
{
    public partial class SplashScreen : Form
    {
        #region Variables
        int ChargeInt = 1;
        #endregion

        public SplashScreen() { InitializeComponent(); }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            Visible = false;
            Forms.MainForm mainForm = new Forms.MainForm();

            mainForm.Show();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ProgressBar.Value < ProgressBar.Maximum)
                    ProgressBar.Value += ChargeInt;
                else
                {
                    ProgressBar.Value = ProgressBar.Maximum;
                    Opacity -= ChargeInt;
                    timerProgressBar.Enabled = false;
                    timerProgressBar.Stop();
                }
            }
            catch (Exception error) { MessageBox.Show("No se pudo incrementar la barra de carga\n" + error.Message, error.HResult + " Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
