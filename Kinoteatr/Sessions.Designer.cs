
namespace Kinoteatr
{
    partial class Sessions
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sessionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hall_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonActiveText1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ActiveText1 = new System.Windows.Forms.TextBox();
            this.nonActiveText2 = new System.Windows.Forms.TextBox();
            this.ActiveText2 = new System.Windows.Forms.TextBox();
            this.nonActiveText3 = new System.Windows.Forms.TextBox();
            this.ActiveText3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionID,
            this.filmID,
            this.movieTitle,
            this.date_time,
            this.hall_n});
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1658, 516);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1658, 516);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1658, 516);
            this.dataGridView1.TabIndex = 0;
            // 
            // sessionID
            // 
            this.sessionID.HeaderText = "ID сеанса";
            this.sessionID.MinimumWidth = 6;
            this.sessionID.Name = "sessionID";
            // 
            // filmID
            // 
            this.filmID.HeaderText = "ID фильма";
            this.filmID.MinimumWidth = 6;
            this.filmID.Name = "filmID";
            // 
            // movieTitle
            // 
            this.movieTitle.HeaderText = "Название фильма";
            this.movieTitle.MinimumWidth = 6;
            this.movieTitle.Name = "movieTitle";
            // 
            // date_time
            // 
            this.date_time.HeaderText = "Дата и время";
            this.date_time.MinimumWidth = 6;
            this.date_time.Name = "date_time";
            // 
            // hall_n
            // 
            this.hall_n.HeaderText = "Номер зала";
            this.hall_n.MinimumWidth = 6;
            this.hall_n.Name = "hall_n";
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
            this.nonActiveText1.Size = new System.Drawing.Size(252, 23);
            this.nonActiveText1.TabIndex = 2;
            this.nonActiveText1.Text = "Название фильма";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActiveText1
            // 
            this.ActiveText1.Location = new System.Drawing.Point(12, 41);
            this.ActiveText1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveText1.Name = "ActiveText1";
            this.ActiveText1.Size = new System.Drawing.Size(252, 22);
            this.ActiveText1.TabIndex = 4;
            // 
            // nonActiveText2
            // 
            this.nonActiveText2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nonActiveText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nonActiveText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonActiveText2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nonActiveText2.Location = new System.Drawing.Point(285, 12);
            this.nonActiveText2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nonActiveText2.Name = "nonActiveText2";
            this.nonActiveText2.ReadOnly = true;
            this.nonActiveText2.Size = new System.Drawing.Size(124, 23);
            this.nonActiveText2.TabIndex = 5;
            this.nonActiveText2.Text = "Номер зала";
            // 
            // ActiveText2
            // 
            this.ActiveText2.Location = new System.Drawing.Point(285, 41);
            this.ActiveText2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveText2.Name = "ActiveText2";
            this.ActiveText2.Size = new System.Drawing.Size(124, 22);
            this.ActiveText2.TabIndex = 6;
            // 
            // nonActiveText3
            // 
            this.nonActiveText3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nonActiveText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nonActiveText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonActiveText3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nonActiveText3.Location = new System.Drawing.Point(427, 12);
            this.nonActiveText3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nonActiveText3.Name = "nonActiveText3";
            this.nonActiveText3.ReadOnly = true;
            this.nonActiveText3.Size = new System.Drawing.Size(375, 23);
            this.nonActiveText3.TabIndex = 7;
            this.nonActiveText3.Text = "Дата и время (гггг-мм-дд чч:мм:сс)";
            // 
            // ActiveText3
            // 
            this.ActiveText3.Location = new System.Drawing.Point(427, 41);
            this.ActiveText3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveText3.Name = "ActiveText3";
            this.ActiveText3.Size = new System.Drawing.Size(373, 22);
            this.ActiveText3.TabIndex = 8;
            // 
            // Sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1682, 653);
            this.Controls.Add(this.ActiveText3);
            this.Controls.Add(this.nonActiveText3);
            this.Controls.Add(this.ActiveText2);
            this.Controls.Add(this.nonActiveText2);
            this.Controls.Add(this.ActiveText1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nonActiveText1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1700, 700);
            this.MinimumSize = new System.Drawing.Size(1700, 700);
            this.Name = "Sessions";
            this.Text = "Sessions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn hall_n;
        private System.Windows.Forms.TextBox nonActiveText1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ActiveText1;
        private System.Windows.Forms.TextBox nonActiveText2;
        private System.Windows.Forms.TextBox ActiveText2;
        private System.Windows.Forms.TextBox nonActiveText3;
        private System.Windows.Forms.TextBox ActiveText3;
    }
}