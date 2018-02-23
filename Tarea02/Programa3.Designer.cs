namespace Tarea02
{
    partial class Programa3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.txtIncDec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRInc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRDecremento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.btnIntercambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Inicial";
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(176, 37);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(100, 20);
            this.txtInicial.TabIndex = 1;
            // 
            // txtIncDec
            // 
            this.txtIncDec.Location = new System.Drawing.Point(176, 96);
            this.txtIncDec.Name = "txtIncDec";
            this.txtIncDec.Size = new System.Drawing.Size(100, 20);
            this.txtIncDec.TabIndex = 3;
            this.txtIncDec.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(184, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Incr/Decr";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRInc
            // 
            this.lblRInc.Location = new System.Drawing.Point(21, 198);
            this.lblRInc.Name = "lblRInc";
            this.lblRInc.Size = new System.Drawing.Size(100, 20);
            this.lblRInc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado del incremento";
            // 
            // lblContador
            // 
            this.lblContador.Location = new System.Drawing.Point(176, 198);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(100, 20);
            this.lblContador.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(203, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contador";
            // 
            // lblRDecremento
            // 
            this.lblRDecremento.Location = new System.Drawing.Point(326, 198);
            this.lblRDecremento.Name = "lblRDecremento";
            this.lblRDecremento.Size = new System.Drawing.Size(100, 20);
            this.lblRDecremento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(337, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado del decremento";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(21, 250);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 25);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Ini&ciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(176, 250);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(100, 25);
            this.btnIncrementar.TabIndex = 11;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // btnIntercambiar
            // 
            this.btnIntercambiar.Location = new System.Drawing.Point(326, 250);
            this.btnIntercambiar.Name = "btnIntercambiar";
            this.btnIntercambiar.Size = new System.Drawing.Size(100, 25);
            this.btnIntercambiar.TabIndex = 12;
            this.btnIntercambiar.Text = "Intercambiar";
            this.btnIntercambiar.UseVisualStyleBackColor = true;
            this.btnIntercambiar.Click += new System.EventHandler(this.btnIntercambiar_Click);
            // 
            // Programa3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 302);
            this.Controls.Add(this.btnIntercambiar);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblRDecremento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRInc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIncDec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.label1);
            this.Name = "Programa3";
            this.Text = "Incrementos y Decrementos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.TextBox txtIncDec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblRInc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblContador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblRDecremento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.Button btnIntercambiar;
    }
}