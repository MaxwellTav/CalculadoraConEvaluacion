using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraConEvaluacion.Forms
{
    public partial class MainForm : Form
    {
        #region Inicializador
        public MainForm() { InitializeComponent(); }
        #endregion

        #region Variables
        Double
            Num1 = 0,
            Num2 = 0,
            Result = 0;

        bool
            st1Num = true,
            boolErase = false;

        CalculateType calculate = new CalculateType();
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateButtons();
        }

        private void CreateButtons()
        {
            int _i = 9;
            for (int i = 20; i > 0; i--)
            {
                //Diseño
                Guna.UI2.WinForms.Guna2Button Button = new Guna.UI2.WinForms.Guna2Button();
                Button.Size = new Size(60, 60);
                Button.Animated = true;
                Button.Click += new EventHandler(ClickButtonEvent);
                Button.Font = fontDialog.Font;

                switch (i)
                {
                    case 0:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 1:
                        Button.Text = "+";
                        break;

                    case 2:
                        Button.Text = "=";
                        break;

                    case 3:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 4:
                        Button.Text = "CE";
                        break;

                    case 5:
                        Button.Text = "-";
                        break;

                    case 6:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 7:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 8:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 9:
                        Button.Text = "x";
                        break;

                    case 10:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 11:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 12:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 13:
                        Button.Text = "/";
                        break;

                    case 14:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 15:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 16:
                        Button.Text = _i.ToString();
                        _i--;
                        break;

                    case 17:
                        Button.Text = String.Empty;
                        break;

                    case 18:
                        Button.Text = string.Empty;
                        break;

                    case 19:
                        break;
                }

                LayoutPanel.Controls.Add(Button);

                if (Button.Text == string.Empty)
                    Button.Enabled = false;
            }
        }

        private void ClickButtonEvent(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button Button = (Guna.UI2.WinForms.Guna2Button)sender;

            switch (Button.Text)
            {
                case "CE":
                    Number_Panel.Text = String.Empty;
                    EventoIgualdad();
                    break;

                case "+":
                    EventoSumar();
                    break;

                case "-":
                    EventoRestar();
                    break;

                case "x":
                    EventoMultiplicar();
                    break;

                case "/":
                    EventoDividir();
                    break;

                case "=":
                    EventoIgualdad();
                    break;

                default:
                    if (boolErase)
                        Number_Panel.Text = String.Empty;

                    Number_Panel.Text += Button.Text;
                    boolErase = false;
                    break;
            }
        }

        private void EventoSumar()
        {
            calculate = CalculateType.Sumar;
            Number_Panel.Text =
            EventoCalculo(Num1, Num2, CalculateType.Sumar).ToString();
        }

        private void EventoRestar()
        {
            calculate = CalculateType.Restar;
            Number_Panel.Text =
            EventoCalculo(Num1, Num2, CalculateType.Restar).ToString();
        }

        private void EventoMultiplicar()
        {
            calculate = CalculateType.Multiplicar;
            Number_Panel.Text =
            EventoCalculo(Num1, Num2, CalculateType.Multiplicar).ToString();
        }

        private void Erase_Button_Click(object sender, EventArgs e)
        {
            if (Number_Panel.Text.Length > 0)
                Number_Panel.Text = Number_Panel.Text.Remove(Number_Panel.Text.Length - 1);
            else
                Number_Panel.Text = 0.ToString();
        }

        private void Number_Panel_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = (!char.IsNumber(e.KeyChar) || (!char.IsDigit(e.KeyChar))); }

        private void Exti_Button_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "¡Está saliendo de la app!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (question == DialogResult.Yes)
                Application.Exit();
        }

        private void EventoDividir()
        {
            calculate = CalculateType.Dividir;
            Number_Panel.Text =
            EventoCalculo(Num1, Num2, CalculateType.Dividir).ToString();
        }

        private void EventoIgualdad()
        {
            Number_Panel.Text =
            EventoCalculo(Num1, Num2, CalculateType.Equals).ToString();
        }

        private Double EventoCalculo(Double num1, Double num2, CalculateType type)
        {
            try
            {
                switch (type)
                {
                    case CalculateType.Sumar:
                        if (st1Num)
                        {
                            num1 = Double.Parse(Number_Panel.Text);

                            Num1 = num1;
                            st1Num = false;

                            Result = Num1;

                            boolErase = true;
                        }
                        else
                        {
                            num2 = Double.Parse(Number_Panel.Text);

                            Num2 = num2;
                            Result = Num1 + Num2;

                            Num1 = Num2;

                            boolErase = true;
                        }
                        break;

                    case CalculateType.Restar:
                        if (st1Num)
                        {
                            num1 = Double.Parse(Number_Panel.Text);

                            Num1 = num1;
                            st1Num = false;

                            Result = Num1;

                            boolErase = true;
                        }
                        else
                        {
                            num2 = Double.Parse(Number_Panel.Text);

                            Num2 = num2;
                            Result = Num1 - Num2;

                            Num1 = Num2;

                            boolErase = true;
                        }
                        break;

                    case CalculateType.Multiplicar:
                        if (st1Num)
                        {
                            num1 = Double.Parse(Number_Panel.Text);

                            Num1 = num1;
                            st1Num = false;

                            Result = Num1;

                            boolErase = true;
                        }
                        else
                        {
                            num2 = Double.Parse(Number_Panel.Text);

                            Num2 = num2;
                            Result = Num1 * Num2;

                            Num1 = Num2;

                            boolErase = true;
                        }
                        break;

                    case CalculateType.Dividir:
                        if (st1Num)
                        {
                            num1 = Double.Parse(Number_Panel.Text);

                            Num1 = num1;
                            st1Num = false;

                            Result = Num1;

                            boolErase = true;
                        }
                        else
                        {
                            num2 = Double.Parse(Number_Panel.Text);

                            Num2 = num2;
                            Result = Num1 / Num2;

                            Num1 = Num2;

                            boolErase = true;
                        }
                        break;

                    case CalculateType.Equals:
                        Num2 = Double.Parse(Number_Panel.Text);

                        switch (calculate)
                        {
                            case CalculateType.Sumar:
                                Result = Num1 + Num2;
                                break;
                            case CalculateType.Restar:
                                Result = Num1 - Num2;
                                break;
                            case CalculateType.Dividir:
                                Result = Num1 / Num2;
                                break;
                            case CalculateType.Multiplicar:
                                Result = Num1 * Num2;
                                break;
                        }

                        Num1 = 0;
                        Num2 = 0;

                        boolErase = false;
                        break;
                }
                return Result;
            }
            catch { Number_Panel.Text = "Error"; boolErase = true; return 0; }
        }
    }
}

public enum CalculateType
{
    Sumar,
    Restar,
    Multiplicar,
    Dividir,
    Equals
}