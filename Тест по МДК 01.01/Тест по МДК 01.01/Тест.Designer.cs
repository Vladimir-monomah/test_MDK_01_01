namespace Тест_по_МДК_01._01
{
    partial class Тест
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Тест));
            this.button1 = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.groupNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(87, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(101, 34);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(269, 20);
            this.userNameTextBox.TabIndex = 4;
            this.userNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTextBox_KeyPress);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(63, 37);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(32, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "Имя:";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(12, 84);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(83, 13);
            this.groupLabel.TabIndex = 5;
            this.groupLabel.Text = "Номер группы:";
            // 
            // groupNumericUpDown1
            // 
            this.groupNumericUpDown1.Location = new System.Drawing.Point(101, 82);
            this.groupNumericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.groupNumericUpDown1.Name = "groupNumericUpDown1";
            this.groupNumericUpDown1.Size = new System.Drawing.Size(269, 20);
            this.groupNumericUpDown1.TabIndex = 7;
            this.groupNumericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupNumericUpDown1_KeyPress);
            // 
            // Тест
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 270);
            this.Controls.Add(this.groupNumericUpDown1);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Тест";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.groupNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.NumericUpDown groupNumericUpDown1;
    }
}