namespace Тест_по_МДК_01._01
{
    partial class БД_тестирующихся
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.студентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testiruyuschiesya1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testiruyuschiesya1DataSet = new Тест_по_МДК_01._01.testiruyuschiesya1DataSet();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new Тест_по_МДК_01._01.testiruyuschiesya1DataSetTableAdapters.СтудентыTableAdapter();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерГруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiruyuschiesya1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiruyuschiesya1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.номерГруппыDataGridViewTextBoxColumn,
            this.оценкаDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.студентыBindingSource1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(344, 370);
            this.dataGridView.TabIndex = 0;
            // 
            // студентыBindingSource1
            // 
            this.студентыBindingSource1.DataMember = "Студенты";
            this.студентыBindingSource1.DataSource = this.testiruyuschiesya1DataSetBindingSource;
            // 
            // testiruyuschiesya1DataSetBindingSource
            // 
            this.testiruyuschiesya1DataSetBindingSource.DataSource = this.testiruyuschiesya1DataSet;
            this.testiruyuschiesya1DataSetBindingSource.Position = 0;
            // 
            // testiruyuschiesya1DataSet
            // 
            this.testiruyuschiesya1DataSet.DataSetName = "testiruyuschiesya1DataSet";
            this.testiruyuschiesya1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.testiruyuschiesya1DataSet;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // номерГруппыDataGridViewTextBoxColumn
            // 
            this.номерГруппыDataGridViewTextBoxColumn.DataPropertyName = "номер группы";
            this.номерГруппыDataGridViewTextBoxColumn.HeaderText = "номер группы";
            this.номерГруппыDataGridViewTextBoxColumn.Name = "номерГруппыDataGridViewTextBoxColumn";
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            // 
            // БД_тестирующихся
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 370);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "БД_тестирующихся";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БД тестирующихся";
            this.Load += new System.EventHandler(this.БД_тестирующихся_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiruyuschiesya1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiruyuschiesya1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource testiruyuschiesya1DataSetBindingSource;
        private testiruyuschiesya1DataSet testiruyuschiesya1DataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private testiruyuschiesya1DataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private System.Windows.Forms.BindingSource студентыBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерГруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
    }
}