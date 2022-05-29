
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
            this.movieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hall_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonActiveText1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ActiveText1 = new System.Windows.Forms.TextBox();
            this.nonActiveText2 = new System.Windows.Forms.TextBox();
            this.ActiveText2 = new System.Windows.Forms.TextBox();
            this.nonActiveText3 = new System.Windows.Forms.TextBox();
            this.ActiveText3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.ToTickets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nonActiveText4 = new System.Windows.Forms.TextBox();
            this.ActiveText4 = new System.Windows.Forms.TextBox();
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
            this.movieTitle,
            this.hall_n,
            this.date_time,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(9, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(684, 419);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(684, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 419);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // date_time
            // 
            this.date_time.HeaderText = "Дата";
            this.date_time.MinimumWidth = 6;
            this.date_time.Name = "date_time";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время";
            this.Column1.Name = "Column1";
            // 
            // nonActiveText1
            // 
            this.nonActiveText1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nonActiveText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nonActiveText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonActiveText1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nonActiveText1.Location = new System.Drawing.Point(9, 10);
            this.nonActiveText1.Margin = new System.Windows.Forms.Padding(2);
            this.nonActiveText1.Name = "nonActiveText1";
            this.nonActiveText1.ReadOnly = true;
            this.nonActiveText1.Size = new System.Drawing.Size(189, 19);
            this.nonActiveText1.TabIndex = 2;
            this.nonActiveText1.Text = "Название фильма";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActiveText1
            // 
            this.ActiveText1.Location = new System.Drawing.Point(9, 33);
            this.ActiveText1.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveText1.Name = "ActiveText1";
            this.ActiveText1.Size = new System.Drawing.Size(142, 20);
            this.ActiveText1.TabIndex = 4;
            // 
            // nonActiveText2
            // 
            this.nonActiveText2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nonActiveText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nonActiveText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonActiveText2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nonActiveText2.Location = new System.Drawing.Point(156, 10);
            this.nonActiveText2.Margin = new System.Windows.Forms.Padding(2);
            this.nonActiveText2.Name = "nonActiveText2";
            this.nonActiveText2.ReadOnly = true;
            this.nonActiveText2.Size = new System.Drawing.Size(93, 19);
            this.nonActiveText2.TabIndex = 5;
            this.nonActiveText2.Text = "Номер зала";
            this.nonActiveText2.TextChanged += new System.EventHandler(this.nonActiveText2_TextChanged);
            // 
            // ActiveText2
            // 
            this.ActiveText2.Location = new System.Drawing.Point(155, 33);
            this.ActiveText2.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveText2.Name = "ActiveText2";
            this.ActiveText2.Size = new System.Drawing.Size(94, 20);
            this.ActiveText2.TabIndex = 6;
            // 
            // nonActiveText3
            // 
            this.nonActiveText3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nonActiveText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nonActiveText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonActiveText3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nonActiveText3.Location = new System.Drawing.Point(256, 10);
            this.nonActiveText3.Margin = new System.Windows.Forms.Padding(2);
            this.nonActiveText3.Name = "nonActiveText3";
            this.nonActiveText3.ReadOnly = true;
            this.nonActiveText3.Size = new System.Drawing.Size(146, 19);
            this.nonActiveText3.TabIndex = 7;
            this.nonActiveText3.Text = "Дата (гггг-мм-дд)";
            // 
            // ActiveText3
            // 
            this.ActiveText3.Location = new System.Drawing.Point(256, 33);
            this.ActiveText3.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveText3.Name = "ActiveText3";
            this.ActiveText3.Size = new System.Drawing.Size(146, 20);
            this.ActiveText3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(764, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 89);
            this.button2.TabIndex = 9;
            this.button2.Tag = "1";
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(850, 74);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 89);
            this.button3.TabIndex = 10;
            this.button3.Tag = "2";
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(938, 74);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 89);
            this.button4.TabIndex = 11;
            this.button4.Tag = "3";
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(1024, 74);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 89);
            this.button5.TabIndex = 12;
            this.button5.Tag = "4";
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(1112, 74);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 89);
            this.button6.TabIndex = 13;
            this.button6.Tag = "5";
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button7.Location = new System.Drawing.Point(764, 168);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 89);
            this.button7.TabIndex = 18;
            this.button7.Tag = "6";
            this.button7.Text = "0";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button8.Location = new System.Drawing.Point(850, 168);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 89);
            this.button8.TabIndex = 17;
            this.button8.Tag = "7";
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(938, 168);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 89);
            this.button9.TabIndex = 16;
            this.button9.Tag = "8";
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button10.Location = new System.Drawing.Point(1024, 168);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 89);
            this.button10.TabIndex = 15;
            this.button10.Tag = "9";
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button11.Location = new System.Drawing.Point(1112, 168);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 89);
            this.button11.TabIndex = 14;
            this.button11.Tag = "10";
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button12.Location = new System.Drawing.Point(764, 262);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 89);
            this.button12.TabIndex = 23;
            this.button12.Tag = "11";
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button13.Location = new System.Drawing.Point(850, 262);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 89);
            this.button13.TabIndex = 22;
            this.button13.Tag = "12";
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button14.Location = new System.Drawing.Point(938, 262);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 89);
            this.button14.TabIndex = 21;
            this.button14.Tag = "13";
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button15.Location = new System.Drawing.Point(1024, 262);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 89);
            this.button15.TabIndex = 20;
            this.button15.Tag = "14";
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button16.Location = new System.Drawing.Point(1112, 262);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(82, 89);
            this.button16.TabIndex = 19;
            this.button16.Tag = "15";
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button17.Location = new System.Drawing.Point(764, 357);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(82, 89);
            this.button17.TabIndex = 28;
            this.button17.Tag = "16";
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button18.Location = new System.Drawing.Point(850, 357);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(82, 89);
            this.button18.TabIndex = 27;
            this.button18.Tag = "17";
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button19.Location = new System.Drawing.Point(938, 357);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(82, 89);
            this.button19.TabIndex = 26;
            this.button19.Tag = "18";
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button20.Location = new System.Drawing.Point(1024, 357);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(82, 89);
            this.button20.TabIndex = 25;
            this.button20.Tag = "19";
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button21.Location = new System.Drawing.Point(1112, 357);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(82, 89);
            this.button21.TabIndex = 24;
            this.button21.Tag = "20";
            this.button21.Text = "0";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // ToTickets
            // 
            this.ToTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToTickets.Location = new System.Drawing.Point(827, 458);
            this.ToTickets.Margin = new System.Windows.Forms.Padding(2);
            this.ToTickets.Name = "ToTickets";
            this.ToTickets.Size = new System.Drawing.Size(302, 63);
            this.ToTickets.TabIndex = 29;
            this.ToTickets.Text = "Ознакомительная информация о билетах";
            this.ToTickets.UseVisualStyleBackColor = true;
            this.ToTickets.Visible = false;
            this.ToTickets.Click += new System.EventHandler(this.ToTickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(799, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Состояние билетов выбранного сеанса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(708, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ряд 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(708, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ряд 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(708, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ряд 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(708, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ряд 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(776, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Место 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(862, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Место 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(950, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Место 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(1036, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Место 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(1124, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Место 5";
            // 
            // nonActiveText4
            // 
            this.nonActiveText4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nonActiveText4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nonActiveText4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonActiveText4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.nonActiveText4.Location = new System.Drawing.Point(406, 12);
            this.nonActiveText4.Margin = new System.Windows.Forms.Padding(2);
            this.nonActiveText4.Name = "nonActiveText4";
            this.nonActiveText4.ReadOnly = true;
            this.nonActiveText4.Size = new System.Drawing.Size(113, 19);
            this.nonActiveText4.TabIndex = 40;
            this.nonActiveText4.Text = "Время (чч:мм)";
            // 
            // ActiveText4
            // 
            this.ActiveText4.Location = new System.Drawing.Point(406, 33);
            this.ActiveText4.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveText4.Name = "ActiveText4";
            this.ActiveText4.Size = new System.Drawing.Size(146, 20);
            this.ActiveText4.TabIndex = 41;
            // 
            // Sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1230, 537);
            this.Controls.Add(this.ActiveText4);
            this.Controls.Add(this.nonActiveText4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToTickets);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ActiveText3);
            this.Controls.Add(this.nonActiveText3);
            this.Controls.Add(this.ActiveText2);
            this.Controls.Add(this.nonActiveText2);
            this.Controls.Add(this.ActiveText1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nonActiveText1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1279, 576);
            this.MinimumSize = new System.Drawing.Size(1154, 576);
            this.Name = "Sessions";
            this.Text = "Sessions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nonActiveText1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ActiveText1;
        private System.Windows.Forms.TextBox nonActiveText2;
        private System.Windows.Forms.TextBox ActiveText2;
        private System.Windows.Forms.TextBox nonActiveText3;
        private System.Windows.Forms.TextBox ActiveText3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button ToTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn hall_n;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox nonActiveText4;
        private System.Windows.Forms.TextBox ActiveText4;
    }
}