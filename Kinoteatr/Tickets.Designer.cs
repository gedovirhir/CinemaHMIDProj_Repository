
namespace Kinoteatr
{
    partial class Tickets
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
            this.ActiveText6 = new System.Windows.Forms.TextBox();
            this.nonActiveText3 = new System.Windows.Forms.TextBox();
            this.ActiveText2 = new System.Windows.Forms.TextBox();
            this.nonActiveText2 = new System.Windows.Forms.TextBox();
            this.ActiveText1 = new System.Windows.Forms.TextBox();
            this.nonActiveText1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hall_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveText3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ActiveText4 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ActiveText5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveText6
            // 
            this.ActiveText6.Location = new System.Drawing.Point(837, 41);
            this.ActiveText6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveText6.Name = "ActiveText6";
            this.ActiveText6.Size = new System.Drawing.Size(371, 22);
            this.ActiveText6.TabIndex = 15;
            // 
            // nonActiveText3
            // 
            this.nonActiveText3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nonActiveText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nonActiveText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonActiveText3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nonActiveText3.Location = new System.Drawing.Point(837, 12);
            this.nonActiveText3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nonActiveText3.Name = "nonActiveText3";
            this.nonActiveText3.ReadOnly = true;
            this.nonActiveText3.Size = new System.Drawing.Size(372, 23);
            this.nonActiveText3.TabIndex = 14;
            this.nonActiveText3.Text = "Дата и время (гггг-мм-дд чч:мм:сс)";
            // 
            // ActiveText2
            // 
            this.ActiveText2.Location = new System.Drawing.Point(271, 41);
            this.ActiveText2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveText2.Name = "ActiveText2";
            this.ActiveText2.Size = new System.Drawing.Size(115, 22);
            this.ActiveText2.TabIndex = 13;
            // 
            // nonActiveText2
            // 
            this.nonActiveText2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nonActiveText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nonActiveText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonActiveText2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nonActiveText2.Location = new System.Drawing.Point(271, 12);
            this.nonActiveText2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nonActiveText2.Name = "nonActiveText2";
            this.nonActiveText2.ReadOnly = true;
            this.nonActiveText2.Size = new System.Drawing.Size(127, 23);
            this.nonActiveText2.TabIndex = 12;
            this.nonActiveText2.Text = "Номер зала";
            // 
            // ActiveText1
            // 
            this.ActiveText1.Location = new System.Drawing.Point(12, 41);
            this.ActiveText1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveText1.Name = "ActiveText1";
            this.ActiveText1.Size = new System.Drawing.Size(243, 22);
            this.ActiveText1.TabIndex = 11;
            // 
            // nonActiveText1
            // 
            this.nonActiveText1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nonActiveText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nonActiveText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonActiveText1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nonActiveText1.Location = new System.Drawing.Point(12, 12);
            this.nonActiveText1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nonActiveText1.Name = "nonActiveText1";
            this.nonActiveText1.ReadOnly = true;
            this.nonActiveText1.Size = new System.Drawing.Size(243, 23);
            this.nonActiveText1.TabIndex = 10;
            this.nonActiveText1.Text = "Название фильма";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmID,
            this.sessionID,
            this.movieTitle,
            this.hall_n,
            this.Column1,
            this.Column2,
            this.Column3,
            this.date_time});
            this.dataGridView1.Location = new System.Drawing.Point(3, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1600, 523);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1600, 523);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1600, 523);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // filmID
            // 
            this.filmID.HeaderText = "ID билета";
            this.filmID.MinimumWidth = 6;
            this.filmID.Name = "filmID";
            // 
            // sessionID
            // 
            this.sessionID.HeaderText = "ID сеанса";
            this.sessionID.MinimumWidth = 6;
            this.sessionID.Name = "sessionID";
            // 
            // movieTitle
            // 
            this.movieTitle.HeaderText = "Название фильма";
            this.movieTitle.MinimumWidth = 6;
            this.movieTitle.Name = "movieTitle";
            // 
            // hall_n
            // 
            this.hall_n.HeaderText = "Номер зала";
            this.hall_n.MinimumWidth = 6;
            this.hall_n.Name = "hall_n";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер ряда";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер места";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // date_time
            // 
            this.date_time.HeaderText = "Дата и время";
            this.date_time.MinimumWidth = 6;
            this.date_time.Name = "date_time";
            // 
            // ActiveText3
            // 
            this.ActiveText3.Location = new System.Drawing.Point(403, 41);
            this.ActiveText3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveText3.Name = "ActiveText3";
            this.ActiveText3.Size = new System.Drawing.Size(115, 22);
            this.ActiveText3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(403, 12);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 23);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Номер ряда";
            // 
            // ActiveText4
            // 
            this.ActiveText4.Location = new System.Drawing.Point(533, 41);
            this.ActiveText4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveText4.Name = "ActiveText4";
            this.ActiveText4.Size = new System.Drawing.Size(136, 22);
            this.ActiveText4.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox4.Location = new System.Drawing.Point(533, 12);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(136, 23);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "Номер места";
            // 
            // ActiveText5
            // 
            this.ActiveText5.Location = new System.Drawing.Point(685, 41);
            this.ActiveText5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveText5.Name = "ActiveText5";
            this.ActiveText5.Size = new System.Drawing.Size(136, 22);
            this.ActiveText5.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox6.Location = new System.Drawing.Point(685, 12);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(136, 23);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "Цена";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1239, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 49);
            this.button1.TabIndex = 22;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1682, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ActiveText5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ActiveText4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ActiveText3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ActiveText6);
            this.Controls.Add(this.nonActiveText3);
            this.Controls.Add(this.ActiveText2);
            this.Controls.Add(this.nonActiveText2);
            this.Controls.Add(this.ActiveText1);
            this.Controls.Add(this.nonActiveText1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1700, 700);
            this.MinimumSize = new System.Drawing.Size(1700, 700);
            this.Name = "Tickets";
            this.Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ActiveText6;
        private System.Windows.Forms.TextBox nonActiveText3;
        private System.Windows.Forms.TextBox ActiveText2;
        private System.Windows.Forms.TextBox nonActiveText2;
        private System.Windows.Forms.TextBox ActiveText1;
        private System.Windows.Forms.TextBox nonActiveText1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ActiveText3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ActiveText4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox ActiveText5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn hall_n;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
    }
}