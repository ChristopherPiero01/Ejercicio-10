namespace Ejercicio_10
{
    partial class Form1
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
            label1 = new Label();
            txtCon = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDes = new TextBox();
            txtSt = new TextBox();
            txtImp = new TextBox();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 59);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 0;
            label1.Text = "Monto del consumo:";
            // 
            // txtCon
            // 
            txtCon.Location = new Point(206, 61);
            txtCon.Name = "txtCon";
            txtCon.Size = new Size(100, 23);
            txtCon.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(186, 103);
            button1.Name = "button1";
            button1.Size = new Size(139, 46);
            button1.TabIndex = 2;
            button1.Text = "calcular la cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 192);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 3;
            label2.Text = "Descuento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(93, 239);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 4;
            label3.Text = "Subtotal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(86, 288);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 5;
            label4.Text = "Impuesto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 332);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 6;
            label5.Text = "Total a pagar:";
            // 
            // txtDes
            // 
            txtDes.Location = new Point(206, 194);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(100, 23);
            txtDes.TabIndex = 7;
            // 
            // txtSt
            // 
            txtSt.Location = new Point(206, 241);
            txtSt.Name = "txtSt";
            txtSt.Size = new Size(100, 23);
            txtSt.TabIndex = 8;
            // 
            // txtImp
            // 
            txtImp.Location = new Point(206, 290);
            txtImp.Name = "txtImp";
            txtImp.Size = new Size(100, 23);
            txtImp.TabIndex = 9;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(206, 334);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(txtImp);
            Controls.Add(txtSt);
            Controls.Add(txtDes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtCon);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCon;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDes;
        private TextBox txtSt;
        private TextBox txtImp;
        private TextBox txtTotal;
    }
}