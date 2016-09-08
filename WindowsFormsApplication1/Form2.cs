﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
       
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        public void Stoor(string fileName)
        {

            string x = System.IO.Directory.CreateDirectory(@"C:\test\" +fileName).ToString();
            string CsvFpath = @"C:\test\" + x + "\\" + fileName +".csv";
            try
            {
                System.IO.StreamWriter csvFileWriter = new StreamWriter(CsvFpath, false);

                string columnHeaderText = "";

                int countColumn = dataGridView1.ColumnCount - 1;

                if (countColumn >= 0)
                {
                    columnHeaderText = dataGridView1.Columns[0].HeaderText;
                }

                for (int i = 1; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + ';' + dataGridView1.Columns[i].HeaderText;
                }


                csvFileWriter.WriteLine(columnHeaderText);

                foreach (DataGridViewRow dataRowObject in dataGridView1.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";

                        dataFromGrid = dataRowObject.Cells[0].Value.ToString();

                        for (int i = 1; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + ';' + dataRowObject.Cells[i].Value.ToString();

                            
                        }
                        csvFileWriter.WriteLine(dataFromGrid);
                    }
                }
           


                csvFileWriter.Flush();
                csvFileWriter.Close();
            }
            catch (Exception exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }

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
            dataGridView1.DataSource = frm1.dtl;
           // frm1.PopulateTable();
            showInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Record frm3 = new Record();
            frm3.frm2 = this;
            frm3.Show();
        }

        private void showInfo()
        {

            label1.Text = "Name: " + frm1.name;
            label2.Text = "Number: " + frm1.number;
            label5.Text = "Module: " + frm1.module;
            label6.Text = "Group: " + frm1.group;
            label7.Text = "Assignment: " + frm1.assignment;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Stoor(frm1.number);

            dataGridView1.DataSource = frm1.PopulateTable(frm1.csvFile);
            
            frm1.nextStudent();
            frm1.getInfo();
            showInfo();
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm1.prevStudent();
            frm1.getInfo();
            showInfo();
        }

      

        private void listBox1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox3.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
        }
    }
}
