namespace Тест_по_МДК_01._01
{
    partial class Тестирование_по_МДК_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Тестирование_по_МДК_01));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.questionRichTextBox = new System.Windows.Forms.TextBox();
            this.firstradioButton = new System.Windows.Forms.RadioButton();
            this.secondradioButton = new System.Windows.Forms.RadioButton();
            this.thirdradioButton = new System.Windows.Forms.RadioButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testiruyuschiesya1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testiruyuschiesya1DataSet = new Тест_по_МДК_01._01.testiruyuschiesya1DataSet();
            this.студентыTableAdapter = new Тест_по_МДК_01._01.testiruyuschiesya1DataSetTableAdapters.СтудентыTableAdapter();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.answerButton);
            this.groupBox.Controls.Add(this.resultLabel);
            this.groupBox.Controls.Add(this.thirdradioButton);
            this.groupBox.Controls.Add(this.secondradioButton);
            this.groupBox.Controls.Add(this.firstradioButton);
            this.groupBox.Controls.Add(this.questionRichTextBox);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(609, 370);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // questionRichTextBox
            // 
            this.questionRichTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.questionRichTextBox.Multiline = true;
            this.questionRichTextBox.Name = "questionRichTextBox";
            this.questionRichTextBox.ReadOnly = true;
            this.questionRichTextBox.Size = new System.Drawing.Size(585, 105);
            this.questionRichTextBox.TabIndex = 0;
            // 
            // firstradioButton
            // 
            this.firstradioButton.AutoSize = true;
            this.firstradioButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstradioButton.Location = new System.Drawing.Point(34, 144);
            this.firstradioButton.Name = "firstradioButton";
            this.firstradioButton.Size = new System.Drawing.Size(99, 27);
            this.firstradioButton.TabIndex = 1;
            this.firstradioButton.TabStop = true;
            this.firstradioButton.Text = "Answer1";
            this.firstradioButton.UseVisualStyleBackColor = true;
            this.firstradioButton.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // secondradioButton
            // 
            this.secondradioButton.AutoSize = true;
            this.secondradioButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondradioButton.Location = new System.Drawing.Point(34, 188);
            this.secondradioButton.Name = "secondradioButton";
            this.secondradioButton.Size = new System.Drawing.Size(99, 27);
            this.secondradioButton.TabIndex = 1;
            this.secondradioButton.TabStop = true;
            this.secondradioButton.Text = "Answer2";
            this.secondradioButton.UseVisualStyleBackColor = true;
            this.secondradioButton.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // thirdradioButton
            // 
            this.thirdradioButton.AutoSize = true;
            this.thirdradioButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdradioButton.Location = new System.Drawing.Point(34, 233);
            this.thirdradioButton.Name = "thirdradioButton";
            this.thirdradioButton.Size = new System.Drawing.Size(99, 27);
            this.thirdradioButton.TabIndex = 1;
            this.thirdradioButton.TabStop = true;
            this.thirdradioButton.Text = "Answer3";
            this.thirdradioButton.UseVisualStyleBackColor = true;
            this.thirdradioButton.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(5, 332);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(604, 37);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "ResultLabel";
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerButton.Location = new System.Drawing.Point(254, 269);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(207, 46);
            this.answerButton.TabIndex = 3;
            this.answerButton.Text = "Ответить";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // Тестирование_по_МДК_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 370);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Тестирование_по_МДК_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование по МДК 01.01";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.testiruyuschiesya1DataSetBindingSource;
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
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // БД_тестирующихся
            //
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "БД_тестирующихся";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БД тестирующихся";
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiruyuschiesya1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testiruyuschiesya1DataSet)).EndInit();

        }

        #endregion

        private System.Windows.Forms.BindingSource testiruyuschiesya1DataSetBindingSource;
        private testiruyuschiesya1DataSet testiruyuschiesya1DataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private testiruyuschiesya1DataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton thirdradioButton;
        private System.Windows.Forms.RadioButton secondradioButton;
        private System.Windows.Forms.RadioButton firstradioButton;
        private System.Windows.Forms.TextBox questionRichTextBox;
    }
}