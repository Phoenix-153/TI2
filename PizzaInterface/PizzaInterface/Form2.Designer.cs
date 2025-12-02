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
            b_bestellen = new Button();
            label1 = new Label();
            listView2 = new ListView();
            Menge = new ColumnHeader();
            Pizza = new ColumnHeader();
            Größe = new ColumnHeader();
            Extras = new ColumnHeader();
            Preis = new ColumnHeader();
            label2 = new Label();
            label4 = new Label();
            lb_Pizzaauswahl = new ListBox();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            label6 = new Label();
            nUD_Mengenauswahl = new NumericUpDown();
            b_pizzaHinzufügen = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            lb_extrazutaten = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Mengenauswahl).BeginInit();
            SuspendLayout();
            // 
            // b_bestellen
            // 
            b_bestellen.Location = new Point(806, 373);
            b_bestellen.Name = "b_bestellen";
            b_bestellen.Size = new Size(75, 23);
            b_bestellen.TabIndex = 0;
            b_bestellen.Text = "Bestellen";
            b_bestellen.UseVisualStyleBackColor = true;
            b_bestellen.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { Menge, Pizza, Größe, Extras, Preis });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(336, 41);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(545, 264);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // Menge
            // 
            Menge.Text = "Menge";
            // 
            // Pizza
            // 
            Pizza.Text = "Pizza";
            Pizza.Width = 180;
            // 
            // Größe
            // 
            Größe.Text = "Größe";
            // 
            // Extras
            // 
            Extras.Text = "Extras";
            Extras.Width = 180;
            // 
            // Preis
            // 
            Preis.Text = "Preis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 23);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Bestellung";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 63);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 8;
            label4.Text = "Pizza auswählen";
            // 
            // lb_Pizzaauswahl
            // 
            lb_Pizzaauswahl.FormattingEnabled = true;
            lb_Pizzaauswahl.ItemHeight = 15;
            lb_Pizzaauswahl.Location = new Point(24, 81);
            lb_Pizzaauswahl.Name = "lb_Pizzaauswahl";
            lb_Pizzaauswahl.Size = new Size(120, 94);
            lb_Pizzaauswahl.TabIndex = 9;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(4, 18);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 19);
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
            groupBox1.Location = new Point(148, 65);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(92, 109);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Größe ";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(4, 60);
            radioButton3.Margin = new Padding(2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(54, 19);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "40cm";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(4, 39);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "32cm";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(107, 0);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(106, 134);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 63);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 13;
            label6.Text = "Menge";
            // 
            // nUD_Mengenauswahl
            // 
            nUD_Mengenauswahl.Location = new Point(244, 81);
            nUD_Mengenauswahl.Margin = new Padding(2);
            nUD_Mengenauswahl.Name = "nUD_Mengenauswahl";
            nUD_Mengenauswahl.Size = new Size(88, 23);
            nUD_Mengenauswahl.TabIndex = 14;
            // 
            // b_pizzaHinzufügen
            // 
            b_pizzaHinzufügen.Location = new Point(176, 236);
            b_pizzaHinzufügen.Margin = new Padding(2);
            b_pizzaHinzufügen.Name = "b_pizzaHinzufügen";
            b_pizzaHinzufügen.Size = new Size(156, 20);
            b_pizzaHinzufügen.TabIndex = 15;
            b_pizzaHinzufügen.Text = "Pizza Hinzufügen";
            b_pizzaHinzufügen.UseVisualStyleBackColor = true;
            b_pizzaHinzufügen.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(776, 314);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 316);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 17;
            label5.Text = "Gesamtpreis";
            // 
            // lb_extrazutaten
            // 
            lb_extrazutaten.FormattingEnabled = true;
            lb_extrazutaten.ItemHeight = 15;
            lb_extrazutaten.Location = new Point(24, 177);
            lb_extrazutaten.Margin = new Padding(2);
            lb_extrazutaten.Name = "lb_extrazutaten";
            lb_extrazutaten.SelectionMode = SelectionMode.MultiSimple;
            lb_extrazutaten.Size = new Size(120, 79);
            lb_extrazutaten.TabIndex = 25;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 410);
            Controls.Add(lb_extrazutaten);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(b_pizzaHinzufügen);
            Controls.Add(nUD_Mengenauswahl);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(lb_Pizzaauswahl);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(listView2);
            Controls.Add(label1);
            Controls.Add(b_bestellen);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Mengenauswahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_bestellen;
        private Label label1;
        private ListView listView2;
        private Label label2;
        private Label label4;
        private ListBox lb_Pizzaauswahl;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private GroupBox groupBox2;
        private Label label6;
        private NumericUpDown nUD_Mengenauswahl;
        private Button b_pizzaHinzufügen;
        private TextBox textBox2;
        private Label label5;
        private ColumnHeader Menge;
        private ColumnHeader Pizza;
        private ColumnHeader Preis;
        private ListBox lb_extrazutaten;
        private ColumnHeader Extras;
        private ColumnHeader Größe;
    }
}