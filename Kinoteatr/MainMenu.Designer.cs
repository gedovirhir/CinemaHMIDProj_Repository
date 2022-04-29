
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
            this.SuspendLayout();
            // 
            // toStatistic
            // 
            this.toStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toStatistic.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.toStatistic.Location = new System.Drawing.Point(9, 401);
            this.toStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.toStatistic.Name = "toStatistic";
            this.toStatistic.Size = new System.Drawing.Size(548, 61);
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
            this.toEditTickets.Location = new System.Drawing.Point(9, 336);
            this.toEditTickets.Margin = new System.Windows.Forms.Padding(2);
            this.toEditTickets.Name = "toEditTickets";
            this.toEditTickets.Size = new System.Drawing.Size(548, 61);
            this.toEditTickets.TabIndex = 2;
            this.toEditTickets.Text = "Переход к редактированию билетов";
            this.toEditTickets.UseVisualStyleBackColor = false;
            this.toEditTickets.Click += new System.EventHandler(this.toEditTickets_Click);
            // 
            // toSessions
            // 
            this.toSessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toSessions.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.toSessions.Location = new System.Drawing.Point(9, 270);
            this.toSessions.Margin = new System.Windows.Forms.Padding(2);
            this.toSessions.Name = "toSessions";
            this.toSessions.Size = new System.Drawing.Size(548, 61);
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
            this.textBox1.Location = new System.Drawing.Point(75, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 36);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Приложение \"Кинотеатр\"";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(566, 472);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toSessions);
            this.Controls.Add(this.toEditTickets);
            this.Controls.Add(this.toStatistic);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

