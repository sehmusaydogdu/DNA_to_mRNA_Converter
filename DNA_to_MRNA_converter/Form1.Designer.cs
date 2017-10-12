namespace DNA_to_MRNA_converter
{
    partial class Form1
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
            this.txtDNA = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmRNA = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RNA_to_DNA = new System.Windows.Forms.Button();
            this.btn_DNA_to_RNA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNA Sequence";
            // 
            // txtDNA
            // 
            this.txtDNA.Location = new System.Drawing.Point(16, 71);
            this.txtDNA.Name = "txtDNA";
            this.txtDNA.Size = new System.Drawing.Size(546, 96);
            this.txtDNA.TabIndex = 1;
            this.txtDNA.Text = "";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(30, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5\'  ---   3\'";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(30, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3\'  ---   5\'";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "mRNA Sequence";
            // 
            // txtmRNA
            // 
            this.txtmRNA.Location = new System.Drawing.Point(12, 347);
            this.txtmRNA.Name = "txtmRNA";
            this.txtmRNA.Size = new System.Drawing.Size(550, 96);
            this.txtmRNA.TabIndex = 5;
            this.txtmRNA.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RNA_to_DNA);
            this.groupBox1.Controls.Add(this.btn_DNA_to_RNA);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter";
            // 
            // btn_RNA_to_DNA
            // 
            this.btn_RNA_to_DNA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_RNA_to_DNA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_RNA_to_DNA.FlatAppearance.BorderSize = 0;
            this.btn_RNA_to_DNA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RNA_to_DNA.Location = new System.Drawing.Point(381, 29);
            this.btn_RNA_to_DNA.Name = "btn_RNA_to_DNA";
            this.btn_RNA_to_DNA.Size = new System.Drawing.Size(149, 54);
            this.btn_RNA_to_DNA.TabIndex = 7;
            this.btn_RNA_to_DNA.Text = "mRNA  ->  DNA";
            this.btn_RNA_to_DNA.UseVisualStyleBackColor = false;
            this.btn_RNA_to_DNA.Click += new System.EventHandler(this.btn_RNA_to_DNA_Click);
            // 
            // btn_DNA_to_RNA
            // 
            this.btn_DNA_to_RNA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_DNA_to_RNA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_DNA_to_RNA.FlatAppearance.BorderSize = 0;
            this.btn_DNA_to_RNA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DNA_to_RNA.Location = new System.Drawing.Point(180, 29);
            this.btn_DNA_to_RNA.Name = "btn_DNA_to_RNA";
            this.btn_DNA_to_RNA.Size = new System.Drawing.Size(157, 54);
            this.btn_DNA_to_RNA.TabIndex = 4;
            this.btn_DNA_to_RNA.Text = "DNA  ->  mRNA";
            this.btn_DNA_to_RNA.UseVisualStyleBackColor = false;
            this.btn_DNA_to_RNA.Click += new System.EventHandler(this.btn_DNA_to_RNA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtmRNA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DNA to mRNA Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDNA;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtmRNA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DNA_to_RNA;
        private System.Windows.Forms.Button btn_RNA_to_DNA;
    }
}

