namespace winforms_checkserial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmdCheck_Click(object sender, EventArgs e)
        {
            int nZeichen;
            string strZeichen = cboSerienNummer.Text;
            //Prüfe, ob erstes Zeichen im String alphanummerisch
            if (char.IsUpper(Convert.ToChar(strZeichen[0])) || char.IsLower(Convert.ToChar(strZeichen[0])))
            {
                //Wandel alphanummerischen Wert in ganze Zahl
                nZeichen = Convert.ToInt32(strZeichen[0]);
                //Verknüpfe die ganze Zahl wieder mit der Ursprungszeichenkette
                strZeichen = nZeichen.ToString() + strZeichen.Remove(0, 1);
                //Zeichen des Strings in ein Char-Array schreiben und in der Schleife die Berechnung durchführen
                char[] chars = strZeichen.ToCharArray();
                int intSumme = 0;
                for (int i = 0; i < chars.Length; i++)
                {
                    intSumme += (chars[i] - '0');
                    //intSumme += (int)Char.GetNumericValue(chars[i]);
                }
                if (intSumme % 9 == 0)
                {
                    LblAusgabeCheck.ForeColor = Color.Green;
                    LblAusgabeCheck.Text = @"Valid";
                    LblAusgabeRechenweg.ForeColor = Color.Black;
                    LblAusgabeRechenweg.Text = strZeichen + @", Quersumme: " + intSumme.ToString() + " durch 9 teilbar";
                }
                else
                {
                    LblAusgabeCheck.ForeColor = Color.Red;
                    LblAusgabeCheck.Text = @"Not Valid";
                    LblAusgabeRechenweg.ForeColor = Color.Black;
                    LblAusgabeRechenweg.Text = strZeichen + @", Quersumme: " + intSumme.ToString() + " nicht durch 9 teilbar";
                }
            }
            else
            {
                LblAusgabeCheck.ForeColor = Color.Red;
                LblAusgabeCheck.Text = @"Not Valid";
                LblAusgabeRechenweg.ForeColor = Color.Red;
                LblAusgabeRechenweg.Text = @"Country code at the beginning of the entered serial number is missing";
            }
        }
        /// <summary>
        /// Methode Zentriere Fenster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}