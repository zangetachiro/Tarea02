namespace Tarea02
{
    partial class Programa2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtP = new System.Windows.Forms.RadioButton();
            this.rbtM = new System.Windows.Forms.RadioButton();
            this.rbtG = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtCG = new System.Windows.Forms.RadioButton();
            this.rbtCD = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbEQ = new System.Windows.Forms.CheckBox();
            this.cbCh = new System.Windows.Forms.CheckBox();
            this.cbCl = new System.Windows.Forms.CheckBox();
            this.cbCe = new System.Windows.Forms.CheckBox();
            this.cbCo = new System.Windows.Forms.CheckBox();
            this.cbTo = new System.Windows.Forms.CheckBox();
            this.rbtAq = new System.Windows.Forms.RadioButton();
            this.rbtLl = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCocinar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtG);
            this.groupBox1.Controls.Add(this.rbtM);
            this.groupBox1.Controls.Add(this.rbtP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño";
            // 
            // rbtP
            // 
            this.rbtP.AutoSize = true;
            this.rbtP.Location = new System.Drawing.Point(29, 20);
            this.rbtP.Name = "rbtP";
            this.rbtP.Size = new System.Drawing.Size(68, 17);
            this.rbtP.TabIndex = 0;
            this.rbtP.Text = "Pequeña";
            this.rbtP.UseVisualStyleBackColor = true;
            // 
            // rbtM
            // 
            this.rbtM.AutoSize = true;
            this.rbtM.Location = new System.Drawing.Point(29, 43);
            this.rbtM.Name = "rbtM";
            this.rbtM.Size = new System.Drawing.Size(66, 17);
            this.rbtM.TabIndex = 1;
            this.rbtM.Text = "Mediana";
            this.rbtM.UseVisualStyleBackColor = true;
            // 
            // rbtG
            // 
            this.rbtG.AutoSize = true;
            this.rbtG.Checked = true;
            this.rbtG.Location = new System.Drawing.Point(29, 66);
            this.rbtG.Name = "rbtG";
            this.rbtG.Size = new System.Drawing.Size(60, 17);
            this.rbtG.TabIndex = 2;
            this.rbtG.TabStop = true;
            this.rbtG.Text = "Grande";
            this.rbtG.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtCG);
            this.groupBox2.Controls.Add(this.rbtCD);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Cubierta";
            // 
            // rbtCG
            // 
            this.rbtCG.AutoSize = true;
            this.rbtCG.Checked = true;
            this.rbtCG.Location = new System.Drawing.Point(29, 60);
            this.rbtCG.Name = "rbtCG";
            this.rbtCG.Size = new System.Drawing.Size(101, 17);
            this.rbtCG.TabIndex = 1;
            this.rbtCG.TabStop = true;
            this.rbtCG.Text = "Cubierta Gruesa";
            this.rbtCG.UseVisualStyleBackColor = true;
            // 
            // rbtCD
            // 
            this.rbtCD.AutoSize = true;
            this.rbtCD.Location = new System.Drawing.Point(29, 37);
            this.rbtCD.Name = "rbtCD";
            this.rbtCD.Size = new System.Drawing.Size(107, 17);
            this.rbtCD.TabIndex = 0;
            this.rbtCD.Text = "Cubierta Delgada";
            this.rbtCD.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTo);
            this.groupBox3.Controls.Add(this.cbCo);
            this.groupBox3.Controls.Add(this.cbCe);
            this.groupBox3.Controls.Add(this.cbCl);
            this.groupBox3.Controls.Add(this.cbCh);
            this.groupBox3.Controls.Add(this.cbEQ);
            this.groupBox3.Location = new System.Drawing.Point(213, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingredientes";
            // 
            // cbEQ
            // 
            this.cbEQ.AutoSize = true;
            this.cbEQ.Checked = true;
            this.cbEQ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEQ.Location = new System.Drawing.Point(31, 28);
            this.cbEQ.Name = "cbEQ";
            this.cbEQ.Size = new System.Drawing.Size(84, 17);
            this.cbEQ.TabIndex = 0;
            this.cbEQ.Text = "Extra Queso";
            this.cbEQ.UseVisualStyleBackColor = true;
            // 
            // cbCh
            // 
            this.cbCh.AutoSize = true;
            this.cbCh.Location = new System.Drawing.Point(31, 50);
            this.cbCh.Name = "cbCh";
            this.cbCh.Size = new System.Drawing.Size(90, 17);
            this.cbCh.TabIndex = 1;
            this.cbCh.Text = "Champiñones";
            this.cbCh.UseVisualStyleBackColor = true;
            // 
            // cbCl
            // 
            this.cbCl.AutoSize = true;
            this.cbCl.Location = new System.Drawing.Point(31, 72);
            this.cbCl.Name = "cbCl";
            this.cbCl.Size = new System.Drawing.Size(58, 17);
            this.cbCl.TabIndex = 2;
            this.cbCl.Text = "Clavos";
            this.cbCl.UseVisualStyleBackColor = true;
            // 
            // cbCe
            // 
            this.cbCe.AutoSize = true;
            this.cbCe.Location = new System.Drawing.Point(166, 28);
            this.cbCe.Name = "cbCe";
            this.cbCe.Size = new System.Drawing.Size(61, 17);
            this.cbCe.TabIndex = 3;
            this.cbCe.Text = "Cebolla";
            this.cbCe.UseVisualStyleBackColor = true;
            // 
            // cbCo
            // 
            this.cbCo.AutoSize = true;
            this.cbCo.Location = new System.Drawing.Point(166, 50);
            this.cbCo.Name = "cbCo";
            this.cbCo.Size = new System.Drawing.Size(66, 17);
            this.cbCo.TabIndex = 4;
            this.cbCo.Text = "Cominos";
            this.cbCo.UseVisualStyleBackColor = true;
            // 
            // cbTo
            // 
            this.cbTo.AutoSize = true;
            this.cbTo.Location = new System.Drawing.Point(166, 72);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(67, 17);
            this.cbTo.TabIndex = 5;
            this.cbTo.Text = "Tomates";
            this.cbTo.UseVisualStyleBackColor = true;
            // 
            // rbtAq
            // 
            this.rbtAq.AutoSize = true;
            this.rbtAq.Location = new System.Drawing.Point(30, 32);
            this.rbtAq.Name = "rbtAq";
            this.rbtAq.Size = new System.Drawing.Size(79, 17);
            this.rbtAq.TabIndex = 3;
            this.rbtAq.TabStop = true;
            this.rbtAq.Text = "Comer Aqui";
            this.rbtAq.UseVisualStyleBackColor = true;
            this.rbtAq.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtLl
            // 
            this.rbtLl.AutoSize = true;
            this.rbtLl.Location = new System.Drawing.Point(30, 55);
            this.rbtLl.Name = "rbtLl";
            this.rbtLl.Size = new System.Drawing.Size(79, 17);
            this.rbtLl.TabIndex = 4;
            this.rbtLl.TabStop = true;
            this.rbtLl.Text = "Para Llevar";
            this.rbtLl.UseVisualStyleBackColor = true;
            this.rbtLl.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtAq);
            this.groupBox4.Controls.Add(this.rbtLl);
            this.groupBox4.Location = new System.Drawing.Point(244, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 96);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Para comer...";
            // 
            // btnCocinar
            // 
            this.btnCocinar.Location = new System.Drawing.Point(75, 257);
            this.btnCocinar.Name = "btnCocinar";
            this.btnCocinar.Size = new System.Drawing.Size(139, 53);
            this.btnCocinar.TabIndex = 6;
            this.btnCocinar.Text = "Cocinar Pizza";
            this.btnCocinar.UseVisualStyleBackColor = true;
            this.btnCocinar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(308, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 53);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Programa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 322);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCocinar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Programa2";
            this.Text = "Pizzeria Taste like chiken Co.";
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtG;
        private System.Windows.Forms.RadioButton rbtM;
        private System.Windows.Forms.RadioButton rbtP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtCG;
        private System.Windows.Forms.RadioButton rbtCD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbTo;
        private System.Windows.Forms.CheckBox cbCo;
        private System.Windows.Forms.CheckBox cbCe;
        private System.Windows.Forms.CheckBox cbCl;
        private System.Windows.Forms.CheckBox cbCh;
        private System.Windows.Forms.CheckBox cbEQ;
        private System.Windows.Forms.RadioButton rbtAq;
        private System.Windows.Forms.RadioButton rbtLl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCocinar;
        private System.Windows.Forms.Button btnSalir;
    }
}