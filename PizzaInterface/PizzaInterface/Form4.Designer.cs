namespace PizzaInterface
{
    partial class Form4
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
            label1 = new Label();
            l_bestellungen = new Label();
            listView1 = new ListView();
            l_bestelldeteils = new Label();
            listView2 = new ListView();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // l_bestellungen
            // 
            l_bestellungen.AutoSize = true;
            l_bestellungen.Location = new Point(23, 26);
            l_bestellungen.Name = "l_bestellungen";
            l_bestellungen.Size = new Size(108, 15);
            l_bestellungen.TabIndex = 3;
            l_bestellungen.Text = "Deine Bestellungen";
            // 
            // listView1
            // 
            listView1.Location = new Point(23, 59);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(361, 323);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // l_bestelldeteils
            // 
            l_bestelldeteils.AutoSize = true;
            l_bestelldeteils.Location = new Point(398, 26);
            l_bestelldeteils.Name = "l_bestelldeteils";
            l_bestelldeteils.Size = new Size(75, 15);
            l_bestelldeteils.TabIndex = 6;
            l_bestelldeteils.Text = "Bestelldeteils\r\n";
            // 
            // listView2
            // 
            listView2.Location = new Point(398, 59);
            listView2.Name = "listView2";
            listView2.Size = new Size(361, 323);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Location = new Point(230, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listView2);
            Controls.Add(l_bestelldeteils);
            Controls.Add(listView1);
            Controls.Add(l_bestellungen);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label l_bestellungen;
        private Button button1;
        private ListView listView1;
        private Label l_bestelldeteils;
        private ListView listView2;
        private Button button2;
    }
}