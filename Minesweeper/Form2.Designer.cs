namespace Minesweeper
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnlCustom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.txtDong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustom
            // 
            this.pnlCustom.Controls.Add(this.btnStart);
            this.pnlCustom.Controls.Add(this.txtBom);
            this.pnlCustom.Controls.Add(this.label3);
            this.pnlCustom.Controls.Add(this.txtDong);
            this.pnlCustom.Controls.Add(this.label2);
            this.pnlCustom.Controls.Add(this.txtCot);
            this.pnlCustom.Controls.Add(this.label1);
            this.pnlCustom.Location = new System.Drawing.Point(1, 1);
            this.pnlCustom.Name = "pnlCustom";
            this.pnlCustom.Size = new System.Drawing.Size(307, 217);
            this.pnlCustom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số cột";
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(203, 27);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(91, 22);
            this.txtCot.TabIndex = 1;
            this.txtCot.TextChanged += new System.EventHandler(this.txtCot_TextChanged);
            // 
            // txtDong
            // 
            this.txtDong.Location = new System.Drawing.Point(203, 71);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(91, 22);
            this.txtDong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số dòng";
            // 
            // txtBom
            // 
            this.txtBom.Location = new System.Drawing.Point(203, 112);
            this.txtBom.Name = "txtBom";
            this.txtBom.Size = new System.Drawing.Size(91, 22);
            this.txtBom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập số bom";
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(67, 155);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 43);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "OK";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 221);
            this.Controls.Add(this.pnlCustom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlCustom.ResumeLayout(false);
            this.pnlCustom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustom;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDong;
        private System.Windows.Forms.Label label2;
    }
}