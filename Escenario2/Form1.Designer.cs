namespace Escenario2
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
            this.components = new System.ComponentModel.Container();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTipoFigura = new System.Windows.Forms.GroupBox();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbRectangulo = new System.Windows.Forms.RadioButton();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.gbTipoTriangulo = new System.Windows.Forms.GroupBox();
            this.rbEscaleno = new System.Windows.Forms.RadioButton();
            this.rbIsosceles = new System.Windows.Forms.RadioButton();
            this.rbEquilatero = new System.Windows.Forms.RadioButton();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbTipoFigura.SuspendLayout();
            this.gbTipoTriangulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(9, 127);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(47, 16);
            this.lblValor1.TabIndex = 2;
            this.lblValor1.Text = "Radio:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(62, 124);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(150, 22);
            this.txtValor1.TabIndex = 3;
            this.txtValor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(59, 157);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(153, 22);
            this.txtValor2.TabIndex = 5;
            this.txtValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(9, 160);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(44, 16);
            this.lblValor2.TabIndex = 4;
            this.lblValor2.Text = "Altura:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 293);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(99, 39);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Área:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(202, 290);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(11, 16);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "-";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbTipoFigura
            // 
            this.gbTipoFigura.Controls.Add(this.rbTriangulo);
            this.gbTipoFigura.Controls.Add(this.rbRectangulo);
            this.gbTipoFigura.Controls.Add(this.rbCirculo);
            this.gbTipoFigura.Location = new System.Drawing.Point(12, 12);
            this.gbTipoFigura.Name = "gbTipoFigura";
            this.gbTipoFigura.Size = new System.Drawing.Size(200, 100);
            this.gbTipoFigura.TabIndex = 9;
            this.gbTipoFigura.TabStop = false;
            this.gbTipoFigura.Text = "Tipo de Figura";
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(7, 76);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(82, 20);
            this.rbTriangulo.TabIndex = 2;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triángulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbRectangulo
            // 
            this.rbRectangulo.AutoSize = true;
            this.rbRectangulo.Location = new System.Drawing.Point(7, 49);
            this.rbRectangulo.Name = "rbRectangulo";
            this.rbRectangulo.Size = new System.Drawing.Size(94, 20);
            this.rbRectangulo.TabIndex = 1;
            this.rbRectangulo.TabStop = true;
            this.rbRectangulo.Text = "Rectángulo";
            this.rbRectangulo.UseVisualStyleBackColor = true;
            this.rbRectangulo.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(7, 22);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(66, 20);
            this.rbCirculo.TabIndex = 0;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Círculo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // gbTipoTriangulo
            // 
            this.gbTipoTriangulo.Controls.Add(this.rbEscaleno);
            this.gbTipoTriangulo.Controls.Add(this.rbIsosceles);
            this.gbTipoTriangulo.Controls.Add(this.rbEquilatero);
            this.gbTipoTriangulo.Location = new System.Drawing.Point(251, 12);
            this.gbTipoTriangulo.Name = "gbTipoTriangulo";
            this.gbTipoTriangulo.Size = new System.Drawing.Size(200, 100);
            this.gbTipoTriangulo.TabIndex = 10;
            this.gbTipoTriangulo.TabStop = false;
            this.gbTipoTriangulo.Text = "Tipo de Triángulo";
            this.gbTipoTriangulo.Visible = false;
            // 
            // rbEscaleno
            // 
            this.rbEscaleno.AutoSize = true;
            this.rbEscaleno.Location = new System.Drawing.Point(7, 76);
            this.rbEscaleno.Name = "rbEscaleno";
            this.rbEscaleno.Size = new System.Drawing.Size(82, 20);
            this.rbEscaleno.TabIndex = 2;
            this.rbEscaleno.TabStop = true;
            this.rbEscaleno.Text = "Escaleno";
            this.rbEscaleno.UseVisualStyleBackColor = true;
            this.rbEscaleno.CheckedChanged += new System.EventHandler(this.rbTipoTriangulo_CheckedChanged);
            // 
            // rbIsosceles
            // 
            this.rbIsosceles.AutoSize = true;
            this.rbIsosceles.Location = new System.Drawing.Point(7, 49);
            this.rbIsosceles.Name = "rbIsosceles";
            this.rbIsosceles.Size = new System.Drawing.Size(83, 20);
            this.rbIsosceles.TabIndex = 1;
            this.rbIsosceles.TabStop = true;
            this.rbIsosceles.Text = "Isósceles";
            this.rbIsosceles.UseVisualStyleBackColor = true;
            this.rbIsosceles.CheckedChanged += new System.EventHandler(this.rbTipoTriangulo_CheckedChanged);
            // 
            // rbEquilatero
            // 
            this.rbEquilatero.AutoSize = true;
            this.rbEquilatero.Location = new System.Drawing.Point(7, 22);
            this.rbEquilatero.Name = "rbEquilatero";
            this.rbEquilatero.Size = new System.Drawing.Size(86, 20);
            this.rbEquilatero.TabIndex = 0;
            this.rbEquilatero.TabStop = true;
            this.rbEquilatero.Text = "Equilátero";
            this.rbEquilatero.UseVisualStyleBackColor = true;
            this.rbEquilatero.CheckedChanged += new System.EventHandler(this.rbTipoTriangulo_CheckedChanged);
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(307, 124);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(144, 22);
            this.txtLadoB.TabIndex = 14;
            this.txtLadoB.Visible = false;
            this.txtLadoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(248, 160);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(53, 16);
            this.lblLadoC.TabIndex = 13;
            this.lblLadoC.Text = "Lado C:";
            this.lblLadoC.Visible = false;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(307, 160);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(144, 22);
            this.txtLadoC.TabIndex = 12;
            this.txtLadoC.Visible = false;
            this.txtLadoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(248, 127);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(53, 16);
            this.lblLadoB.TabIndex = 11;
            this.lblLadoB.Text = "Lado B:";
            this.lblLadoB.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Perímetro:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(202, 316);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(11, 16);
            this.lblPerimetro.TabIndex = 16;
            this.lblPerimetro.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 344);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.gbTipoTriangulo);
            this.Controls.Add(this.gbTipoFigura);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor1);
            this.Name = "Form1";
            this.Text = "Escenario 2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbTipoFigura.ResumeLayout(false);
            this.gbTipoFigura.PerformLayout();
            this.gbTipoTriangulo.ResumeLayout(false);
            this.gbTipoTriangulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbTipoFigura;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbRectangulo;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.GroupBox gbTipoTriangulo;
        private System.Windows.Forms.RadioButton rbEscaleno;
        private System.Windows.Forms.RadioButton rbIsosceles;
        private System.Windows.Forms.RadioButton rbEquilatero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPerimetro;
    }
}

