namespace WindowsForms.Views
{
    partial class FuentesView
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
            labelVistaPrevia = new Label();
            TxtTexto = new TextBox();
            label1 = new Label();
            BtnAplicar = new Button();
            numericSize = new NumericUpDown();
            label2 = new Label();
            radioIzquierda = new RadioButton();
            radioCentrado = new RadioButton();
            radioDerecha = new RadioButton();
            comboFuentes = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericSize).BeginInit();
            SuspendLayout();
            // 
            // labelVistaPrevia
            // 
            labelVistaPrevia.Location = new Point(3, 295);
            labelVistaPrevia.Name = "labelVistaPrevia";
            labelVistaPrevia.Size = new Size(785, 146);
            labelVistaPrevia.TabIndex = 0;
            // 
            // TxtTexto
            // 
            TxtTexto.Location = new Point(153, 43);
            TxtTexto.Name = "TxtTexto";
            TxtTexto.Size = new Size(282, 31);
            TxtTexto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 46);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 2;
            label1.Text = "Texto";
            // 
            // BtnAplicar
            // 
            BtnAplicar.Location = new Point(471, 40);
            BtnAplicar.Name = "BtnAplicar";
            BtnAplicar.Size = new Size(112, 34);
            BtnAplicar.TabIndex = 3;
            BtnAplicar.Text = "Aplicar";
            BtnAplicar.UseVisualStyleBackColor = true;
            BtnAplicar.Click += BtnAplicar_Click;
            // 
            // numericSize
            // 
            numericSize.Location = new Point(161, 107);
            numericSize.Name = "numericSize";
            numericSize.Size = new Size(180, 31);
            numericSize.TabIndex = 4;
            numericSize.Value = new decimal(new int[] { 11, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 113);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "Tamaño:";
            // 
            // radioIzquierda
            // 
            radioIzquierda.AutoSize = true;
            radioIzquierda.Location = new Point(54, 189);
            radioIzquierda.Name = "radioIzquierda";
            radioIzquierda.Size = new Size(110, 29);
            radioIzquierda.TabIndex = 6;
            radioIzquierda.TabStop = true;
            radioIzquierda.Text = "Izquierda";
            radioIzquierda.UseVisualStyleBackColor = true;
            radioIzquierda.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioCentrado
            // 
            radioCentrado.AutoSize = true;
            radioCentrado.Location = new Point(205, 189);
            radioCentrado.Name = "radioCentrado";
            radioCentrado.Size = new Size(110, 29);
            radioCentrado.TabIndex = 7;
            radioCentrado.TabStop = true;
            radioCentrado.Text = "Centrado";
            radioCentrado.UseVisualStyleBackColor = true;
            radioCentrado.CheckedChanged += radioCentrado_CheckedChanged;
            // 
            // radioDerecha
            // 
            radioDerecha.AutoSize = true;
            radioDerecha.Location = new Point(348, 189);
            radioDerecha.Name = "radioDerecha";
            radioDerecha.Size = new Size(101, 29);
            radioDerecha.TabIndex = 8;
            radioDerecha.TabStop = true;
            radioDerecha.Text = "Derecha";
            radioDerecha.UseVisualStyleBackColor = true;
            radioDerecha.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // comboFuentes
            // 
            comboFuentes.FormattingEnabled = true;
            comboFuentes.Items.AddRange(new object[] { "Times New Roman", "Arial", "Montserrat" });
            comboFuentes.Location = new Point(533, 110);
            comboFuentes.Name = "comboFuentes";
            comboFuentes.Size = new Size(226, 33);
            comboFuentes.TabIndex = 9;
            comboFuentes.SelectedIndexChanged += comboFuentes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 113);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 10;
            label3.Text = "Fuente:";
            // 
            // FuentesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboFuentes);
            Controls.Add(radioDerecha);
            Controls.Add(radioCentrado);
            Controls.Add(radioIzquierda);
            Controls.Add(label2);
            Controls.Add(numericSize);
            Controls.Add(BtnAplicar);
            Controls.Add(label1);
            Controls.Add(TxtTexto);
            Controls.Add(labelVistaPrevia);
            Name = "FuentesView";
            Text = "FuentesView";
            ((System.ComponentModel.ISupportInitialize)numericSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVistaPrevia;
        private TextBox TxtTexto;
        private Label label1;
        private Button BtnAplicar;
        private NumericUpDown numericSize;
        private Label label2;
        private RadioButton radioIzquierda;
        private RadioButton radioCentrado;
        private RadioButton radioDerecha;
        private ComboBox comboFuentes;
        private Label label3;
    }
}