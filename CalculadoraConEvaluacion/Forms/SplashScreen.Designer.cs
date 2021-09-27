
namespace CalculadoraConEvaluacion
{
    partial class SplashScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TitleName_Label = new System.Windows.Forms.Label();
            this.ProgressIndicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.TargetControl = this;
            // 
            // TitleName_Label
            // 
            this.TitleName_Label.Font = new System.Drawing.Font("Ubuntu", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleName_Label.Location = new System.Drawing.Point(2, 133);
            this.TitleName_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleName_Label.Name = "TitleName_Label";
            this.TitleName_Label.Size = new System.Drawing.Size(351, 42);
            this.TitleName_Label.TabIndex = 0;
            this.TitleName_Label.Text = "Calculadora";
            this.TitleName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressIndicator
            // 
            this.ProgressIndicator.AnimationSpeed = 85;
            this.ProgressIndicator.AutoStart = true;
            this.ProgressIndicator.CircleSize = 1F;
            this.ProgressIndicator.Location = new System.Drawing.Point(132, 215);
            this.ProgressIndicator.Name = "ProgressIndicator";
            this.ProgressIndicator.Size = new System.Drawing.Size(90, 90);
            this.ProgressIndicator.TabIndex = 1;
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoRoundedCorners = true;
            this.ProgressBar.BorderRadius = 4;
            this.ProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ProgressBar.Location = new System.Drawing.Point(-3, 471);
            this.ProgressBar.Maximum = 200;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.DarkGray;
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBar.ShadowDecoration.Parent = this.ProgressBar;
            this.ProgressBar.Size = new System.Drawing.Size(356, 10);
            this.ProgressBar.TabIndex = 2;
            this.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Enabled = true;
            this.timerProgressBar.Interval = 1;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(356, 476);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ProgressIndicator);
            this.Controls.Add(this.TitleName_Label);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2ProgressIndicator ProgressIndicator;
        private System.Windows.Forms.Label TitleName_Label;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}

