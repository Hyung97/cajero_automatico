namespace Cajero_Automatico
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantifdad = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFibo = new System.Windows.Forms.Label();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.txtSucesionDeFibonacci = new System.Windows.Forms.TextBox();
            this.btnSucesionFibonacci = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnResultadoPrimo = new System.Windows.Forms.Button();
            this.lblPrimoResp = new System.Windows.Forms.Label();
            this.txtNumPrimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(29, 17);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(150, 20);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "TOTAL A RETIRAR";
            // 
            // txtCantifdad
            // 
            this.txtCantifdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantifdad.Location = new System.Drawing.Point(33, 40);
            this.txtCantifdad.Name = "txtCantifdad";
            this.txtCantifdad.Size = new System.Drawing.Size(133, 26);
            this.txtCantifdad.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(58, 68);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 29);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "PAGO";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer.Location = new System.Drawing.Point(2, 104);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(124, 20);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "RESPUESTA: ?";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(202, 13);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(133, 26);
            this.txtMoney.TabIndex = 6;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Black;
            this.lblMoney.Location = new System.Drawing.Point(6, 16);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(195, 20);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "EFECTIVO ENTREGADO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtCantifdad);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.lblAnswer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(94, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 284);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblDevolucion);
            this.groupBox2.Controls.Add(this.btnCancelarPago);
            this.groupBox2.Controls.Add(this.txtPagar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMoney);
            this.groupBox2.Controls.Add(this.txtMoney);
            this.groupBox2.Location = new System.Drawing.Point(316, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 281);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.BackColor = System.Drawing.Color.Transparent;
            this.lblDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucion.ForeColor = System.Drawing.Color.Black;
            this.lblDevolucion.Location = new System.Drawing.Point(18, 112);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(124, 20);
            this.lblDevolucion.TabIndex = 5;
            this.lblDevolucion.Text = "RESPUESTA: ?";
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPago.Location = new System.Drawing.Point(258, 78);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(75, 30);
            this.btnCancelarPago.TabIndex = 5;
            this.btnCancelarPago.Text = "PAGO";
            this.btnCancelarPago.UseVisualStyleBackColor = true;
            this.btnCancelarPago.Click += new System.EventHandler(this.btnCancelarPago_Click);
            // 
            // txtPagar
            // 
            this.txtPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagar.Location = new System.Drawing.Point(202, 48);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Size = new System.Drawing.Size(133, 26);
            this.txtPagar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "EFECTIVO A CANCELAR";
            // 
            // lblFibo
            // 
            this.lblFibo.AutoSize = true;
            this.lblFibo.BackColor = System.Drawing.Color.Transparent;
            this.lblFibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFibo.ForeColor = System.Drawing.Color.Black;
            this.lblFibo.Location = new System.Drawing.Point(67, 22);
            this.lblFibo.Name = "lblFibo";
            this.lblFibo.Size = new System.Drawing.Size(211, 20);
            this.lblFibo.TabIndex = 15;
            this.lblFibo.Text = "SUCESION DE FIBONACCI";
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.AutoSize = true;
            this.lblFibonacci.BackColor = System.Drawing.Color.Transparent;
            this.lblFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFibonacci.Location = new System.Drawing.Point(6, 111);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(124, 20);
            this.lblFibonacci.TabIndex = 14;
            this.lblFibonacci.Text = "RESPUESTA: ?";
            // 
            // txtSucesionDeFibonacci
            // 
            this.txtSucesionDeFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucesionDeFibonacci.Location = new System.Drawing.Point(117, 49);
            this.txtSucesionDeFibonacci.Name = "txtSucesionDeFibonacci";
            this.txtSucesionDeFibonacci.Size = new System.Drawing.Size(100, 26);
            this.txtSucesionDeFibonacci.TabIndex = 13;
            // 
            // btnSucesionFibonacci
            // 
            this.btnSucesionFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucesionFibonacci.Location = new System.Drawing.Point(107, 81);
            this.btnSucesionFibonacci.Name = "btnSucesionFibonacci";
            this.btnSucesionFibonacci.Size = new System.Drawing.Size(117, 27);
            this.btnSucesionFibonacci.TabIndex = 12;
            this.btnSucesionFibonacci.Text = "RESULTADO";
            this.btnSucesionFibonacci.UseVisualStyleBackColor = true;
            this.btnSucesionFibonacci.Click += new System.EventHandler(this.btnSucesionFibonacci_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblFibo);
            this.groupBox3.Controls.Add(this.lblFibonacci);
            this.groupBox3.Controls.Add(this.txtSucesionDeFibonacci);
            this.groupBox3.Controls.Add(this.btnSucesionFibonacci);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(326, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 308);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnResultadoPrimo);
            this.groupBox4.Controls.Add(this.lblPrimoResp);
            this.groupBox4.Controls.Add(this.txtNumPrimo);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(51, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 305);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // btnResultadoPrimo
            // 
            this.btnResultadoPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultadoPrimo.Location = new System.Drawing.Point(70, 74);
            this.btnResultadoPrimo.Name = "btnResultadoPrimo";
            this.btnResultadoPrimo.Size = new System.Drawing.Size(125, 31);
            this.btnResultadoPrimo.TabIndex = 19;
            this.btnResultadoPrimo.Text = "RESULTADO";
            this.btnResultadoPrimo.UseVisualStyleBackColor = true;
            this.btnResultadoPrimo.Click += new System.EventHandler(this.btnResultadoPrimo_Click);
            // 
            // lblPrimoResp
            // 
            this.lblPrimoResp.AutoSize = true;
            this.lblPrimoResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimoResp.Location = new System.Drawing.Point(11, 112);
            this.lblPrimoResp.Name = "lblPrimoResp";
            this.lblPrimoResp.Size = new System.Drawing.Size(124, 20);
            this.lblPrimoResp.TabIndex = 18;
            this.lblPrimoResp.Text = "RESPUESTA: ?";
            // 
            // txtNumPrimo
            // 
            this.txtNumPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPrimo.Location = new System.Drawing.Point(81, 42);
            this.txtNumPrimo.Name = "txtNumPrimo";
            this.txtNumPrimo.Size = new System.Drawing.Size(100, 26);
            this.txtNumPrimo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "NUMEROS PRIMOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 624);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantifdad;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFibo;
        private System.Windows.Forms.Label lblFibonacci;
        private System.Windows.Forms.TextBox txtSucesionDeFibonacci;
        private System.Windows.Forms.Button btnSucesionFibonacci;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnResultadoPrimo;
        private System.Windows.Forms.Label lblPrimoResp;
        private System.Windows.Forms.TextBox txtNumPrimo;
        private System.Windows.Forms.Label label4;
    }
}

