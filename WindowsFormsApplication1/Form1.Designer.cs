namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtMarksheet = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.classListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backChatDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backChatDataSet = new WindowsFormsApplication1.BackChatDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backChatDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classListTableAdapter = new WindowsFormsApplication1.BackChatDataSetTableAdapters.ClassListTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backChatDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backChatDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backChatDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assignment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marksheet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Greeting";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(162, 40);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(70, 20);
            this.txtAssignment.TabIndex = 12;
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(7, 40);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(70, 20);
            this.txtModule.TabIndex = 13;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(83, 40);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(70, 20);
            this.txtGroup.TabIndex = 14;
            // 
            // txtMarksheet
            // 
            this.txtMarksheet.Location = new System.Drawing.Point(240, 40);
            this.txtMarksheet.Name = "txtMarksheet";
            this.txtMarksheet.Size = new System.Drawing.Size(70, 20);
            this.txtMarksheet.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(391, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "End";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Class List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(19, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 271);
            this.panel1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 208);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(149, 245);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(64, 23);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button6_Click);
            // 
            // classListBindingSource
            // 
            this.classListBindingSource.DataMember = "ClassList";
            this.classListBindingSource.DataSource = this.backChatDataSetBindingSource1;
            // 
            // backChatDataSetBindingSource1
            // 
            this.backChatDataSetBindingSource1.DataSource = this.backChatDataSet;
            this.backChatDataSetBindingSource1.Position = 0;
            // 
            // backChatDataSet
            // 
            this.backChatDataSet.DataSetName = "BackChatDataSet";
            this.backChatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(488, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Upload";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMarksheet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGroup);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtModule);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAssignment);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 70);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assignment Information";
            // 
            // backChatDataSetBindingSource
            // 
            this.backChatDataSetBindingSource.DataSource = this.backChatDataSet;
            this.backChatDataSetBindingSource.Position = 0;
            // 
            // classListTableAdapter
            // 
            this.classListTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backChatDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backChatDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backChatDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtMarksheet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource backChatDataSetBindingSource1;
        private BackChatDataSet backChatDataSet;
        private System.Windows.Forms.BindingSource backChatDataSetBindingSource;
        private System.Windows.Forms.BindingSource classListBindingSource;
        private BackChatDataSetTableAdapters.ClassListTableAdapter classListTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

