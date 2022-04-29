
namespace Kinoteatr
{
    partial class MainMenu
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
            this.toStatistic = new System.Windows.Forms.Button();
            this.toEditTickets = new System.Windows.Forms.Button();
            this.toSessions = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toStatistic
            // 
            this.toStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toStatistic.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.toStatistic.Location = new System.Drawing.Point(315, 496);
            this.toStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toStatistic.Name = "toStatistic";
            this.toStatistic.Size = new System.Drawing.Size(731, 75);
            this.toStatistic.TabIndex = 1;
            this.toStatistic.Text = "Показ статистики";
            this.toStatistic.UseVisualStyleBackColor = false;
            this.toStatistic.Click += new System.EventHandler(this.toStatistic_Click);
            // 
            // toEditTickets
            // 
            this.toEditTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toEditTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toEditTickets.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.toEditTickets.Location = new System.Drawing.Point(316, 416);
            this.toEditTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toEditTickets.Name = "toEditTickets";
            this.toEditTickets.Size = new System.Drawing.Size(730, 75);
            this.toEditTickets.TabIndex = 2;
            this.toEditTickets.Text = "Информация о билетах";
            this.toEditTickets.UseVisualStyleBackColor = false;
            this.toEditTickets.Click += new System.EventHandler(this.toEditTickets_Click);
            // 
            // toSessions
            // 
            this.toSessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toSessions.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.toSessions.Location = new System.Drawing.Point(315, 337);
            this.toSessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toSessions.Name = "toSessions";
            this.toSessions.Size = new System.Drawing.Size(731, 75);
            this.toSessions.TabIndex = 3;
            this.toSessions.Text = "Информация о сеансах";
            this.toSessions.UseVisualStyleBackColor = false;
            this.toSessions.Click += new System.EventHandler(this.toSessions_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(428, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 44);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Добро пожаловать!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(170, 90);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1115, 44);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Программа для \r\nбухгалтерского \r\nучета \"Кинотеатр\"";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(398, 247);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(580, 44);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Выберите нужный запрос";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1382, 581);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toSessions);
            this.Controls.Add(this.toEditTickets);
            this.Controls.Add(this.toStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1400, 628);
            this.MinimumSize = new System.Drawing.Size(1400, 628);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button toStatistic;
        private System.Windows.Forms.Button toEditTickets;
        private System.Windows.Forms.Button toSessions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

