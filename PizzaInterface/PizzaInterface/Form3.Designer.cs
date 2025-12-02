namespace PizzaInterface
{
    partial class Form3
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
            labelBestellung = new Label();
            bBestellen = new Button();
            labelRabattcode = new Label();
            tbRabattcode = new TextBox();
            tbRabattpreis = new TextBox();
            tbPreis = new TextBox();
            tbGesamtpreis = new TextBox();
            labelGesamtpreis = new Label();
            lvÜbersicht = new ListView();
            Menge = new ColumnHeader();
            Pizza = new ColumnHeader();
            Größe = new ColumnHeader();
            Extras = new ColumnHeader();
            Preis = new ColumnHeader();
            tbAdresse = new TextBox();
            labelAdresse = new Label();
            labelPreis = new Label();
            SuspendLayout();
            // 
            // labelBestellung
            // 
            labelBestellung.AutoSize = true;
            labelBestellung.Location = new Point(21, 24);
            labelBestellung.Name = "labelBestellung";
            labelBestellung.Size = new Size(62, 15);
            labelBestellung.TabIndex = 0;
            labelBestellung.Text = "Bestellung";
            // 
            // bBestellen
            // 
            bBestellen.Location = new Point(216, 427);
            bBestellen.Name = "bBestellen";
            bBestellen.Size = new Size(146, 23);
            bBestellen.TabIndex = 1;
            bBestellen.Text = "Bestellung Abschicken";
            bBestellen.UseVisualStyleBackColor = true;
            bBestellen.Click += button1_Click;
            // 
            // labelRabattcode
            // 
            labelRabattcode.AutoSize = true;
            labelRabattcode.Location = new Point(21, 338);
            labelRabattcode.Name = "labelRabattcode";
            labelRabattcode.Size = new Size(67, 15);
            labelRabattcode.TabIndex = 3;
            labelRabattcode.Text = "Rabattcode";
            // 
            // tbRabattcode
            // 
            tbRabattcode.Location = new Point(94, 335);
            tbRabattcode.Name = "tbRabattcode";
            tbRabattcode.Size = new Size(174, 23);
            tbRabattcode.TabIndex = 4;
            tbRabattcode.TextChanged += textBox1_TextChanged;
            // 
            // tbRabattpreis
            // 
            tbRabattpreis.Location = new Point(465, 335);
            tbRabattpreis.Name = "tbRabattpreis";
            tbRabattpreis.Size = new Size(100, 23);
            tbRabattpreis.TabIndex = 5;
            // 
            // tbPreis
            // 
            tbPreis.Location = new Point(465, 306);
            tbPreis.Name = "tbPreis";
            tbPreis.Size = new Size(100, 23);
            tbPreis.TabIndex = 6;
            // 
            // tbGesamtpreis
            // 
            tbGesamtpreis.Location = new Point(465, 364);
            tbGesamtpreis.Name = "tbGesamtpreis";
            tbGesamtpreis.Size = new Size(100, 23);
            tbGesamtpreis.TabIndex = 7;
            // 
            // labelGesamtpreis
            // 
            labelGesamtpreis.AutoSize = true;
            labelGesamtpreis.Location = new Point(21, 367);
            labelGesamtpreis.Name = "labelGesamtpreis";
            labelGesamtpreis.Size = new Size(72, 15);
            labelGesamtpreis.TabIndex = 8;
            labelGesamtpreis.Text = "Gesamtpreis";
            // 
            // lvÜbersicht
            // 
            lvÜbersicht.Columns.AddRange(new ColumnHeader[] { Menge, Pizza, Größe, Extras, Preis });
            lvÜbersicht.FullRowSelect = true;
            lvÜbersicht.GridLines = true;
            lvÜbersicht.Location = new Point(21, 42);
            lvÜbersicht.MultiSelect = false;
            lvÜbersicht.Name = "lvÜbersicht";
            lvÜbersicht.Size = new Size(544, 264);
            lvÜbersicht.TabIndex = 9;
            lvÜbersicht.UseCompatibleStateImageBehavior = false;
            lvÜbersicht.View = View.Details;
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
            // tbAdresse
            // 
            tbAdresse.Location = new Point(97, 398);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.ReadOnly = true;
            tbAdresse.ScrollBars = ScrollBars.Horizontal;
            tbAdresse.Size = new Size(468, 23);
            tbAdresse.TabIndex = 10;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.Location = new Point(21, 398);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(78, 15);
            labelAdresse.TabIndex = 11;
            labelAdresse.Text = "Lieferadresse:";
            // 
            // labelPreis
            // 
            labelPreis.AutoSize = true;
            labelPreis.Location = new Point(21, 314);
            labelPreis.Name = "labelPreis";
            labelPreis.Size = new Size(93, 15);
            labelPreis.TabIndex = 12;
            labelPreis.Text = "Preis Bestellung:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 456);
            Controls.Add(labelPreis);
            Controls.Add(labelAdresse);
            Controls.Add(tbAdresse);
            Controls.Add(lvÜbersicht);
            Controls.Add(labelGesamtpreis);
            Controls.Add(tbGesamtpreis);
            Controls.Add(tbPreis);
            Controls.Add(tbRabattpreis);
            Controls.Add(tbRabattcode);
            Controls.Add(labelRabattcode);
            Controls.Add(bBestellen);
            Controls.Add(labelBestellung);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBestellung;
        private Button bBestellen;
        private Label labelRabattcode;
        private TextBox tbRabattcode;
        private TextBox tbRabattpreis;
        private TextBox tbPreis;
        private TextBox tbGesamtpreis;
        private Label labelGesamtpreis;
        private ListView lvÜbersicht;
        private ColumnHeader Menge;
        private ColumnHeader Pizza;
        private ColumnHeader Größe;
        private ColumnHeader Extras;
        private ColumnHeader Preis;
        private TextBox tbAdresse;
        private Label labelAdresse;
        private Label labelPreis;
    }
}