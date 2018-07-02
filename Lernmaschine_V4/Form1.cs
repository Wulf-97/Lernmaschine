using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lernmaschine_V4
{
    public partial class Form1 : Form
    {
        private XDocument doc;
        public Form1()
        {
            InitializeComponent();
            speichernToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            lernenToolStripMenuItem.Enabled = false;
            labelMessage.Visible = false;
        }

        private void lernmaschineToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        doc = new XDocument(
            new XElement("Lernmaschine",
            new XElement("Fach",
            new XAttribute("Name", "Sport"),
            new XElement("Kasten",
            new XAttribute("Nr", "1"),
            new XElement("Karteikarte",
                new XElement("Vorderseite", "NBA"),
                new XElement("Rueckseite", "National Basketball League")
                        ),
            new XElement("Karteikarte",
                new XElement("Vorderseite", "NFL"),
                new XElement("Rueckseite", "National Football League")
                        ),
            new XElement("Karteikarte",
                new XElement("Vorderseite", "MLB"),
                new XElement("Rueckseite", "National Baseball League")
                        )
                ),
            new XElement("Kasten",
            new XAttribute("Nr", "2"),
            new XElement("Vorderseite", "NHL"),
            new XElement("Rueckseite", "National Hockey League")
                 ),
            new XElement("Kasten",
            new XAttribute("Nr", "3")
                ),
            new XElement("Kasten",
            new XAttribute("Nr", "4")
                ),
            new XElement("Kasten",
            new XAttribute("Nr", "5")
                )
            ),
            new XElement("Fach",
            new XAttribute("Name", "Geschichte"),
            new XElement("Kasten",
            new XAttribute("Nr", "6"),
            new XElement("Vorderseite", "1945"),
            new XElement("Rueckseite", "Ende 2 Weltkrieg")
                ),
            new XElement("Kasten",
            new XAttribute("Nr", "7")
                )
            )
            )
);
            doc.Save("Lernmaschine.xml");

            speichernToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            lernenToolStripMenuItem.Enabled = true;
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            doc.Save(saveFileDialog1.FileName);
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            XDocument.Load(openFileDialog1.FileName);
            speichernToolStripMenuItem.Enabled = true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var document = XDocument.Load("Lernmaschine.xml");
            var bezeichnung = document
                .Element(XName.Get("Lernmaschine"))
                .Elements(XName.Get("Fach"));

            var fachName = bezeichnung.Select(a => a.Attribute(XName.Get("Name")).Value);

            foreach (string name in fachName)
            {
                comboBoxFach.Items.Add(name);
            }
        }

        private void editLayout()
        {
            textBoxRueckseite.Visible = true;
            textBoxVorderseite.Visible = true;
            comboBoxFach.Visible = true;
            comboBoxKasten.Visible = true;
            listBoxRueckseite.Visible = true;
            listBoxVorderseite.Visible = true;
            labelFach.Visible = true;
            labelKasten.Visible = true;
            labelMessage.Visible = true;
            labelVorText.Visible = true;
            labelRueckText.Visible = true;
            labelRueckseite.Visible = true;
            labelVorderseite.Visible = true;
            buttonBeenden.Visible = false;
            buttonPruefen.Visible = false;
            buttonSpeichern.Visible = true;
            buttonLoeschen.Visible = true;
            buttonVor.Visible = true;
            buttonZurueck.Visible = true;
        }

        private void lernenLayout()
        {
            textBoxRueckseite.Visible = true;
            textBoxVorderseite.Visible = true;
            comboBoxFach.Visible = false;
            comboBoxKasten.Visible = false;
            listBoxRueckseite.Visible = false;
            listBoxVorderseite.Visible = false;
            labelFach.Visible = false;
            labelKasten.Visible = false;
            labelMessage.Visible = true;
            labelVorText.Visible = true;
            labelRueckText.Visible = true;
            labelRueckseite.Visible = false;
            labelVorderseite.Visible = false;
            buttonBeenden.Visible = true;
            buttonPruefen.Visible = true;
            buttonSpeichern.Visible = false;
            buttonLoeschen.Visible = false;
            buttonVor.Visible = true;
            buttonZurueck.Visible = true;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editLayout();
        }

        private void lernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lernenLayout();
            textBoxVorderseite.Text = "";
            textBoxRueckseite.Text = "";

            IEnumerable<XElement> vorderseiten =
            doc.Descendants("Fach").
            Where(a => a.Attribute("Name").Value == comboBoxFach.
            SelectedValue).
            Descendants("Kasten").
            Where(b => b.Attribute("Nr").Value == "1").
            Descendants("Vorderseite");

            List<string> vorderseitenListe = new List<string>();

            foreach (XElement xe in vorderseiten)
            {
                vorderseitenListe.Add(xe.Value);
            }

            textBoxVorderseite.Text = vorderseitenListe[0];

        }

        private void comboBoxFach_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<XElement> elementsKasten = doc.Descendants("Fach").
    Where(o => o.Attribute("Name").Value == comboBoxFach.Text).
    Descendants("Kasten");
            List<String> kastenListe = new List<String>();

            foreach (XElement xe in elementsKasten)
            {
                kastenListe.Add(xe.Attribute("Nr").Value);
            }
            comboBoxKasten.DataSource = kastenListe;
        }

        private void comboBoxKasten_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<XElement> elementsVor = doc.Descendants("Fach").
        Where(o => o.Attribute("Name").Value == comboBoxFach.Text).
        Descendants("Kasten").Where(a => a.Attribute("Nr").Value == comboBoxKasten.Text).
        Descendants("Vorderseite");
            List<String> vorListe = new List<String>();
            foreach (XElement xe in elementsVor)
            {
                vorListe.Add(xe.Value);
            }
            listBoxVorderseite.DataSource = vorListe;

            IEnumerable<XElement> elementsRueck = doc.Descendants("Fach").
                Where(o => o.Attribute("Name").Value == comboBoxFach.Text).
                Descendants("Kasten").Where(a => a.Attribute("Nr").Value == comboBoxKasten.Text).
                Descendants("Rueckseite");
            List<String> rueckListe = new List<String>();
            foreach (XElement xe in elementsRueck)
            {
                rueckListe.Add(xe.Value);
            }
            listBoxRueckseite.DataSource = rueckListe;
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            doc.Descendants("Fach").
    Where(o => o.Attribute("Name").Value ==
    comboBoxFach.Text).Descendants("Kasten").
    Where(a => a.Attribute("Nr").Value == "1").
    First().Add(new XElement("Karteikarte",
                   new XElement("Vorderseite", textBoxVorderseite.Text),
                   new XElement("Rueckseite", textBoxRueckseite.Text)
                           )
                   );
            doc.Save("Lernmaschine.xml");
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

 
    }
}
