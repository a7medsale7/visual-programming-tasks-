namespace calculator
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnclear = new Button();
            btnplus = new Button();
            btndivide = new Button();
            btnmulti = new Button();
            btnminus = new Button();
            btnequl = new Button();
            btn0 = new Button();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(127, 104);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 72);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(233, 104);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 72);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(335, 104);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 72);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(125, 204);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 72);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(233, 204);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 72);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(127, 299);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 72);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(335, 204);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 72);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(233, 299);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 72);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(335, 299);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 72);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(125, 389);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(290, 49);
            btnclear.TabIndex = 10;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnplus
            // 
            btnplus.Location = new Point(421, 199);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(78, 44);
            btnplus.TabIndex = 13;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btndivide
            // 
            btndivide.Location = new Point(419, 149);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(78, 44);
            btndivide.TabIndex = 12;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += btndivide_Click;
            // 
            // btnmulti
            // 
            btnmulti.Location = new Point(419, 99);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(78, 44);
            btnmulti.TabIndex = 11;
            btnmulti.Text = "*";
            btnmulti.UseVisualStyleBackColor = true;
            btnmulti.Click += btnmulti_Click;
            // 
            // btnminus
            // 
            btnminus.Location = new Point(419, 249);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(78, 44);
            btnminus.TabIndex = 14;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btnminus_Click;
            // 
            // btnequl
            // 
            btnequl.Location = new Point(423, 377);
            btnequl.Name = "btnequl";
            btnequl.Size = new Size(78, 72);
            btnequl.TabIndex = 15;
            btnequl.Text = "=";
            btnequl.UseVisualStyleBackColor = true;
            btnequl.Click += btnequl_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(421, 299);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 72);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button16_Click;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(129, 35);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(368, 58);
            txtTotal.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 450);
            Controls.Add(txtTotal);
            Controls.Add(btn0);
            Controls.Add(btnequl);
            Controls.Add(btnminus);
            Controls.Add(btnplus);
            Controls.Add(btndivide);
            Controls.Add(btnmulti);
            Controls.Add(btnclear);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn7;
        private Button btn6;
        private Button btn8;
        private Button btn9;
        private Button btnclear;
        private Button btnplus;
        private Button btndivide;
        private Button btnmulti;
        private Button btnminus;
        private Button btnequl;
        private Button btn0;
        private TextBox txtTotal;
    }
}