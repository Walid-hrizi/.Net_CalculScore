namespace Calcul_de_score
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.heure = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prenText = new System.Windows.Forms.TextBox();
            this.nomText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telText = new System.Windows.Forms.TextBox();
            this.cinText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.femRadio = new System.Windows.Forms.RadioButton();
            this.mascRadio = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.diplomCheck = new System.Windows.Forms.CheckBox();
            this.motivCheck = new System.Windows.Forms.CheckBox();
            this.experCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chanceText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CIN = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "calcul de score";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.heure);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(481, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(701, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // heure
            // 
            this.heure.AutoSize = true;
            this.heure.Location = new System.Drawing.Point(298, 61);
            this.heure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heure.Name = "heure";
            this.heure.Size = new System.Drawing.Size(83, 31);
            this.heure.TabIndex = 1;
            this.heure.Text = "heure";
            this.heure.Click += new System.EventHandler(this.label3_Click);
            // 
            // date
            // 
            this.date.AccessibleName = "date";
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(54, 61);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(57, 28);
            this.date.TabIndex = 0;
            this.date.Text = "date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prenText);
            this.groupBox2.Controls.Add(this.nomText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.telText);
            this.groupBox2.Controls.Add(this.cinText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 198);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1164, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // prenText
            // 
            this.prenText.Location = new System.Drawing.Point(777, 123);
            this.prenText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prenText.Name = "prenText";
            this.prenText.Size = new System.Drawing.Size(298, 41);
            this.prenText.TabIndex = 7;
            // 
            // nomText
            // 
            this.nomText.Location = new System.Drawing.Point(777, 59);
            this.nomText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(298, 41);
            this.nomText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "prénom";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AccessibleName = "date";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nom";
            // 
            // telText
            // 
            this.telText.Location = new System.Drawing.Point(145, 125);
            this.telText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telText.Name = "telText";
            this.telText.Size = new System.Drawing.Size(298, 41);
            this.telText.TabIndex = 3;
            this.telText.TextChanged += new System.EventHandler(this.telText_TextChanged);
            // 
            // cinText
            // 
            this.cinText.Location = new System.Drawing.Point(145, 61);
            this.cinText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cinText.MaxLength = 8;
            this.cinText.Name = "cinText";
            this.cinText.Size = new System.Drawing.Size(298, 41);
            this.cinText.TabIndex = 2;
            this.cinText.TextChanged += new System.EventHandler(this.cinText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tél";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AccessibleName = "date";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "CIN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(132, 432);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(460, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Note";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(190, 106);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(220, 38);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "0";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(190, 42);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(220, 38);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "0";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            this.textBox6.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Technique";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AccessibleName = "date";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "langue";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.femRadio);
            this.groupBox4.Controls.Add(this.mascRadio);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(744, 432);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(342, 181);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexe";
            // 
            // femRadio
            // 
            this.femRadio.AutoSize = true;
            this.femRadio.Location = new System.Drawing.Point(124, 108);
            this.femRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.femRadio.Name = "femRadio";
            this.femRadio.Size = new System.Drawing.Size(141, 35);
            this.femRadio.TabIndex = 1;
            this.femRadio.TabStop = true;
            this.femRadio.Text = "Féminin";
            this.femRadio.UseVisualStyleBackColor = true;
            // 
            // mascRadio
            // 
            this.mascRadio.AutoSize = true;
            this.mascRadio.Location = new System.Drawing.Point(124, 48);
            this.mascRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mascRadio.Name = "mascRadio";
            this.mascRadio.Size = new System.Drawing.Size(152, 35);
            this.mascRadio.TabIndex = 0;
            this.mascRadio.TabStop = true;
            this.mascRadio.Text = "Masculin";
            this.mascRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.diplomCheck);
            this.groupBox5.Controls.Add(this.motivCheck);
            this.groupBox5.Controls.Add(this.experCheck);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(132, 660);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(954, 181);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bonus";
            // 
            // diplomCheck
            // 
            this.diplomCheck.AutoSize = true;
            this.diplomCheck.Location = new System.Drawing.Point(728, 75);
            this.diplomCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.diplomCheck.Name = "diplomCheck";
            this.diplomCheck.Size = new System.Drawing.Size(159, 35);
            this.diplomCheck.TabIndex = 2;
            this.diplomCheck.Text = "Diplomes";
            this.diplomCheck.UseVisualStyleBackColor = true;
            // 
            // motivCheck
            // 
            this.motivCheck.AutoSize = true;
            this.motivCheck.Location = new System.Drawing.Point(440, 75);
            this.motivCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.motivCheck.Name = "motivCheck";
            this.motivCheck.Size = new System.Drawing.Size(170, 35);
            this.motivCheck.TabIndex = 1;
            this.motivCheck.Text = "Motivation";
            this.motivCheck.UseVisualStyleBackColor = true;
            // 
            // experCheck
            // 
            this.experCheck.AutoSize = true;
            this.experCheck.Location = new System.Drawing.Point(68, 75);
            this.experCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.experCheck.Name = "experCheck";
            this.experCheck.Size = new System.Drawing.Size(365, 35);
            this.experCheck.TabIndex = 0;
            this.experCheck.Text = "Experience Profissionnelle";
            this.experCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 919);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Age";
            // 
            // ageComboBox
            // 
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "20-30",
            "30-40",
            ">40"});
            this.ageComboBox.Location = new System.Drawing.Point(214, 914);
            this.ageComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(180, 33);
            this.ageComboBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 916);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 31);
            this.label10.TabIndex = 11;
            this.label10.Text = "Valeur de chance";
            // 
            // chanceText
            // 
            this.chanceText.Location = new System.Drawing.Point(703, 916);
            this.chanceText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chanceText.Name = "chanceText";
            this.chanceText.ReadOnly = true;
            this.chanceText.Size = new System.Drawing.Size(220, 31);
            this.chanceText.TabIndex = 8;
            this.chanceText.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(962, 916);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Générer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(106, 994);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(1030, 133);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(806, 61);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 36);
            this.button5.TabIndex = 16;
            this.button5.Text = "Quitter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(574, 61);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 36);
            this.button4.TabIndex = 15;
            this.button4.Text = "Ajouter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 61);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Calculer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 61);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Initialiser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 1185);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 53);
            this.label11.TabIndex = 13;
            this.label11.Text = " score";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // scoreText
            // 
            this.scoreText.ForeColor = System.Drawing.Color.DarkGreen;
            this.scoreText.Location = new System.Drawing.Point(46, 1261);
            this.scoreText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scoreText.Name = "scoreText";
            this.scoreText.ReadOnly = true;
            this.scoreText.Size = new System.Drawing.Size(220, 31);
            this.scoreText.TabIndex = 14;
            this.scoreText.Text = "0";
            this.scoreText.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listBox4);
            this.groupBox7.Controls.Add(this.listBox3);
            this.groupBox7.Controls.Add(this.listBox2);
            this.groupBox7.Controls.Add(this.listBox1);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.CIN);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(334, 1169);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(802, 308);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Liste de personnes";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 31;
            this.listBox4.Location = new System.Drawing.Point(648, 92);
            this.listBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(130, 128);
            this.listBox4.TabIndex = 23;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 31;
            this.listBox3.Location = new System.Drawing.Point(448, 92);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(130, 128);
            this.listBox3.TabIndex = 22;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(224, 92);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(138, 128);
            this.listBox2.TabIndex = 21;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(32, 92);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 128);
            this.listBox1.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(672, 44);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 31);
            this.label15.TabIndex = 19;
            this.label15.Text = "Score";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(480, 44);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 31);
            this.label14.TabIndex = 18;
            this.label14.Text = "Prénom";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 31);
            this.label13.TabIndex = 17;
            this.label13.Text = "Nom";
            // 
            // CIN
            // 
            this.CIN.AutoSize = true;
            this.CIN.Location = new System.Drawing.Point(80, 44);
            this.CIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(62, 31);
            this.CIN.TabIndex = 16;
            this.CIN.Text = "CIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 1559);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chanceText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label heure;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prenText;
        private System.Windows.Forms.TextBox nomText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telText;
        private System.Windows.Forms.TextBox cinText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox diplomCheck;
        private System.Windows.Forms.CheckBox motivCheck;
        private System.Windows.Forms.CheckBox experCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox chanceText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox scoreText;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CIN;
        private System.Windows.Forms.RadioButton femRadio;
        private System.Windows.Forms.RadioButton mascRadio;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

