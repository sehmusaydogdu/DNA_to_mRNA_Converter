using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNA_to_MRNA_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // T in the RNA sequence is turning to U.
        private void DNA_To_mRNA_Converter(string value)
        {
            txtmRNA.Text = value.Replace('T', 'U');
        }

        //DNA integration
        private void DNA_Integration(string value)
        {
            foreach (char item in value)
            {
                switch (item)
                {
                    case 'A':txtmRNA.Text += 'T';break;
                    case 'T':txtmRNA.Text += 'A';break;
                    case 'C':txtmRNA.Text += 'G';break;
                    case 'G':txtmRNA.Text += 'C';break;
                }
            }
            DNA_To_mRNA_Converter(txtmRNA.Text);
        }

        // U in the DNA sequence is turning to T.
        private void mRNA_To_DNA_Converter(string value)
        {
            txtDNA.Text = value.Replace('U', 'T');
        }

        //Checking for DNA. DNA U can not be found.
        private bool IsStatusDNA(string value) => value.Contains<char>('U')?false:true;

        //Checking for RNA. RNA T can not be found.
        private bool IsStatusRNA(string value)=>value.Contains<char>('T')?false:true;

        
        private void btn_DNA_to_RNA_Click(object sender, EventArgs e)
        {
            txtDNA.Text=txtDNA.Text.ToUpper();
            txtmRNA.Clear();

            //Selection Control
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (string.IsNullOrEmpty(txtDNA.Text))
                    MessageBox.Show("Please enter the DNA sequence.");

                else
                {
                    if (IsStatusDNA(txtDNA.Text))
                    {
                        txtmRNA.Clear();
                        if (radioButton1.Checked)
                            DNA_To_mRNA_Converter(txtDNA.Text);

                        if (radioButton2.Checked)
                            DNA_Integration(txtDNA.Text);
                    }
                    else
                        MessageBox.Show("There is not U in the DNA");
                }
            }
            else
                MessageBox.Show("Make your choice");
        }

        private void btn_RNA_to_DNA_Click(object sender, EventArgs e)
        {
            txtmRNA.Text = txtmRNA.Text.ToUpper();
            txtDNA.Clear();

            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (string.IsNullOrEmpty(txtmRNA.Text))
                    MessageBox.Show("Please enter the RNA sequence.");
                else
                {
                    if (IsStatusRNA(txtmRNA.Text))
                    {
                        txtDNA.Clear();
                        if (radioButton1.Checked)
                            mRNA_To_DNA_Converter(txtmRNA.Text);

                        if (radioButton2.Checked)
                            MessageBox.Show("Does not go RNA 3-5");
                    }
                    else
                        MessageBox.Show("There is not T in the RNA");
                }
            }
            else
                MessageBox.Show("Make your choice");
        }
    }
}
