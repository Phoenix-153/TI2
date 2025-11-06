namespace PizzaInterface
{
    partial class Form2
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listView2 = new ListView();
            Menge = new ColumnHeader();
            Pizza = new ColumnHeader();
            Preis = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            listBox2 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(824, 621);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 0;
            button1.Text = "Bestellen";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 628);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { Menge, Pizza, Preis });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(498, 69);
            listView2.Margin = new Padding(4, 5, 4, 5);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(433, 438);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // Menge
            // 
            Menge.Text = "Menge";
            Menge.Width = 100;
            // 
            // Pizza
            // 
            Pizza.Text = "Pizza";
            Pizza.Width = 220;
            // 
            // Preis
            // 
            Preis.Text = "Preis";
            Preis.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 5;
            label2.Text = "Bestellung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 583);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(232, 25);
            label3.TabIndex = 6;
            label3.Text = "Bitte Lieferadresse Eingeben";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 105);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 8;
            label4.Text = "Pizza auswählen";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(34, 135);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(170, 154);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 29);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "28cm";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(211, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(131, 181);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Größe ";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 100);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(81, 29);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "40cm";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 29);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "32cm";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(153, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(152, 223);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 105);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 13;
            label6.Text = "Menge";
            label6.Click += label6_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(348, 135);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 31);
            numericUpDown1.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(250, 448);
            button2.Name = "button2";
            button2.Size = new Size(223, 34);
            button2.TabIndex = 15;
            button2.Text = "Pizza Hinzufügen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(781, 521);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 521);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 17;
            label5.Text = "Gesamtpreis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 482);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 18;
            label7.Text = "Rabattcode";
            label7.Click += label7_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 515);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 19;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(34, 295);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.MultiSimple;
            listBox2.Size = new Size(170, 129);
            listBox2.TabIndex = 25;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 675);
            Controls.Add(listBox2);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ListView listView2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private GroupBox groupBox2;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private TextBox textBox2;
        private Label label5;
        private ColumnHeader Menge;
        private ColumnHeader Pizza;
        private ColumnHeader Preis;
        private Label label7;
        private TextBox textBox3;
        private ListBox listBox2;
    }
}