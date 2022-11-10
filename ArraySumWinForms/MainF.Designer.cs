namespace ArraySumWinForms
{
    partial class MainF
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
            this.rtb_Res = new System.Windows.Forms.RichTextBox();
            this.btn_SamArrayElements = new System.Windows.Forms.Button();
            this.lbl_N = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_N = new System.Windows.Forms.TextBox();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtb_Res
            // 
            this.rtb_Res.Location = new System.Drawing.Point(12, 149);
            this.rtb_Res.Name = "rtb_Res";
            this.rtb_Res.ReadOnly = true;
            this.rtb_Res.Size = new System.Drawing.Size(409, 288);
            this.rtb_Res.TabIndex = 18;
            this.rtb_Res.Text = "";
            // 
            // btn_SamArrayElements
            // 
            this.btn_SamArrayElements.Location = new System.Drawing.Point(12, 89);
            this.btn_SamArrayElements.Name = "btn_SamArrayElements";
            this.btn_SamArrayElements.Size = new System.Drawing.Size(409, 44);
            this.btn_SamArrayElements.TabIndex = 17;
            this.btn_SamArrayElements.Text = "Сумма элементов массива";
            this.btn_SamArrayElements.UseVisualStyleBackColor = true;
            this.btn_SamArrayElements.Click += new System.EventHandler(this.btn_SamArrayElements_Click);
            // 
            // lbl_N
            // 
            this.lbl_N.AutoSize = true;
            this.lbl_N.Location = new System.Drawing.Point(12, 46);
            this.lbl_N.Name = "lbl_N";
            this.lbl_N.Size = new System.Drawing.Size(16, 15);
            this.lbl_N.TabIndex = 16;
            this.lbl_N.Text = "N";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(155, 46);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(13, 15);
            this.lbl_a.TabIndex = 15;
            this.lbl_a.Text = "a";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(300, 46);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(14, 15);
            this.lbl_b.TabIndex = 14;
            this.lbl_b.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Сумма элемента массива длинной N. Элементы нах-ся в интервале [a,b)";
            // 
            // tb_N
            // 
            this.tb_N.Location = new System.Drawing.Point(32, 43);
            this.tb_N.Name = "tb_N";
            this.tb_N.Size = new System.Drawing.Size(100, 23);
            this.tb_N.TabIndex = 12;
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(175, 43);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(100, 23);
            this.tb_a.TabIndex = 11;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(319, 43);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(100, 23);
            this.tb_b.TabIndex = 10;
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.rtb_Res);
            this.Controls.Add(this.btn_SamArrayElements);
            this.Controls.Add(this.lbl_N);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_N);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.tb_b);
            this.Name = "MainF";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtb_Res;
        private Button btn_SamArrayElements;
        private Label lbl_N;
        private Label lbl_a;
        private Label lbl_b;
        private Label label1;
        private TextBox tb_N;
        private TextBox tb_a;
        private TextBox tb_b;
    }
}