namespace WindowsFormsAppTA4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.TBJobDes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBJobTitle = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBContactNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ButtonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(37, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 37);
            this.textBox1.TabIndex = 38;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ButtonDel
            // 
            this.ButtonDel.Enabled = false;
            this.ButtonDel.Location = new System.Drawing.Point(1219, 144);
            this.ButtonDel.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(161, 79);
            this.ButtonDel.TabIndex = 37;
            this.ButtonDel.Text = "Delete";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // TBJobDes
            // 
            this.TBJobDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBJobDes.Location = new System.Drawing.Point(585, 162);
            this.TBJobDes.Margin = new System.Windows.Forms.Padding(6);
            this.TBJobDes.Name = "TBJobDes";
            this.TBJobDes.Size = new System.Drawing.Size(368, 37);
            this.TBJobDes.TabIndex = 36;
            this.TBJobDes.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(354, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 31);
            this.label7.TabIndex = 35;
            this.label7.Text = "Description";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(354, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 31);
            this.label6.TabIndex = 34;
            this.label6.Text = "Salary";
            this.label6.Visible = false;
            // 
            // TBSalary
            // 
            this.TBSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSalary.Location = new System.Drawing.Point(585, 109);
            this.TBSalary.Margin = new System.Windows.Forms.Padding(6);
            this.TBSalary.Name = "TBSalary";
            this.TBSalary.Size = new System.Drawing.Size(368, 37);
            this.TBSalary.TabIndex = 33;
            this.TBSalary.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(354, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "Job Title:";
            this.label5.Visible = false;
            // 
            // TBJobTitle
            // 
            this.TBJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBJobTitle.Location = new System.Drawing.Point(585, 60);
            this.TBJobTitle.Margin = new System.Windows.Forms.Padding(6);
            this.TBJobTitle.Name = "TBJobTitle";
            this.TBJobTitle.Size = new System.Drawing.Size(368, 37);
            this.TBJobTitle.TabIndex = 31;
            this.TBJobTitle.Visible = false;
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBEmail.Location = new System.Drawing.Point(585, 211);
            this.TBEmail.Margin = new System.Windows.Forms.Padding(6);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(368, 37);
            this.TBEmail.TabIndex = 30;
            this.TBEmail.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(360, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 29;
            this.label4.Text = "Email:";
            this.label4.Visible = false;
            // 
            // TBContactNumber
            // 
            this.TBContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBContactNumber.Location = new System.Drawing.Point(585, 162);
            this.TBContactNumber.Margin = new System.Windows.Forms.Padding(6);
            this.TBContactNumber.Name = "TBContactNumber";
            this.TBContactNumber.Size = new System.Drawing.Size(368, 37);
            this.TBContactNumber.TabIndex = 28;
            this.TBContactNumber.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(354, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "ContactNumber:";
            this.label3.Visible = false;
            // 
            // TBCompanyName
            // 
            this.TBCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBCompanyName.Location = new System.Drawing.Point(585, 109);
            this.TBCompanyName.Margin = new System.Windows.Forms.Padding(6);
            this.TBCompanyName.Name = "TBCompanyName";
            this.TBCompanyName.Size = new System.Drawing.Size(368, 37);
            this.TBCompanyName.TabIndex = 26;
            this.TBCompanyName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(354, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Company Name:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(354, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            this.label1.Visible = false;
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBName.Location = new System.Drawing.Point(585, 60);
            this.TBName.Margin = new System.Windows.Forms.Padding(6);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(368, 37);
            this.TBName.TabIndex = 23;
            this.TBName.Visible = false;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.AllowUserToResizeColumns = false;
            this.dataGridViewSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Location = new System.Drawing.Point(37, 99);
            this.dataGridViewSelect.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.ReadOnly = true;
            this.dataGridViewSelect.RowHeadersWidth = 72;
            this.dataGridViewSelect.Size = new System.Drawing.Size(248, 168);
            this.dataGridViewSelect.TabIndex = 22;
            this.dataGridViewSelect.SelectionChanged += new System.EventHandler(this.dataGridViewSelect_SelectionChanged);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(37, 312);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 72;
            this.dataGridViewMain.Size = new System.Drawing.Size(1343, 439);
            this.dataGridViewMain.TabIndex = 21;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.Location = new System.Drawing.Point(1037, 144);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(161, 79);
            this.ButtonAdd.TabIndex = 20;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 1151);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.TBJobDes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBJobTitle);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBContactNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.dataGridViewSelect);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.ButtonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.TextBox TBJobDes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBJobTitle;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBContactNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button ButtonAdd;
    }
}

