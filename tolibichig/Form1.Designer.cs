namespace tolibichig
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
            label1 = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEng = new TextBox();
            txtMon = new TextBox();
            txtRus = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            button5 = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Хайх:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(44, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(352, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(329, 273);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(397, 58);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(184, 273);
            dataGridView2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 359);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 359);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Монгол";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 359);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Орос";
            // 
            // txtEng
            // 
            txtEng.Location = new Point(66, 356);
            txtEng.Name = "txtEng";
            txtEng.Size = new Size(100, 23);
            txtEng.TabIndex = 8;
            txtEng.TextChanged += txtEng_TextChanged;
            // 
            // txtMon
            // 
            txtMon.Location = new Point(253, 356);
            txtMon.Name = "txtMon";
            txtMon.Size = new Size(100, 23);
            txtMon.TabIndex = 9;
            txtMon.TextChanged += txtMon_TextChanged;
            // 
            // txtRus
            // 
            txtRus.Location = new Point(449, 356);
            txtRus.Name = "txtRus";
            txtRus.Size = new Size(100, 23);
            txtRus.TabIndex = 10;
            txtRus.TextChanged += txtRus_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(100, 400);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Засах";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(181, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(262, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Цэвэрлэх ";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(343, 400);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 15;
            button5.Text = "санах";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 15);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 16;
            label5.Text = "Хэл:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 359);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 17;
            label6.Text = "Англи";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtRus);
            Controls.Add(txtMon);
            Controls.Add(txtEng);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Гурван хэлний толь бичиг";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEng;
        private TextBox txtMon;
        private TextBox txtRus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button button5;
        private Label label5;
        private Label label6;
    }
}
