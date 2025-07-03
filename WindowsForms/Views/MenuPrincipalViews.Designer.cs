namespace WindowsForms
{
    partial class MenuPrincipalViews
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            SubMenuAppClima = new FontAwesome.Sharp.IconMenuItem();
            SubMenuTareas = new FontAwesome.Sharp.IconMenuItem();
            SubMenuFormularioFuentes = new ToolStripMenuItem();
            SubMenuTrajabosEnClase = new FontAwesome.Sharp.IconMenuItem();
            SubMenuFormPeliculasApi = new FontAwesome.Sharp.IconMenuItem();
            SubMenuFormPeliculasADO = new FontAwesome.Sharp.IconMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            SubMenuSalirDelSistema = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SubMenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            SubMenuPeliculasEF = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1024, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SubMenuAppClima, SubMenuTareas, SubMenuTrajabosEnClase });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(100, 24);
            iconMenuItem1.Text = "Principal";
            // 
            // SubMenuAppClima
            // 
            SubMenuAppClima.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuAppClima.IconColor = Color.Black;
            SubMenuAppClima.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuAppClima.Name = "SubMenuAppClima";
            SubMenuAppClima.Size = new Size(224, 26);
            SubMenuAppClima.Text = "App Clima";
            SubMenuAppClima.Click += SubMenuAppClima_Click;
            // 
            // SubMenuTareas
            // 
            SubMenuTareas.DropDownItems.AddRange(new ToolStripItem[] { SubMenuFormularioFuentes });
            SubMenuTareas.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuTareas.IconColor = Color.Black;
            SubMenuTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuTareas.Name = "SubMenuTareas";
            SubMenuTareas.Size = new Size(224, 26);
            SubMenuTareas.Text = "Tareas";
            // 
            // SubMenuFormularioFuentes
            // 
            SubMenuFormularioFuentes.Name = "SubMenuFormularioFuentes";
            SubMenuFormularioFuentes.Size = new Size(218, 26);
            SubMenuFormularioFuentes.Text = "Formulario Fuentes";
            SubMenuFormularioFuentes.Click += SubMenuFormularioFuentes_Click;
            // 
            // SubMenuTrajabosEnClase
            // 
            SubMenuTrajabosEnClase.DropDownItems.AddRange(new ToolStripItem[] { SubMenuFormPeliculasApi, SubMenuFormPeliculasADO, SubMenuPeliculasEF });
            SubMenuTrajabosEnClase.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuTrajabosEnClase.IconColor = Color.Black;
            SubMenuTrajabosEnClase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuTrajabosEnClase.Name = "SubMenuTrajabosEnClase";
            SubMenuTrajabosEnClase.Size = new Size(224, 26);
            SubMenuTrajabosEnClase.Text = "Trabajos en clase";
            // 
            // SubMenuFormPeliculasApi
            // 
            SubMenuFormPeliculasApi.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuFormPeliculasApi.IconColor = Color.Black;
            SubMenuFormPeliculasApi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuFormPeliculasApi.Name = "SubMenuFormPeliculasApi";
            SubMenuFormPeliculasApi.Size = new Size(352, 26);
            SubMenuFormPeliculasApi.Text = "Formulario Películas (Api)";
            SubMenuFormPeliculasApi.Click += SubMenuFormPeliculasApi_Click;
            // 
            // SubMenuFormPeliculasADO
            // 
            SubMenuFormPeliculasADO.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuFormPeliculasADO.IconColor = Color.Black;
            SubMenuFormPeliculasADO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuFormPeliculasADO.Name = "SubMenuFormPeliculasADO";
            SubMenuFormPeliculasADO.Size = new Size(352, 26);
            SubMenuFormPeliculasADO.Text = "Formulario Películas (ADO Net)";
            SubMenuFormPeliculasADO.Click += SubMenuFormPeliculasADO_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SubMenuSalirDelSistema, toolStripSeparator1, SubMenuAcercaDe });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // SubMenuSalirDelSistema
            // 
            SubMenuSalirDelSistema.Name = "SubMenuSalirDelSistema";
            SubMenuSalirDelSistema.Size = new Size(200, 26);
            SubMenuSalirDelSistema.Text = "Salir del sistema";
            SubMenuSalirDelSistema.Click += SubMenuSalirDelSistema_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(197, 6);
            // 
            // SubMenuAcercaDe
            // 
            SubMenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuAcercaDe.IconColor = Color.Black;
            SubMenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuAcercaDe.Name = "SubMenuAcercaDe";
            SubMenuAcercaDe.Size = new Size(200, 26);
            SubMenuAcercaDe.Text = "Acerca de...";
            // 
            // SubMenuPeliculasEF
            // 
            SubMenuPeliculasEF.Name = "SubMenuPeliculasEF";
            SubMenuPeliculasEF.Size = new Size(352, 26);
            SubMenuPeliculasEF.Text = "Formulario Películas (Entity Framework)";
            SubMenuPeliculasEF.Click += SubMenuPeliculasEF_Click;
            // 
            // MenuPrincipalViews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 539);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalViews";
            Text = "Pruebas varias en Programación | - 2025";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem SubMenuSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem SubMenuAppClima;
        private FontAwesome.Sharp.IconMenuItem SubMenuTareas;
        private ToolStripMenuItem SubMenuFormularioFuentes;
        private ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem SubMenuAcercaDe;
        private FontAwesome.Sharp.IconMenuItem SubMenuTrajabosEnClase;
        private FontAwesome.Sharp.IconMenuItem SubMenuFormPeliculasApi;
        private FontAwesome.Sharp.IconMenuItem SubMenuFormPeliculasADO;
        private ToolStripMenuItem SubMenuPeliculasEF;
    }
}
