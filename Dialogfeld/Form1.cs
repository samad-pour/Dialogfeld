using Microsoft.VisualBasic;

namespace Dialogfeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            string eingabe;
            eingabe = Interaction.InputBox(
            "Bitte Ihren Namen:", "Ihr Name", "Maier");
            LblDisplay.Text = eingabe;
        }

        private void BtnLotto_Click(object sender, EventArgs e)
        {
            int zahl;
            int[] lotto = new int[6];
            bool gezogen;

            LblDisplay.Text = "";
            for (int i = 0; i < lotto.Length; i++)
            {
                do
                {
                    gezogen = false;
                    zahl = 0;
                    try
                    {
                        zahl = Convert.ToInt32(Interaction.InputBox(
                        "Zahl " + (i + 1) + ": ", "Zahl " + (i + 1)));
}
                    catch
                    {
                        continue;
                    }
                    for (int k = 0; k < i; k++)
                        if (lotto[k] == zahl)
                        {
                            gezogen = true;
                            break;
                        }
                }
                while (gezogen || zahl < 1 || zahl > 49);

                lotto[i] = zahl;
                LblDisplay.Text += zahl + " ";
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gelesen? Dann bitte Ok drücken",
                            "Ok",
                            MessageBoxButtons.OK);
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Das ist eine Information", "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void BtnYesNo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Soll die Datei gesichert werden?",
                                              "Sicherung",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                LblDisplay.Text = "Sichern";
            else
                LblDisplay.Text = "Nicht sichern";
        }

        private void BtnYesNoCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Soll die Datei gesichert werden?",
                                              "Sicherung",
                                              MessageBoxButtons.YesNoCancel,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                LblDisplay.Text = "Sichern";
            else if (dr == DialogResult.No)
                LblDisplay.Text = "Nicht sichern";
            else
                LblDisplay.Text = "Abbrechen";
        }

        private void BtnRetryCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Beim Sichern der Datei trat ein Fehler auf.\n" +
                                              "Wollen Sie es noch einmal probieren?\n" +
                                              "Wollen Sie " +
                                              "den Vorgang abbrechen?",
                                              "Fehler bei Sicherung",
                                              MessageBoxButtons.RetryCancel,
                                              MessageBoxIcon.Error);

            if (dr == DialogResult.Retry)
                LblDisplay.Text = "Noch einmal";
            else
                LblDisplay.Text = "Abbrechen";
        }

        private void BtnAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Beim Sichern der Datei trat ein Fehler auf.\n" +
                                              "Wollen Sie den Vorgang abbrechen?\n" +
                                              "Wollen Sie es " +
                                              "noch einmal probieren?\n" +
                                              "Wollen Sie diese " +
                                              "Nachricht ignorieren?",
                                              "Fehler bei Sicherung",
                                              MessageBoxButtons.AbortRetryIgnore,
                                              MessageBoxIcon.Warning);

            if (dr == DialogResult.Abort)
                LblDisplay.Text = "Abbrechen";
            else if (dr == DialogResult.Retry)
                LblDisplay.Text = "Noch einmal";
            else
                LblDisplay.Text = "Ignorieren";
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = true,
                InitialDirectory = "C:\\Temp",
                Filter = "Tabellen (*.xlsx)|*.xlsx|" +
                         " Texte (*.txt; *docx)|*.txt;*.docx|" +
                         " Alle Dateien (*.*)|*.*",
                Title = "Datei zum Öffnen auswählen"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                foreach (string s in ofd.FileNames)
                    MessageBox.Show("Öffnen: " + s);
            else
                MessageBox.Show("Abbruch");
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                ShowNewFolderButton = false,
                Description = "Verzeichnis auswählen"
            };

            if (fbd.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Zugriff auf Verzeichnis: " +
                fbd.SelectedPath);
            else
                MessageBox.Show("Abbruch");
        }

        private void BtnSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                LblDisplay.ForeColor = cd.Color;
            else
                MessageBox.Show("Abbruch");
        }

        private void BtnSelectFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog()
            {
                ShowColor = true,
                MinSize = 8,
                MaxSize = 20
            };

            if (fd.ShowDialog() == DialogResult.OK)
            {
                LblDisplay.Font = fd.Font;
                LblDisplay.ForeColor = fd.Color;
            }
            else
                MessageBox.Show("Abbruch");
        }
    }
}