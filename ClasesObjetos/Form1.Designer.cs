namespace ClasesObjetos
{
    partial class Form1
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
            this.numNumerador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador2 = new System.Windows.Forms.NumericUpDown();
            this.numNumerador2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCalcularResultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumerador1
            // 
            this.numNumerador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumerador1.Location = new System.Drawing.Point(94, 32);
            this.numNumerador1.Name = "numNumerador1";
            this.numNumerador1.Size = new System.Drawing.Size(120, 38);
            this.numNumerador1.TabIndex = 0;
            // 
            // numDenominador1
            // 
            this.numDenominador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDenominador1.Location = new System.Drawing.Point(94, 86);
            this.numDenominador1.Name = "numDenominador1";
            this.numDenominador1.Size = new System.Drawing.Size(120, 38);
            this.numDenominador1.TabIndex = 1;
            // 
            // numDenominador2
            // 
            this.numDenominador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDenominador2.Location = new System.Drawing.Point(345, 86);
            this.numDenominador2.Name = "numDenominador2";
            this.numDenominador2.Size = new System.Drawing.Size(120, 38);
            this.numDenominador2.TabIndex = 3;
            // 
            // numNumerador2
            // 
            this.numNumerador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumerador2.Location = new System.Drawing.Point(345, 32);
            this.numNumerador2.Name = "numNumerador2";
            this.numNumerador2.Size = new System.Drawing.Size(120, 38);
            this.numNumerador2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "____________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "____________________";
            // 
            // lblCalcularResultado
            // 
            this.lblCalcularResultado.AutoSize = true;
            this.lblCalcularResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularResultado.Location = new System.Drawing.Point(484, 65);
            this.lblCalcularResultado.Name = "lblCalcularResultado";
            this.lblCalcularResultado.Size = new System.Drawing.Size(30, 31);
            this.lblCalcularResultado.TabIndex = 7;
            this.lblCalcularResultado.Text = "=";
            this.lblCalcularResultado.Click += new System.EventHandler(this.lblCalcularResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(535, 65);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(27, 31);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "x";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(10, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 53);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(267, 52);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 53);
            this.numericUpDown2.TabIndex = 10;
            // 
            // cboOperacion
            // 
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cboOperacion.Location = new System.Drawing.Point(220, 65);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(41, 21);
            this.cboOperacion.TabIndex = 11;
            this.cboOperacion.SelectedIndexChanged += new System.EventHandler(this.cboOperacion_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 348);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCalcularResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDenominador2);
            this.Controls.Add(this.numNumerador2);
            this.Controls.Add(this.numDenominador1);
            this.Controls.Add(this.numNumerador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNumerador1;
        private System.Windows.Forms.NumericUpDown numDenominador1;
        private System.Windows.Forms.NumericUpDown numDenominador2;
        private System.Windows.Forms.NumericUpDown numNumerador2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCalcularResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox cboOperacion;
    }
}