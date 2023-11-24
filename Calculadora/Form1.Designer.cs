namespace Calculadora
{
    partial class Calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnMasOmenos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.MaxLength = 21;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(286, 36);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMasOmenos
            // 
            this.btnMasOmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasOmenos.Location = new System.Drawing.Point(14, 312);
            this.btnMasOmenos.Name = "btnMasOmenos";
            this.btnMasOmenos.Size = new System.Drawing.Size(50, 50);
            this.btnMasOmenos.TabIndex = 1;
            this.btnMasOmenos.Tag = "";
            this.btnMasOmenos.Text = "±";
            this.btnMasOmenos.UseVisualStyleBackColor = true;
            this.btnMasOmenos.Click += new System.EventHandler(this.btnMasOmenos_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(70, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(182, 312);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(106, 50);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(126, 312);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(50, 50);
            this.btnPunto.TabIndex = 7;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(70, 312);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(50, 50);
            this.btnCero.TabIndex = 8;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(126, 82);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(106, 50);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(182, 197);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(50, 50);
            this.btnMultiplicar.TabIndex = 12;
            this.btnMultiplicar.Tag = "x";
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.clickOperador);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(148, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(0, 0);
            this.button9.TabIndex = 10;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(70, 140);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(50, 50);
            this.btnOcho.TabIndex = 9;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(14, 84);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(106, 50);
            this.btnCE.TabIndex = 18;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(238, 197);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(50, 50);
            this.btnDividir.TabIndex = 17;
            this.btnDividir.Tag = "÷";
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(156, 132);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(0, 0);
            this.button14.TabIndex = 15;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(14, 140);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(50, 50);
            this.btnSiete.TabIndex = 14;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(238, 253);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(50, 50);
            this.btnResta.TabIndex = 23;
            this.btnResta.Tag = "-";
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(182, 140);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(50, 50);
            this.btnRaiz.TabIndex = 22;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(164, 140);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(0, 0);
            this.button19.TabIndex = 20;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(126, 197);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(50, 50);
            this.btnSeis.TabIndex = 19;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(14, 197);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(50, 50);
            this.btnCuatro.TabIndex = 28;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(126, 140);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(50, 50);
            this.btnNueve.TabIndex = 27;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(172, 148);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(0, 0);
            this.button24.TabIndex = 25;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(70, 197);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(50, 50);
            this.btnCinco.TabIndex = 24;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(70, 253);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(50, 50);
            this.btnDos.TabIndex = 33;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(126, 253);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(50, 50);
            this.btnTres.TabIndex = 32;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(182, 253);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(50, 50);
            this.btnSuma.TabIndex = 31;
            this.btnSuma.Tag = "+";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.clickOperador);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(70, 247);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(0, 0);
            this.button29.TabIndex = 30;
            this.button29.Text = "button29";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(14, 253);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(50, 50);
            this.btnUno.TabIndex = 29;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.Location = new System.Drawing.Point(238, 141);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(50, 50);
            this.btnCuadrado.TabIndex = 34;
            this.btnCuadrado.Tag = "²";
            this.btnCuadrado.Text = "x²";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(238, 82);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 50);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.Text = "⌫";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 378);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnMasOmenos);
            this.Controls.Add(this.txtResultado);
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de freddy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnMasOmenos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnBorrar;
    }
}

