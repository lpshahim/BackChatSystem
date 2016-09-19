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
    public partial class Form1 : Form
    {

        public Form2 frm2;
        //public access to datagridview
        public DataGridView DGV { get; set; }
       public DataTable dtl { get; set; }

        public void navigateForms()
        {
          frm2 = new Form2();
            frm2.frm1 = this;
            frm2.Show();
        }

        public string name;
        public string number;
        public string module;
        public string group;
        public string assignment;
        public string csvFile;
        public Form1()
        {
            InitializeComponent();
            BindGridView();
            CreateFolder(@"C:\BackChat\");
            CreateFolder(@"C:\BackChat\Recordings");
            CreateFolder(@"C:\BackChat\Recordings\Default");
        }
        public void CreateFolder(string subPath)
        {
            bool exists = System.IO.Directory.Exists(subPath);

            if (!exists)
                System.IO.Directory.CreateDirectory(subPath);
        }
        private void BindGridView()
        {
            using (DataTable dt = new DataTable())
            {
                dataGridView1.DataSource = dt;
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            CreateFolder(@"C:\BackChat\ClassList");
            string classList = "";
            openFileDialog1.InitialDirectory = @"C:\Documents";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                classList = openFileDialog1.FileName;
                string[] str = File.ReadAllLines(classList);

             

                DataTable dt = new DataTable();
               

                string[] temp = str[0].Split(';');

                foreach (string t in temp)
                {
                    dt.Columns.Add(t, typeof(string));
                }

                for (int i = 1; i < str.Length; i++)
                {
                    string[] t = str[i].Split(';');
                    dt.Rows.Add(t);

                }

                dataGridView1.DataSource = dt;

            }
            Form2 frm2 = new Form2();

            string fileName = Path.GetFileName(classList);
            string path = @"C:\BackChat\ClassList\" + fileName;
            frm2.Save(path, dataGridView1);



        }

        public void getInfo()
        {
            module = txtModule.Text;
            group = txtGroup.Text;
            assignment = txtAssignment.Text;
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            name = Convert.ToString(selectedRow.Cells["Name"].Value);
            number = Convert.ToString(selectedRow.Cells["Student nr"].Value);
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            getInfo();
            navigateForms();


        }
        
        public DataTable PopulateTable(string csvFile)
        {
           
            string[] str = File.ReadAllLines(csvFile);

            csvFile = Path.GetFileNameWithoutExtension(csvFile);

            txtMarksheet.Text = csvFile;

            DataTable dt = new DataTable();

            string[] temp = str[0].Split(';');

            foreach (string t in temp)
            {
                dt.Columns.Add(t, typeof(string));
            }

            for (int i = 1; i < str.Length; i++)
            {
                string[] t = str[i].Split(';');
                dt.Rows.Add(t);

            }
            return dt;
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.InitialDirectory = @"C:\Documents";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                csvFile = openFileDialog1.FileName;
                dtl = PopulateTable(csvFile);
            }
        }
        
     
        int nRow;
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (nRow <= dataGridView1.RowCount)
            {
                dataGridView1.Rows[nRow].Selected = false;
                dataGridView1.Rows[++nRow].Selected = true;
            }
        }

        public void nextStudent()
        {
            nRow = dataGridView1.CurrentCell.RowIndex;
            if (nRow <= dataGridView1.RowCount)
            {
                dataGridView1.Rows[nRow].Selected = false;
                dataGridView1.Rows[++nRow].Selected = true;
            }
        }

        int iRow;
        public void prevStudent()
        {
            iRow = dataGridView1.CurrentCell.RowIndex;
            if (nRow <= dataGridView1.RowCount)
            {
                dataGridView1.Rows[iRow].Selected = false;
                dataGridView1.Rows[--nRow].Selected = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
