namespace dbproje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarkaAdı = new System.Windows.Forms.TextBox();
            this.txtKasaTipi = new System.Windows.Forms.TextBox();
            this.txtVitesTipi = new System.Windows.Forms.TextBox();
            this.txtModelYılı = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Lstbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.slbtn = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kasa Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vites Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model Yılı";
            // 
            // txtMarkaAdı
            // 
            this.txtMarkaAdı.Location = new System.Drawing.Point(227, 66);
            this.txtMarkaAdı.Name = "txtMarkaAdı";
            this.txtMarkaAdı.Size = new System.Drawing.Size(125, 27);
            this.txtMarkaAdı.TabIndex = 4;
            // 
            // txtKasaTipi
            // 
            this.txtKasaTipi.Location = new System.Drawing.Point(227, 109);
            this.txtKasaTipi.Name = "txtKasaTipi";
            this.txtKasaTipi.Size = new System.Drawing.Size(125, 27);
            this.txtKasaTipi.TabIndex = 5;
            // 
            // txtVitesTipi
            // 
            this.txtVitesTipi.Location = new System.Drawing.Point(227, 161);
            this.txtVitesTipi.Name = "txtVitesTipi";
            this.txtVitesTipi.Size = new System.Drawing.Size(125, 27);
            this.txtVitesTipi.TabIndex = 6;
            // 
            // txtModelYılı
            // 
            this.txtModelYılı.Location = new System.Drawing.Point(227, 205);
            this.txtModelYılı.Name = "txtModelYılı";
            this.txtModelYılı.Size = new System.Drawing.Size(125, 27);
            this.txtModelYılı.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lstbtn
            // 
            this.Lstbtn.Location = new System.Drawing.Point(236, 261);
            this.Lstbtn.Name = "Lstbtn";
            this.Lstbtn.Size = new System.Drawing.Size(116, 77);
            this.Lstbtn.TabIndex = 9;
            this.Lstbtn.Text = "Listele";
            this.Lstbtn.UseVisualStyleBackColor = true;
            this.Lstbtn.Click += new System.EventHandler(this.Lstbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(687, 188);
            this.dataGridView1.TabIndex = 10;
            // 
            // slbtn
            // 
            this.slbtn.Location = new System.Drawing.Point(162, 419);
            this.slbtn.Name = "slbtn";
            this.slbtn.Size = new System.Drawing.Size(116, 77);
            this.slbtn.TabIndex = 11;
            this.slbtn.Text = "sil";
            this.slbtn.UseVisualStyleBackColor = true;
            this.slbtn.Click += new System.EventHandler(this.slbtn_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(162, 386);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 27);
            this.txtID.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 696);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.slbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lstbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtModelYılı);
            this.Controls.Add(this.txtVitesTipi);
            this.Controls.Add(this.txtKasaTipi);
            this.Controls.Add(this.txtMarkaAdı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMarkaAdı;
        private TextBox txtKasaTipi;
        private TextBox txtVitesTipi;
        private TextBox txtModelYılı;
        private Button button1;
        private Button Lstbtn;
        private DataGridView dataGridView1;
        private Button slbtn;
        private TextBox txtID;
    }
}