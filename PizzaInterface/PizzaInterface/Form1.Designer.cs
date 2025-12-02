namespace PizzaInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b_ok = new Button();
            lable_pizzaeingeben = new Label();
            cb_Pizzerien = new ComboBox();
            cb_kundenNummer = new ComboBox();
            l_kundennummer = new Label();
            b_bestellhistorie = new Button();
            SuspendLayout();
            // 
            // b_ok
            // 
            b_ok.Location = new Point(184, 80);
            b_ok.Name = "b_ok";
            b_ok.Size = new Size(75, 23);
            b_ok.TabIndex = 0;
            b_ok.Text = "Bestellen";
            b_ok.UseVisualStyleBackColor = true;
            b_ok.Click += button1_Click;
            // 
            // lable_pizzaeingeben
            // 
            lable_pizzaeingeben.AutoSize = true;
            lable_pizzaeingeben.Location = new Point(16, 62);
            lable_pizzaeingeben.Margin = new Padding(2, 0, 2, 0);
            lable_pizzaeingeben.Name = "lable_pizzaeingeben";
            lable_pizzaeingeben.Size = new Size(211, 15);
            lable_pizzaeingeben.TabIndex = 2;
            lable_pizzaeingeben.Text = "Bitte die gewünschte Pizzeria eingeben";
            // 
            // cb_Pizzerien
            // 
            cb_Pizzerien.FormattingEnabled = true;
            cb_Pizzerien.Location = new Point(16, 80);
            cb_Pizzerien.Name = "cb_Pizzerien";
            cb_Pizzerien.Size = new Size(121, 23);
            cb_Pizzerien.TabIndex = 3;
            // 
            // cb_kundenNummer
            // 
            cb_kundenNummer.FormattingEnabled = true;
            cb_kundenNummer.Location = new Point(16, 27);
            cb_kundenNummer.Name = "cb_kundenNummer";
            cb_kundenNummer.Size = new Size(121, 23);
            cb_kundenNummer.TabIndex = 4;
            // 
            // l_kundennummer
            // 
            l_kundennummer.AutoSize = true;
            l_kundennummer.Location = new Point(16, 9);
            l_kundennummer.Name = "l_kundennummer";
            l_kundennummer.Size = new Size(97, 15);
            l_kundennummer.TabIndex = 5;
            l_kundennummer.Text = "Kundennummer ";
            // 
            // b_bestellhistorie
            // 
            b_bestellhistorie.Location = new Point(16, 125);
            b_bestellhistorie.Name = "b_bestellhistorie";
            b_bestellhistorie.Size = new Size(243, 23);
            b_bestellhistorie.TabIndex = 6;
            b_bestellhistorie.Text = "Bestellhistorie anzeigen";
            b_bestellhistorie.UseVisualStyleBackColor = true;
            b_bestellhistorie.Click += b_bestellhistorie_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 160);
            Controls.Add(b_bestellhistorie);
            Controls.Add(l_kundennummer);
            Controls.Add(cb_kundenNummer);
            Controls.Add(cb_Pizzerien);
            Controls.Add(lable_pizzaeingeben);
            Controls.Add(b_ok);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_ok;
        private Label lable_pizzaeingeben;
        private ComboBox cb_Pizzerien;
        private ComboBox cb_kundenNummer;
        private Label l_kundennummer;
        private Button b_bestellhistorie;
    }
}
