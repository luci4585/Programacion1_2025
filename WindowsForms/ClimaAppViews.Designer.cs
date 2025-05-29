namespace WindowsForms
{
    partial class ClimaAppViews
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
            menuStrip1 = new MenuStrip();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            subMenuNosotros = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            subMenuSalirDeLaApp = new FontAwesome.Sharp.IconMenuItem();
            toolStrip1 = new ToolStrip();
            botonNosotrosClick = new FontAwesome.Sharp.IconToolStripButton();
            botonSalirApp = new FontAwesome.Sharp.IconToolStripButton();
            labelTituloApp = new Label();
            BtnObtenerClima = new Button();
            LabelTemperatura = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem3, iconMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(595, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { subMenuNosotros });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(118, 24);
            iconMenuItem3.Text = "Acerca de...";
            // 
            // subMenuNosotros
            // 
            subMenuNosotros.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            subMenuNosotros.IconColor = Color.Black;
            subMenuNosotros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuNosotros.Name = "subMenuNosotros";
            subMenuNosotros.Size = new Size(152, 26);
            subMenuNosotros.Text = "Nosotros";
            subMenuNosotros.Click += subMenuNosotros_Click;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { subMenuSalirDeLaApp });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(72, 24);
            iconMenuItem1.Text = "Salir";
            // 
            // subMenuSalirDeLaApp
            // 
            subMenuSalirDeLaApp.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            subMenuSalirDeLaApp.IconColor = Color.Black;
            subMenuSalirDeLaApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuSalirDeLaApp.Name = "subMenuSalirDeLaApp";
            subMenuSalirDeLaApp.Size = new Size(193, 26);
            subMenuSalirDeLaApp.Text = "Salir de la App.";
            subMenuSalirDeLaApp.Click += subMenuSalirDeLaApp_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botonNosotrosClick, botonSalirApp });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(595, 55);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // botonNosotrosClick
            // 
            botonNosotrosClick.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botonNosotrosClick.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            botonNosotrosClick.IconColor = Color.Black;
            botonNosotrosClick.IconFont = FontAwesome.Sharp.IconFont.Auto;
            botonNosotrosClick.ImageScaling = ToolStripItemImageScaling.None;
            botonNosotrosClick.ImageTransparentColor = Color.Magenta;
            botonNosotrosClick.Name = "botonNosotrosClick";
            botonNosotrosClick.Size = new Size(52, 52);
            botonNosotrosClick.Text = "iconToolStripButton1";
            botonNosotrosClick.Click += botonNosotrosClick_Click;
            // 
            // botonSalirApp
            // 
            botonSalirApp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botonSalirApp.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            botonSalirApp.IconColor = Color.Black;
            botonSalirApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            botonSalirApp.ImageScaling = ToolStripItemImageScaling.None;
            botonSalirApp.ImageTransparentColor = Color.Magenta;
            botonSalirApp.Name = "botonSalirApp";
            botonSalirApp.Size = new Size(52, 52);
            botonSalirApp.Text = "iconToolStripButton2";
            botonSalirApp.Click += botonSalirApp_Click;
            // 
            // labelTituloApp
            // 
            labelTituloApp.AutoSize = true;
            labelTituloApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTituloApp.Location = new Point(123, 457);
            labelTituloApp.Name = "labelTituloApp";
            labelTituloApp.Size = new Size(369, 28);
            labelTituloApp.TabIndex = 2;
            labelTituloApp.Text = "App del Clima - ISP20 - 2do año TSDS";
            // 
            // BtnObtenerClima
            // 
            BtnObtenerClima.Location = new Point(47, 149);
            BtnObtenerClima.Name = "BtnObtenerClima";
            BtnObtenerClima.Size = new Size(154, 35);
            BtnObtenerClima.TabIndex = 3;
            BtnObtenerClima.Text = "Obtener Clima";
            BtnObtenerClima.UseVisualStyleBackColor = true;
            BtnObtenerClima.Click += BtnObtenerClima_Click;
            // 
            // LabelTemperatura
            // 
            LabelTemperatura.AutoSize = true;
            LabelTemperatura.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            LabelTemperatura.Location = new Point(243, 156);
            LabelTemperatura.Name = "LabelTemperatura";
            LabelTemperatura.Size = new Size(139, 28);
            LabelTemperatura.TabIndex = 4;
            LabelTemperatura.Text = "Temperatura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(416, 162);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 5;
            // 
            // ClimaAppViews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 494);
            Controls.Add(label1);
            Controls.Add(LabelTemperatura);
            Controls.Add(BtnObtenerClima);
            Controls.Add(labelTituloApp);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "ClimaAppViews";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App del clima hoy: 2do año 2025 : TSDS";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconToolStripButton botonNosotrosClick;
        private FontAwesome.Sharp.IconToolStripButton botonSalirApp;
        private Label labelTituloApp;
        private FontAwesome.Sharp.IconMenuItem subMenuSalirDeLaApp;
        private FontAwesome.Sharp.IconMenuItem subMenuNosotros;
        private Button BtnObtenerClima;
        private Label LabelTemperatura;
        private Label label1;
    }
}