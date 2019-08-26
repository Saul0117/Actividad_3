namespace LOGIN_2._1
{
    partial class Ventana2
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
            this.label2 = new System.Windows.Forms.Label();
            this.VC = new System.Windows.Forms.CheckBox();
            this.VB = new System.Windows.Forms.CheckBox();
            this.TC = new System.Windows.Forms.RadioButton();
            this.PP = new System.Windows.Forms.RadioButton();
            this.c = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formas de Pago";
            // 
            // VC
            // 
            this.VC.AutoSize = true;
            this.VC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VC.Location = new System.Drawing.Point(63, 143);
            this.VC.Name = "VC";
            this.VC.Size = new System.Drawing.Size(105, 28);
            this.VC.TabIndex = 2;
            this.VC.Text = "Visual c#";
            this.VC.UseVisualStyleBackColor = true;
            // 
            // VB
            // 
            this.VB.AutoSize = true;
            this.VB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VB.Location = new System.Drawing.Point(63, 227);
            this.VB.Name = "VB";
            this.VB.Size = new System.Drawing.Size(130, 28);
            this.VB.TabIndex = 3;
            this.VB.Text = "Visual Basic";
            this.VB.UseVisualStyleBackColor = true;
            // 
            // TC
            // 
            this.TC.AutoSize = true;
            this.TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC.Location = new System.Drawing.Point(569, 142);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(177, 28);
            this.TC.TabIndex = 4;
            this.TC.TabStop = true;
            this.TC.Text = "Tarjeta de Credito";
            this.TC.UseVisualStyleBackColor = true;
            // 
            // PP
            // 
            this.PP.AutoSize = true;
            this.PP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PP.Location = new System.Drawing.Point(569, 227);
            this.PP.Name = "PP";
            this.PP.Size = new System.Drawing.Size(85, 28);
            this.PP.TabIndex = 5;
            this.PP.TabStop = true;
            this.PP.Text = "PayPal";
            this.PP.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(63, 338);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(129, 78);
            this.c.TabIndex = 6;
            this.c.Text = "Comprar";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 78);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.c);
            this.Controls.Add(this.PP);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.VB);
            this.Controls.Add(this.VC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ventana2";
            this.Text = "Curso de programacion";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox VC;
        private System.Windows.Forms.CheckBox VB;
        private System.Windows.Forms.RadioButton TC;
        private System.Windows.Forms.RadioButton PP;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button button2;
    }
}