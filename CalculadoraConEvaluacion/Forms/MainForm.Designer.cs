
namespace CalculadoraConEvaluacion.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Number_Panel = new Guna.UI2.WinForms.Guna2TextBox();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.Erase_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Exti_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.TargetControl = this;
            // 
            // Number_Panel
            // 
            this.Number_Panel.Animated = true;
            this.Number_Panel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Number_Panel.DefaultText = "";
            this.Number_Panel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Number_Panel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Number_Panel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Number_Panel.DisabledState.Parent = this.Number_Panel;
            this.Number_Panel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Number_Panel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Number_Panel.FocusedState.Parent = this.Number_Panel;
            this.Number_Panel.Font = new System.Drawing.Font("Ubuntu", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Panel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Number_Panel.HoverState.Parent = this.Number_Panel;
            this.Number_Panel.Location = new System.Drawing.Point(0, 33);
            this.Number_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Number_Panel.Name = "Number_Panel";
            this.Number_Panel.PasswordChar = '\0';
            this.Number_Panel.PlaceholderText = "0";
            this.Number_Panel.SelectedText = "";
            this.Number_Panel.ShadowDecoration.Parent = this.Number_Panel;
            this.Number_Panel.Size = new System.Drawing.Size(312, 101);
            this.Number_Panel.TabIndex = 0;
            this.Number_Panel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Panel_KeyPress);
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Location = new System.Drawing.Point(44, 136);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(268, 333);
            this.LayoutPanel.TabIndex = 1;
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            // 
            // Erase_Button
            // 
            this.Erase_Button.CheckedState.Parent = this.Erase_Button;
            this.Erase_Button.CustomImages.Parent = this.Erase_Button;
            this.Erase_Button.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.Erase_Button.ForeColor = System.Drawing.Color.White;
            this.Erase_Button.HoverState.Parent = this.Erase_Button;
            this.Erase_Button.Location = new System.Drawing.Point(312, 33);
            this.Erase_Button.Name = "Erase_Button";
            this.Erase_Button.ShadowDecoration.Parent = this.Erase_Button;
            this.Erase_Button.Size = new System.Drawing.Size(47, 101);
            this.Erase_Button.TabIndex = 2;
            this.Erase_Button.Text = "←";
            this.Erase_Button.Click += new System.EventHandler(this.Erase_Button_Click);
            // 
            // Exti_Button
            // 
            this.Exti_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exti_Button.CheckedState.Parent = this.Exti_Button;
            this.Exti_Button.CustomImages.Parent = this.Exti_Button;
            this.Exti_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exti_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exti_Button.ForeColor = System.Drawing.Color.White;
            this.Exti_Button.HoverState.Parent = this.Exti_Button;
            this.Exti_Button.Location = new System.Drawing.Point(329, 8);
            this.Exti_Button.Name = "Exti_Button";
            this.Exti_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exti_Button.ShadowDecoration.Parent = this.Exti_Button;
            this.Exti_Button.Size = new System.Drawing.Size(15, 15);
            this.Exti_Button.TabIndex = 3;
            this.Exti_Button.Click += new System.EventHandler(this.Exti_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(356, 476);
            this.Controls.Add(this.Exti_Button);
            this.Controls.Add(this.Erase_Button);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.Number_Panel);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2TextBox Number_Panel;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private System.Windows.Forms.FontDialog fontDialog;
        private Guna.UI2.WinForms.Guna2Button Erase_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Exti_Button;
    }
}