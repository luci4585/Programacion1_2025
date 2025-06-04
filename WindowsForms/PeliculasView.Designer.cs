namespace WindowsForms
{
    partial class PeliculasView
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
            GridPeliculas = new DataGridView();
            AgregarButton = new Button();
            ModificarButton = new Button();
            SalirButton = new Button();
            BtnEliminar = new Button();
            FilmPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).BeginInit();
            SuspendLayout();
            // 
            // GridPeliculas
            // 
            GridPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GridPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPeliculas.Location = new Point(35, 12);
            GridPeliculas.MultiSelect = false;
            GridPeliculas.Name = "GridPeliculas";
            GridPeliculas.RowHeadersWidth = 51;
            GridPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridPeliculas.Size = new Size(537, 317);
            GridPeliculas.TabIndex = 0;
            GridPeliculas.SelectionChanged += GridPeliculas_SelectionChanged;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(84, 397);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(94, 29);
            AgregarButton.TabIndex = 1;
            AgregarButton.Text = "&Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            ModificarButton.Location = new Point(256, 397);
            ModificarButton.Name = "ModificarButton";
            ModificarButton.Size = new Size(94, 29);
            ModificarButton.TabIndex = 2;
            ModificarButton.Text = "&Modificar";
            ModificarButton.UseVisualStyleBackColor = true;
            // 
            // SalirButton
            // 
            SalirButton.Location = new Point(899, 417);
            SalirButton.Name = "SalirButton";
            SalirButton.Size = new Size(94, 29);
            SalirButton.TabIndex = 3;
            SalirButton.Text = "Salir";
            SalirButton.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(434, 397);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(94, 29);
            BtnEliminar.TabIndex = 4;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FilmPicture
            // 
            FilmPicture.Location = new Point(634, 12);
            FilmPicture.Name = "FilmPicture";
            FilmPicture.Size = new Size(346, 317);
            FilmPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            FilmPicture.TabIndex = 5;
            FilmPicture.TabStop = false;
            // 
            // PeliculasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 487);
            Controls.Add(FilmPicture);
            Controls.Add(BtnEliminar);
            Controls.Add(SalirButton);
            Controls.Add(ModificarButton);
            Controls.Add(AgregarButton);
            Controls.Add(GridPeliculas);
            Name = "PeliculasView";
            Text = "PeliculasView";
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridPeliculas;
        private Button AgregarButton;
        private Button ModificarButton;
        private Button SalirButton;
        private Button BtnEliminar;
        private PictureBox FilmPicture;
    }
}