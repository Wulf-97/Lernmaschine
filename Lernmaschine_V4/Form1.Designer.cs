namespace Lernmaschine_V4
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
            this.comboBoxFach = new System.Windows.Forms.ComboBox();
            this.comboBoxKasten = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelFach = new System.Windows.Forms.Label();
            this.labelKasten = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lernmaschineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelVorText = new System.Windows.Forms.Label();
            this.labelRueckText = new System.Windows.Forms.Label();
            this.textBoxVorderseite = new System.Windows.Forms.TextBox();
            this.textBoxRueckseite = new System.Windows.Forms.TextBox();
            this.labelVorderseite = new System.Windows.Forms.Label();
            this.labelRueckseite = new System.Windows.Forms.Label();
            this.listBoxVorderseite = new System.Windows.Forms.ListBox();
            this.listBoxRueckseite = new System.Windows.Forms.ListBox();
            this.buttonZurueck = new System.Windows.Forms.Button();
            this.buttonPruefen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.buttonVor = new System.Windows.Forms.Button();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFach
            // 
            this.comboBoxFach.FormattingEnabled = true;
            this.comboBoxFach.Location = new System.Drawing.Point(23, 54);
            this.comboBoxFach.Name = "comboBoxFach";
            this.comboBoxFach.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFach.TabIndex = 20;
            this.comboBoxFach.SelectedIndexChanged += new System.EventHandler(this.comboBoxFach_SelectedIndexChanged);
            // 
            // comboBoxKasten
            // 
            this.comboBoxKasten.FormattingEnabled = true;
            this.comboBoxKasten.Location = new System.Drawing.Point(23, 118);
            this.comboBoxKasten.Name = "comboBoxKasten";
            this.comboBoxKasten.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKasten.TabIndex = 21;
            this.comboBoxKasten.SelectedIndexChanged += new System.EventHandler(this.comboBoxKasten_SelectedIndexChanged);
            // 
            // labelFach
            // 
            this.labelFach.AutoSize = true;
            this.labelFach.Location = new System.Drawing.Point(20, 35);
            this.labelFach.Name = "labelFach";
            this.labelFach.Size = new System.Drawing.Size(31, 13);
            this.labelFach.TabIndex = 2;
            this.labelFach.Text = "Fach";
            // 
            // labelKasten
            // 
            this.labelKasten.AutoSize = true;
            this.labelKasten.Location = new System.Drawing.Point(23, 102);
            this.labelKasten.Name = "labelKasten";
            this.labelKasten.Size = new System.Drawing.Size(40, 13);
            this.labelKasten.TabIndex = 3;
            this.labelKasten.Text = "Kasten";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.editToolStripMenuItem,
            this.lernenToolStripMenuItem,
            this.statistikToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.öffnenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lernmaschineToolStripMenuItem});
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // lernmaschineToolStripMenuItem
            // 
            this.lernmaschineToolStripMenuItem.Name = "lernmaschineToolStripMenuItem";
            this.lernmaschineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lernmaschineToolStripMenuItem.Text = "Lernmaschine";
            this.lernmaschineToolStripMenuItem.Click += new System.EventHandler(this.lernmaschineToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // lernenToolStripMenuItem
            // 
            this.lernenToolStripMenuItem.Name = "lernenToolStripMenuItem";
            this.lernenToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.lernenToolStripMenuItem.Text = "Lernen";
            this.lernenToolStripMenuItem.Click += new System.EventHandler(this.lernenToolStripMenuItem_Click);
            // 
            // statistikToolStripMenuItem
            // 
            this.statistikToolStripMenuItem.Name = "statistikToolStripMenuItem";
            this.statistikToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.statistikToolStripMenuItem.Text = "Statistik";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(26, 173);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Message";
            // 
            // labelVorText
            // 
            this.labelVorText.AutoSize = true;
            this.labelVorText.Location = new System.Drawing.Point(46, 216);
            this.labelVorText.Name = "labelVorText";
            this.labelVorText.Size = new System.Drawing.Size(60, 13);
            this.labelVorText.TabIndex = 6;
            this.labelVorText.Text = "Vorderseite";
            // 
            // labelRueckText
            // 
            this.labelRueckText.AutoSize = true;
            this.labelRueckText.Location = new System.Drawing.Point(332, 216);
            this.labelRueckText.Name = "labelRueckText";
            this.labelRueckText.Size = new System.Drawing.Size(55, 13);
            this.labelRueckText.TabIndex = 7;
            this.labelRueckText.Text = "Rückseite";
            // 
            // textBoxVorderseite
            // 
            this.textBoxVorderseite.Location = new System.Drawing.Point(49, 232);
            this.textBoxVorderseite.Multiline = true;
            this.textBoxVorderseite.Name = "textBoxVorderseite";
            this.textBoxVorderseite.Size = new System.Drawing.Size(193, 68);
            this.textBoxVorderseite.TabIndex = 8;
            // 
            // textBoxRueckseite
            // 
            this.textBoxRueckseite.Location = new System.Drawing.Point(335, 232);
            this.textBoxRueckseite.Multiline = true;
            this.textBoxRueckseite.Name = "textBoxRueckseite";
            this.textBoxRueckseite.Size = new System.Drawing.Size(181, 68);
            this.textBoxRueckseite.TabIndex = 9;
            // 
            // labelVorderseite
            // 
            this.labelVorderseite.AutoSize = true;
            this.labelVorderseite.Location = new System.Drawing.Point(218, 35);
            this.labelVorderseite.Name = "labelVorderseite";
            this.labelVorderseite.Size = new System.Drawing.Size(60, 13);
            this.labelVorderseite.TabIndex = 10;
            this.labelVorderseite.Text = "Vorderseite";
            // 
            // labelRueckseite
            // 
            this.labelRueckseite.AutoSize = true;
            this.labelRueckseite.Location = new System.Drawing.Point(374, 35);
            this.labelRueckseite.Name = "labelRueckseite";
            this.labelRueckseite.Size = new System.Drawing.Size(55, 13);
            this.labelRueckseite.TabIndex = 11;
            this.labelRueckseite.Text = "Rückseite";
            // 
            // listBoxVorderseite
            // 
            this.listBoxVorderseite.FormattingEnabled = true;
            this.listBoxVorderseite.Location = new System.Drawing.Point(221, 54);
            this.listBoxVorderseite.Name = "listBoxVorderseite";
            this.listBoxVorderseite.Size = new System.Drawing.Size(120, 95);
            this.listBoxVorderseite.TabIndex = 12;
            // 
            // listBoxRueckseite
            // 
            this.listBoxRueckseite.FormattingEnabled = true;
            this.listBoxRueckseite.Location = new System.Drawing.Point(377, 54);
            this.listBoxRueckseite.Name = "listBoxRueckseite";
            this.listBoxRueckseite.Size = new System.Drawing.Size(120, 95);
            this.listBoxRueckseite.TabIndex = 13;
            // 
            // buttonZurueck
            // 
            this.buttonZurueck.Location = new System.Drawing.Point(49, 316);
            this.buttonZurueck.Name = "buttonZurueck";
            this.buttonZurueck.Size = new System.Drawing.Size(75, 23);
            this.buttonZurueck.TabIndex = 14;
            this.buttonZurueck.Text = "zurück";
            this.buttonZurueck.UseVisualStyleBackColor = true;
            // 
            // buttonPruefen
            // 
            this.buttonPruefen.Location = new System.Drawing.Point(143, 316);
            this.buttonPruefen.Name = "buttonPruefen";
            this.buttonPruefen.Size = new System.Drawing.Size(75, 23);
            this.buttonPruefen.TabIndex = 15;
            this.buttonPruefen.Text = "prüfen";
            this.buttonPruefen.UseVisualStyleBackColor = true;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(254, 302);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 16;
            this.buttonBeenden.Text = "beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(354, 316);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 17;
            this.buttonLoeschen.Text = "löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            // 
            // buttonVor
            // 
            this.buttonVor.Location = new System.Drawing.Point(451, 316);
            this.buttonVor.Name = "buttonVor";
            this.buttonVor.Size = new System.Drawing.Size(75, 23);
            this.buttonVor.TabIndex = 18;
            this.buttonVor.Text = "vor";
            this.buttonVor.UseVisualStyleBackColor = true;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(254, 345);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 19;
            this.buttonSpeichern.Text = "speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 388);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.buttonVor);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonPruefen);
            this.Controls.Add(this.buttonZurueck);
            this.Controls.Add(this.listBoxRueckseite);
            this.Controls.Add(this.listBoxVorderseite);
            this.Controls.Add(this.labelRueckseite);
            this.Controls.Add(this.labelVorderseite);
            this.Controls.Add(this.textBoxRueckseite);
            this.Controls.Add(this.textBoxVorderseite);
            this.Controls.Add(this.labelRueckText);
            this.Controls.Add(this.labelVorText);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelKasten);
            this.Controls.Add(this.labelFach);
            this.Controls.Add(this.comboBoxKasten);
            this.Controls.Add(this.comboBoxFach);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lernmaschine";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFach;
        private System.Windows.Forms.ComboBox comboBoxKasten;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelFach;
        private System.Windows.Forms.Label labelKasten;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelVorText;
        private System.Windows.Forms.Label labelRueckText;
        private System.Windows.Forms.TextBox textBoxVorderseite;
        private System.Windows.Forms.TextBox textBoxRueckseite;
        private System.Windows.Forms.Label labelVorderseite;
        private System.Windows.Forms.Label labelRueckseite;
        private System.Windows.Forms.ListBox listBoxVorderseite;
        private System.Windows.Forms.ListBox listBoxRueckseite;
        private System.Windows.Forms.Button buttonZurueck;
        private System.Windows.Forms.Button buttonPruefen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Button buttonVor;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.ToolStripMenuItem lernmaschineToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

