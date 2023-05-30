namespace Lagi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Delete = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete });
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1063, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += OndataGridView1CellDoubleClick;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Delete.HeaderText = "";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 40);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 2;
            label1.Text = "NIM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Nama";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 6;
            label3.Text = "Alamat";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 27);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 40);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 8;
            label4.Text = "Tanggal Lahir";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(251, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 97);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 11;
            label5.Text = "Program Studi";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(251, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 28);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 157);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 14;
            label6.Text = "UKT";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(251, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(196, 27);
            textBox4.TabIndex = 13;
            textBox4.Text = "0";
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(480, 98);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 16;
            label7.Text = "Status";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(480, 123);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Active";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(619, 59);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 18;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(619, 104);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 19;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnButtonResetClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private CheckBox checkBox1;
        private Button button1;
        private DataGridViewTextBoxColumn Delete;
        private Button button2;
    }
}