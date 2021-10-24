
using System;
using System.Windows.Forms;

namespace ProductManager
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
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFirstEfDataSet = new ProductManager.DbFirstEfDataSet();
            this.productTableAdapter = new ProductManager.DbFirstEfDataSetTableAdapters.ProductTableAdapter();
            this.tBoxCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.listBoxProductsList = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteSelectedData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFirstEfDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "name";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(51, 12);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(100, 20);
            this.tBoxName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridViewProducts.DataSource = this.productBindingSource;
            this.dataGridViewProducts.Location = new System.Drawing.Point(257, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(434, 94);
            this.dataGridViewProducts.TabIndex = 5;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProducts_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dbFirstEfDataSet;
            // 
            // dbFirstEfDataSet
            // 
            this.dbFirstEfDataSet.DataSetName = "DbFirstEfDataSet";
            this.dbFirstEfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tBoxCount
            // 
            this.tBoxCount.Location = new System.Drawing.Point(51, 38);
            this.tBoxCount.Name = "tBoxCount";
            this.tBoxCount.Size = new System.Drawing.Size(100, 20);
            this.tBoxCount.TabIndex = 7;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(11, 38);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(34, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "count";
            // 
            // listBoxProductsList
            // 
            this.listBoxProductsList.DisplayMember = "name";
            this.listBoxProductsList.FormattingEnabled = true;
            this.listBoxProductsList.Items.AddRange(new object[] {
            "name"});
            this.listBoxProductsList.Location = new System.Drawing.Point(257, 112);
            this.listBoxProductsList.Name = "listBoxProductsList";
            this.listBoxProductsList.Size = new System.Drawing.Size(177, 121);
            this.listBoxProductsList.TabIndex = 8;
            this.listBoxProductsList.ValueMember = "name";
            // 
            // btnDelete
            // 
            this.btnDelete.AllowDrop = true;
            this.btnDelete.Location = new System.Drawing.Point(51, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tBoxId
            // 
            this.tBoxId.AllowDrop = true;
            this.tBoxId.Location = new System.Drawing.Point(51, 112);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.Size = new System.Drawing.Size(100, 20);
            this.tBoxId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "id";
            // 
            // btnDeleteSelectedData
            // 
            this.btnDeleteSelectedData.AllowDrop = true;
            this.btnDeleteSelectedData.Location = new System.Drawing.Point(711, 31);
            this.btnDeleteSelectedData.Name = "btnDeleteSelectedData";
            this.btnDeleteSelectedData.Size = new System.Drawing.Size(81, 75);
            this.btnDeleteSelectedData.TabIndex = 12;
            this.btnDeleteSelectedData.Text = "Delete Selected Data";
            this.btnDeleteSelectedData.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedData.Click += new System.EventHandler(this.btnDeleteSelectedData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(877, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "id";
            // 
            // txtId
            // 
            this.txtId.AllowDrop = true;
            this.txtId.Location = new System.Drawing.Point(931, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 22;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(931, 104);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(877, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "count";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(931, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(878, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "name";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1101, 304);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteSelectedData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBoxProductsList);
            this.Controls.Add(this.tBoxCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFirstEfDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        // private System.Windows.Forms.Label 
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private DbFirstEfDataSet dbFirstEfDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DbFirstEfDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tBoxCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox listBoxProductsList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteSelectedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
    }
}

