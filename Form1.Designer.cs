namespace Matrix_Calc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_createMatrix = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rows = new System.Windows.Forms.Label();
            this.txt_Row1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Columns = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_Col2 = new System.Windows.Forms.TextBox();
            this.txt_row2 = new System.Windows.Forms.TextBox();
            this.Ans_Grid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ans_Grid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(225, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MintCream;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Location = new System.Drawing.Point(176, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 43);
            this.button6.TabIndex = 6;
            this.button6.Text = "Транспонировать";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_createMatrix
            // 
            this.btn_createMatrix.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_createMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_createMatrix.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_createMatrix.ForeColor = System.Drawing.Color.Red;
            this.btn_createMatrix.Location = new System.Drawing.Point(90, 5);
            this.btn_createMatrix.Name = "btn_createMatrix";
            this.btn_createMatrix.Size = new System.Drawing.Size(80, 43);
            this.btn_createMatrix.TabIndex = 18;
            this.btn_createMatrix.Text = "Создать";
            this.btn_createMatrix.UseVisualStyleBackColor = false;
            this.btn_createMatrix.Click += new System.EventHandler(this.btn_createMatrix_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btn_createMatrix);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Rows);
            this.panel1.Controls.Add(this.txt_Row1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Columns);
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 283);
            this.panel1.TabIndex = 7;
            // 
            // Rows
            // 
            this.Rows.AutoSize = true;
            this.Rows.Location = new System.Drawing.Point(0, 9);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(43, 13);
            this.Rows.TabIndex = 12;
            this.Rows.Text = "Строки";
            // 
            // txt_Row1
            // 
            this.txt_Row1.Location = new System.Drawing.Point(52, 5);
            this.txt_Row1.Name = "txt_Row1";
            this.txt_Row1.Size = new System.Drawing.Size(32, 20);
            this.txt_Row1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Столбцы";
            // 
            // txt_Columns
            // 
            this.txt_Columns.Location = new System.Drawing.Point(52, 28);
            this.txt_Columns.Name = "txt_Columns";
            this.txt_Columns.Size = new System.Drawing.Size(32, 20);
            this.txt_Columns.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.txt_Col2);
            this.panel2.Controls.Add(this.txt_row2);
            this.panel2.Location = new System.Drawing.Point(343, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 283);
            this.panel2.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MintCream;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Arial Narrow", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button8.Location = new System.Drawing.Point(176, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 41);
            this.button8.TabIndex = 7;
            this.button8.Text = "Транспонировать";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Столбцы";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(91, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 43);
            this.button5.TabIndex = 19;
            this.button5.Text = "Создать";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Строки";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(225, 213);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // txt_Col2
            // 
            this.txt_Col2.Location = new System.Drawing.Point(52, 28);
            this.txt_Col2.Name = "txt_Col2";
            this.txt_Col2.Size = new System.Drawing.Size(32, 20);
            this.txt_Col2.TabIndex = 15;
            // 
            // txt_row2
            // 
            this.txt_row2.Location = new System.Drawing.Point(52, 5);
            this.txt_row2.Name = "txt_row2";
            this.txt_row2.Size = new System.Drawing.Size(32, 20);
            this.txt_row2.TabIndex = 14;
            // 
            // Ans_Grid
            // 
            this.Ans_Grid.AllowDrop = true;
            this.Ans_Grid.AllowUserToAddRows = false;
            this.Ans_Grid.AllowUserToDeleteRows = false;
            this.Ans_Grid.ColumnHeadersVisible = false;
            this.Ans_Grid.Location = new System.Drawing.Point(177, 313);
            this.Ans_Grid.Name = "Ans_Grid";
            this.Ans_Grid.Size = new System.Drawing.Size(225, 213);
            this.Ans_Grid.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Minus);
            this.panel3.Controls.Add(this.btn_plus);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Location = new System.Drawing.Point(238, 77);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 230);
            this.panel3.TabIndex = 10;
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minus.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Minus.ForeColor = System.Drawing.Color.Black;
            this.btn_Minus.Location = new System.Drawing.Point(3, 58);
            this.btn_Minus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(96, 57);
            this.btn_Minus.TabIndex = 5;
            this.btn_Minus.Text = "Вычесть";
            this.btn_Minus.UseVisualStyleBackColor = false;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_plus.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus.ForeColor = System.Drawing.Color.Black;
            this.btn_plus.Location = new System.Drawing.Point(3, 2);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(96, 52);
            this.btn_plus.TabIndex = 4;
            this.btn_plus.Text = "Сложить";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Pink;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(3, 177);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 35);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(3, 119);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 54);
            this.button7.TabIndex = 2;
            this.button7.Text = "Умножить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(582, 533);
            this.Controls.Add(this.Ans_Grid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Матричный калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ans_Grid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView Ans_Grid;
        private System.Windows.Forms.TextBox txt_Row1;
        private System.Windows.Forms.TextBox txt_Columns;
        private System.Windows.Forms.Label Rows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Col2;
        private System.Windows.Forms.TextBox txt_row2;
        private System.Windows.Forms.Button btn_createMatrix;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}

