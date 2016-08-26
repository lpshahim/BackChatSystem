using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
       
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        //datagridview access
        private string ColumnName { get; set; }
        private string CellValue { get; set; }

        public Form2(string columnName, string cellValue)
        {
            this.ColumnName = columnName;
            this.CellValue = cellValue;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.label19.Text = string.Format("ColumnName = {0} And Value = {1}", this.ColumnName, this.CellValue);
            label19.Text = "JOU MAAAAAA";
            label1.Text = "Name: " + frm1.name;
            label2.Text = "Number: " + frm1.number;
            label5.Text = "Module: " + frm1.module;
            label6.Text = "Group: " + frm1.group;
            label7.Text = "Assignment: " + frm1.assignment;
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm1.aaa();
            frm1.navigateForms(); 
        }
    }
}
