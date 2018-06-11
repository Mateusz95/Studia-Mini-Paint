using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dodanie nowej przestrzeni nazw System.Drawing.Drawing2D
using System.Drawing.Drawing2D;
namespace projekt22
{
    public partial class btnWlaczenieSlajdera : Form
    {

        //deklaracja stalych
        const int mgMargines = 10;
        const int mgPromienPunktu = 2;
        //deklaracja powierzchni graficznej 
        Graphics mgRysownica;
        //deklaracja piora 
        Pen mgpioro;
        //deklaracja pkt dla przechowania wspolrzednych klikniecia powierzchni graficznej, nacisnieciem lewego przycisku myszy 
        Point mgPunkt = Point.Empty;
        //deklaracja listy LFG (Lista Figur Geometrycznych), do której będą dodawane egzemplarze utworzonych figur geometrycznych
        List<mgPunkt> mgLFG = new List<mgPunkt>();
        //Brush mgBrush = new Brush(Color.Beige,);

        public btnWlaczenieSlajdera()
        {
            InitializeComponent();

            //utworzenie egzemplarza piora 
            mgpioro = new Pen(Color.Red, 1F);
            mgpioro.DashStyle = DashStyle.Solid;
            mgpioro.StartCap = LineCap.Round;//styl koncowki piora na poczatku
            mgpioro.EndCap = LineCap.Round;//styl koncowki piora na koncu 
            // ustalenie lokalizacji i rozmiarow formularza
            this.Left = 30;
            this.Top = 30;
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.9F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8F);
            this.StartPosition = FormStartPosition.Manual;
            //lokalizacja i zwymiarowanie kontrolki picturebox 
            pictureBox1.Location = new Point(20, 50);
            pictureBox1.Width = (int)(this.Width * 0.65F);
            pictureBox1.Height = (int)(this.Height * 0.65F);
            //ustalenie koloru tla dla kontrolki picturebox 
            pictureBox1.BackColor = Color.Beige;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            //utworzenie mapy bitowej i podpiecie do kontrolki picturebox 
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //utworzenie egzemplarza powierzchni graficznej na bitmapie 
            mgRysownica = Graphics.FromImage(pictureBox1.Image);

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //monitorowanie aktualnego polozenia myszki 
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            //sprawdzenie czy zdarzenie pochodzi od wcisniecia lewego przycisku myszy
            if (e.Button == MouseButtons.Left)
                //zapamietanie polozenia myszki 
                mgPunkt = e.Location;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            //sprawdzenie czy zdarzenie pochodzi od wcisniecia lewego przycisku myszy
            if (e.Button == MouseButtons.Left)
            {//wyznaczenie wspolrzednych lewego gornego naroznika prostokata oraz jego szerokosc i wysokosc 
                int mgLewyGornyNaroznikX = (mgPunkt.X > e.Location.X) ? mgPunkt.X : e.Location.X;
                int mgLewyGornyNaroznikY = (mgPunkt.Y > e.Location.Y) ? mgPunkt.Y : e.Location.Y;
                int mgSzerokosc = Math.Abs(mgPunkt.X - e.Location.X);
                int mgWysokosc = Math.Abs(mgPunkt.Y - e.Location.Y);


                //rozpoznanie wybranej figury geometrycznej, ktora ma byc teraz wykreslona 
                if (RBPkt.Checked)
                {
                    //wykreslenie punktu jako wypelnionej elipsy 
                    mgRysownica.FillEllipse(Brushes.Black, e.Location.X - mgPromienPunktu, e.Location.Y - mgPromienPunktu,
                    mgPromienPunktu + mgPromienPunktu, mgPromienPunktu + mgPromienPunktu);
                    //utworzenie egzemplarza Punktu i dodanie go do listy LFG
                    mgLFG.Add(new mgPunkt(mgPunkt.X, mgPunkt.Y));
                    //losowe ustalenie atrybutów graficznych dla utworzonego egzemplarza Punktu
                    mgLFG[mgLFG.Count - 1].mgFormatujFG(mgpioro.Color, mgpioro.DashStyle, (int)mgpioro.Width);

                }
                if (RbLinia.Checked)
                //wykreslenie linii
                {
                    mgRysownica.DrawLine(mgpioro, mgPunkt, e.Location);
                    //utworzenie egzemplarza linii i dodanie go do listy LFG
                    mgLFG.Add(new mgLinia(mgPunkt.X, mgPunkt.Y, e.Location.X, e.Location.Y));
                    //losowe ustalenie atrybutów graficznych dla utworzonego egzemplarza Punktu
                    mgLFG[mgLFG.Count - 1].mgFormatujFG(mgpioro.Color, mgpioro.DashStyle, (int)mgpioro.Width);

                }
                if (RbElipsa.Checked)
                {
                    mgRysownica.DrawEllipse(mgpioro, mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgWysokosc);
                    //utworzenie egzemplarza Elipsy i dodanie go do listy LFG
                    mgLFG.Add(new mgElipsa(mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgWysokosc));
                    //losowe ustalenie atrybutów graficzny dla utworzonego egzemplarza Punktu
                    mgLFG[mgLFG.Count - 1].mgFormatujFG(mgpioro.Color, mgpioro.DashStyle, (int)mgpioro.Width);
                }
                if (RbOkrag.Checked)
                {
                    mgRysownica.DrawEllipse(mgpioro, mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgSzerokosc);
                    mgLFG.Add(new mgOkrąg(mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc));
                    //losowe ustalenie atrybutów graficzny dla utworzonego egzemplarza Punktu
                    mgLFG[mgLFG.Count - 1].mgFormatujFG(mgpioro.Color, mgpioro.DashStyle, (int)mgpioro.Width);
                }
                if (RbProstokat.Checked)
                {
                    mgRysownica.DrawRectangle(mgpioro, mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgWysokosc);
                    mgLFG.Add(new mgProstokąt(mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgWysokosc));
                    //losowe ustalenie atrybutów graficzny dla utworzonego egzemplarza Punktu
                    mgLFG[mgLFG.Count - 1].mgFormatujFG(mgpioro.Color, mgpioro.DashStyle, (int)mgpioro.Width);
                }
                if (RbKwadrat.Checked)
                {
                    mgRysownica.DrawRectangle(mgpioro, mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgSzerokosc);
                    mgLFG.Add(new mgKwadrat(mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc));
                    //losowe ustalenie atrybutów graficzny dla utworzonego egzemplarza Punktu
                    mgLFG[mgLFG.Count - 1].mgFormatujFG(mgpioro.Color, mgpioro.DashStyle, (int)mgpioro.Width);
                }
                if (RbLiniaKreslona.Checked)
                {
                    mgRysownica.DrawLine(mgpioro, mgPunkt, e.Location);
                    //utworzenie egzemplarza linii i dodanie go do listy LFG
                    mgLFG.Add(new mgLinia(mgPunkt.X, mgPunkt.Y, e.Location.X, e.Location.Y));
                    //losowe ustalenie atrybutów graficznych dla utworzonego egzemplarza Punktu
                    mgLFG[mgLFG.Count - 1].mgFormatujFG(mgpioro.Color, mgpioro.DashStyle, (int)mgpioro.Width);
                }

            }

            //odswiezenie powierzchni graficznej kontrolki picturebox
            pictureBox1.Refresh();

        }

        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();


            int mgLewyGornyNaroznikX = (mgPunkt.X > e.Location.X) ? mgPunkt.X : e.Location.X;
            int mgLewyGornyNaroznikY = (mgPunkt.Y > e.Location.Y) ? mgPunkt.Y : e.Location.Y;

            int mgSzerokosc = Math.Abs(mgPunkt.X - e.Location.X);
            int mgWysokosc = Math.Abs(mgPunkt.Y - e.Location.Y);
            if (e.Button == MouseButtons.Left)
            {
                if (rbGumka.Checked)
                {
                
                    Pen mgpioro = new Pen(pictureBox1.BackColor, 60F);
                    //dociagniecie linii od ostatniego polozenia myszy 
                    mgRysownica.DrawLine(mgpioro, mgPunkt, e.Location);
                    //przechowanie aktualnego polozenia myszy, co bedzie wykorzystane pozniej jako ostatnie polozenie myszy 
                    mgPunkt = e.Location;
                }
                else
                if (RbLiniaKreslona.Checked)
                {
                    Pen mgpioro = new Pen(Color.Red, tbGrubośćLinii.Value);
                    //dociagniecie linii od ostatniego polozenia myszy 
                    mgRysownica.DrawLine(mgpioro, mgPunkt, e.Location);
                    //przechowanie aktualnego polozenia myszy, co bedzie wykorzystane pozniej jako ostatnie polozenie myszy 
                    mgPunkt = e.Location;


                }
                else
                {
                    //dociaganie kreslenie figur geometrycznych 
                    //utworzenie nowej, przezroczystej powierzchni graficznej na kontrolce picturebox
                    Graphics mgRysownica2 = this.pictureBox1.CreateGraphics();
                    //utworzenie pomocniczego piora dla wykreslania rozciaganych figur geometrycznych 
                    Pen mgpioro2 = new Pen(txtWziernikKoloruPedzla.BackColor, tbGrubośćLinii.Value);
                    //rozpoznanie wybranej figury geometrycznej 
                    if (RbOkrag.Checked)
                    {
                        mgRysownica2.DrawEllipse(mgpioro2, mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgWysokosc);

                    }
                    if (RbLinia.Checked)
                    {
                        mgRysownica2.DrawLine(mgpioro2, mgPunkt, e.Location);

                    }
                    if (RbElipsa.Checked)
                    {
                        mgRysownica2.DrawEllipse(mgpioro2, mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgWysokosc);
                    }
                    if (RbProstokat.Checked)
                    {
                        mgRysownica2.DrawRectangle(mgpioro2, mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgWysokosc);
                    }
                    if (RbKwadrat.Checked)
                    {
                        mgRysownica2.DrawRectangle(mgpioro2, mgLewyGornyNaroznikX, mgLewyGornyNaroznikY, mgSzerokosc, mgSzerokosc);
                    }
                    
                }

            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //wyczyszczenie powierzchni Rysownicy
            mgRysownica.Clear(pictureBox1.BackColor);
            //ustalenie rozmiarów Rysownicy
            int mgXmax = pictureBox1.Width;
            int mgYmax = pictureBox1.Height;
            //pokazanie kolejnej figury w środku Rysownicy
            mgLFG[(int)timer1.Tag].mgPrzesunDoNowegoXY(pictureBox1, mgRysownica, mgXmax / 2, mgYmax / 2);
            //wyznaczenie numeru nastepnej figury do pokazu
            timer1.Tag = (int.Parse(timer1.Tag.ToString()) + 1) % (mgLFG.Count - 1);
            //odswiezenie powierzchni graficznej
            pictureBox1.Refresh();

        }

        private void btnWlaczenieSlajdu_Click(object sender, EventArgs e)
        {
            //domyslne ustawienie figury, ktora bedzie pokazana jako pierwsza
            int mgIndeksFigury = 0;
            //wyczyszczenie powierzchni graficznej
            mgRysownica.Clear(pictureBox1.BackColor);
            //sprawdzanie wybranego trybu pokazu figur geometrycznych
            if (rtbSterowanieZegarem.Checked)
            {
                //sterowany zegarem
                //ustawienie w polu timer1.Tag numeru pierwszej figury
                timer1.Tag = mgIndeksFigury;

                //wlaczenie zegarem
                timer1.Enabled = true;
            }
            else
            {
                //tryb sterowania przyciskami
                //wyłączenie zegara
                timer1.Enabled = false;
                //sprawdzenie czy uzytkownik podal numer pierwszej figury do pokazu
                if (string.IsNullOrEmpty(txtNumerFiguryGeometrycznej.Text.Trim()))
                {
                    //jesli nie podal numeru to uzywamy numeru domyslnego
                    txtNumerFiguryGeometrycznej.Text = mgIndeksFigury.ToString();
                }
                else
                {
                    while (!int.TryParse(txtNumerFiguryGeometrycznej.Text, out mgIndeksFigury))
                        errorProvider1.SetError(txtNumerFiguryGeometrycznej,
                            "BŁĄD: Błędny zapis numeru figury geometrycznej");
                    //sprawdczenie czy wpisany numer jest dozwolony
                    if ((mgIndeksFigury < 0) || (mgIndeksFigury >= mgLFG.Count))
                    {
                        errorProvider1.SetError(txtNumerFiguryGeometrycznej,
                            "BŁĄD: Błędny numer figury geometrycznej - podaj dozwolony numer figury");
                    }
                }
                //zgaszenie kontrolki error provider
                errorProvider1.Dispose();
                //uaktywnienie przyciskow polecen, ktore musza byc aktywne dla potrzeb przyciskowego trybu pokazu
                btnNastepny.Enabled = true;
                btnPoprzedni.Enabled = true;
                //pokaz pierwszej figury o numerze Indeks Figury
                //wyznaczenie rozmiaru 
                int mgXmax = pictureBox1.Width;
                int mgYmax = pictureBox1.Height;
                //przesuniecie (z wykresleniem) pierwszej figury geometrycznej danego pokazu
                mgLFG[mgIndeksFigury].mgPrzesunDoNowegoXY(pictureBox1, mgRysownica, mgXmax / 2, mgYmax / 2);
                //odswiezenie Rysownicy
                pictureBox1.Refresh();
            }
            //uaktywnienie przycisku wylaczenia pokazu figur geometrycznych
            btnWylaczenieSlajdera.Enabled = true;


        }

        private void btnNastepny_Click(object sender, EventArgs e)
        {
            //ustawienie domyślnego numeru figury, która będzie pokazana jako pierwsza
            int mgIndeksFigury = 0;
            //sprawdzenie numeru wpisanego przez użytkownika
            while (!int.TryParse(txtNumerFiguryGeometrycznej.Text, out mgIndeksFigury))
                errorProvider1.SetError(txtNumerFiguryGeometrycznej, "ERROR: musisz podać numer figury geometrycznej");
            //sprawdzenie czy podany numer jest numerem dozwolonym
            if ((mgIndeksFigury < 0) || (mgIndeksFigury >= mgLFG.Count))
                errorProvider1.SetError(txtNumerFiguryGeometrycznej, "ERROR: nie ma figury geometrycznej o takim numerze  - musisz podać właściwy numer");
            //zgaszenie kontrolki errorProvider1
            errorProvider1.Dispose();
            //przejście do następnej figury geometrycznej
            if (mgIndeksFigury < mgLFG.Count)
            {
                mgIndeksFigury++;
            }
            else
            {
                mgIndeksFigury = 0;
            }
            // wyświetlenie aktualnego numeru figury
            txtNumerFiguryGeometrycznej.Text = mgIndeksFigury.ToString();
            // wyczyszczenie Rysownicy
            mgRysownica.Clear(pictureBox1.BackColor);
            // wyznaczenie rozmiarów Rysownicy
            int mgXmax = pictureBox1.Width;
            int mgYmax = pictureBox1.Height;
            //monitoring Indeks Figur oraz LFG.Count
            MessageBox.Show("Aktualna wartość indeksu figury = " + mgIndeksFigury.ToString()
                + "Aktualna wartość LFG.Count" + mgLFG.Count.ToString());
            //przesunięcie figury geometrycznej do środka Rysownicy (i jej wykreślenie)
            mgLFG[mgIndeksFigury].mgPrzesunDoNowegoXY(pictureBox1, mgRysownica, mgXmax / 2, mgYmax / 2);
            //odświeżenie rysownicy
            pictureBox1.Refresh();

        }

        private void btnPoprzedni_Click(object sender, EventArgs e)
        {
            //ustawienie domyślnego numeru figury, która będzie pokazana jako pierwsza
            int mgIndeksFigury = 0;
            //sprawdzenie numeru wpisanego przez użytkownika
            while (!int.TryParse(txtNumerFiguryGeometrycznej.Text, out mgIndeksFigury))
                errorProvider1.SetError(txtNumerFiguryGeometrycznej, "ERROR: musisz podać numer figury geometrycznej");
            //sprawdzenie czy podany numer jest numerem dozwolonym
            if ((mgIndeksFigury < 0) || (mgIndeksFigury >= mgLFG.Count))
                errorProvider1.SetError(txtNumerFiguryGeometrycznej, "ERROR: nie ma figury geometrycznej o takim numerze  - musisz podać właściwy numer");
            //zgaszenie kontrolki errorProvider1
            errorProvider1.Dispose();
            //przejście do następnej figury geometrycznej
            if (mgIndeksFigury > 0)
            {
                mgIndeksFigury--;
            }
            else
            {
                mgIndeksFigury = mgLFG.Count - 1;
            }
            //wyświetlenie aktualnego numeru figury
            txtNumerFiguryGeometrycznej.Text = mgIndeksFigury.ToString();
            //wyczyszczenie Rysownicy
            mgRysownica.Clear(pictureBox1.BackColor);
            //wyznaczenie rozmiarów Rysownicy
            int mgXmax = pictureBox1.Width;
            int mgYmax = pictureBox1.Height;
            //przesunięcie figury geometrycznej do środka Rysownicy (i jej wykreślenie)
            mgLFG[mgIndeksFigury].mgPrzesunDoNowegoXY(pictureBox1, mgRysownica, mgXmax / 2, mgYmax / 2);
            //odświeżenie Rysownicy
            pictureBox1.Refresh();
        }

        private void btnWylaczenieSlajdera_Click(object sender, EventArgs e)
        {
            //wyłączenie zegara (trochę na wszelki wypadek)
            timer1.Enabled = false;
            //włączenie przycisku Włącz pokaz
            btnWlaczenieSlajdu.Enabled = true;
            //wyłączenie przycisku dla pokazu figur w trybie przyciskowym
            btnNastepny.Enabled = false;
            btnPoprzedni.Enabled = false;
            //wyłączenie przycisku Wyłączenie Slajdera
            btnWylaczenieSlajdera.Enabled = false;
        }

        private void btnPrzesunFiguryGeometryczne_Click(object sender, EventArgs e)
        {
            //wyczyszczenie Rysownicy
            mgRysownica.Clear(pictureBox1.BackColor);
            //odczytanie rozmiaru pictureBox
            int mgXmax = pictureBox1.Width;
            int mgYmax = pictureBox1.Height;
            //utworzenie egzemplarza generatora liczb losowych
            Random mgLiczbaLosowa = new Random();
            //deklaracje pomocnicze dla współrzędnych nowego wylosowanego punktu (położenia figury)
            int mgXp, mgYp;
            //losowanie położenia dla każdej figury geometrycznej z listy LFG
            for (int mgi = 0; mgi < mgLFG.Count; mgi++)
            {//wylosowanie nowych współrzędnych X i Y dla i-tej figury
                mgXp = mgLiczbaLosowa.Next(mgMargines, mgXmax - mgMargines);
                mgYp = mgLiczbaLosowa.Next(mgMargines, mgYmax - mgMargines);
                //przesunięcie i-tej figury geometrycznej do punktu o współrzędnych Xp i Yp
                mgLFG[mgi].mgPrzesunDoNowegoXY(pictureBox1, mgRysownica, mgXp, mgYp);
            }
            pictureBox1.Refresh();
        }

        private void btnWlaczenieSlajdera_Load(object sender, EventArgs e)
        {

        }

        private void btnZmianaTla_Click(object sender, EventArgs e)
        {
            ColorDialog mgOknoKolorów = new ColorDialog();
            mgOknoKolorów.Color = Color.WhiteSmoke;
            if (mgOknoKolorów.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = mgOknoKolorów.Color;
                txtWziernikKolorTla.BackColor = mgOknoKolorów.Color;
            }
        }

        private void RbLiniaKreslona_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnZmianakoloruPiora_Click(object sender, EventArgs e)
        {
            ColorDialog mgOknoKolorów = new ColorDialog();
            mgOknoKolorów.Color = Color.WhiteSmoke;
            if (mgOknoKolorów.ShowDialog() == DialogResult.OK)
            {

                mgpioro.Color = mgOknoKolorów.Color;
                textBox1.BackColor = mgOknoKolorów.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnZmianaKoloruPedzla_Click(object sender, EventArgs e)
        {
            ColorDialog mgOknoKolorów = new ColorDialog();
            mgOknoKolorów.Color = Color.WhiteSmoke;
            if (mgOknoKolorów.ShowDialog() == DialogResult.OK)
            {
                mgpioro.Color = mgOknoKolorów.Color;
                txtWziernikKoloruPedzla.BackColor = mgOknoKolorów.Color;
            }
        }



        private void tbGrubośćLinii_Scroll(object sender, EventArgs e)
        {
            mgpioro.Width = tbGrubośćLinii.Value;
            txtGrubLinii.Text = tbGrubośćLinii.Value.ToString();
        }

        private void txtGrubLinii_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bmp|*.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
                pictureBox1.Image.Save(dialog.FileName);

        }

        private void btnOdczytzPliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "bmp|*.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
                pictureBox1.Image= Image.FromFile(dialog.FileName);
           

        }

        private void rtbSterowanieZegarem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ołówekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbGumka.Checked = false;
            rbOłówek.Checked = true;
        }

        private void gumkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbGumka.Checked = true;
            rbOłówek.Checked = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void zapiszDoBitmapyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bmp|*.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
                pictureBox1.Image.Save(dialog.FileName);
        }

        private void odczytajZBitmapyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "bmp|*.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
                pictureBox1.Image = Image.FromFile(dialog.FileName);
        }
    }




    public class mgPunkt
    {
        //deklaracja typu wyliczeniowego dla identyfikacji rodzaju figury geometrycznej
        public enum mgTypFiguryGeometrycznej : uint
        {
            mgFG_PUNKT = 0, mgFG_LINIA, mgFG_ELIPSA, mgFG_PROSTOKAT, mgFG_Okrag, mgFG_Kwadrat
            //itd.
        }
        //deklaracje klasy punkt
        const int mgRozmiarPunktu = 10;
        //deklaracje atrybutów (zmiennych) wspólnych dla wszystkich figur geometrycznych
        protected mgTypFiguryGeometrycznej mgTypFigury;
        protected int mgX;
        protected int mgY;
        protected Color mgKolorLinii;
        protected bool mgWidoczny; // true - wykreślony, false - niewykreślony
        //deklaracje wspolne ale tylko dla klas pochodnych (ale nie dla Punkt)
        protected DashStyle mgStylLinii;
        protected int mgGruboscLinii;
        //deklaracja konstruktorów
        public mgPunkt()
        {
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_PUNKT;
            mgX = 0;
            mgY = 0;
            mgKolorLinii = Color.Black;
            mgStylLinii = DashStyle.Solid;
            mgGruboscLinii = 1;
            mgWidoczny = false;

        }
        public mgPunkt(int mgx, int mgy)
        {
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_PUNKT;
            mgX = mgx;
            mgY = mgy;
            mgKolorLinii = Color.Black;
            mgWidoczny = false;
            mgGruboscLinii = 1;
            mgStylLinii = DashStyle.Solid;

        }

        public mgPunkt(int mgx, int mgy, Color mgKolor)
        {
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_PUNKT;
            mgX = mgx;
            mgY = mgy;
            mgKolorLinii = mgKolor;
            mgWidoczny = false;
            mgGruboscLinii = 1;
            mgStylLinii = DashStyle.Solid;
        }
        public mgPunkt(int mgx, int mgy, Color mgKolor, DashStyle mgStylLinii, int mgGruboscLinii)
        {
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_PUNKT;
            mgX = mgx;
            mgY = mgy;
            this.mgKolorLinii = mgKolor;
            mgWidoczny = false;
            this.mgGruboscLinii = mgGruboscLinii;
            this.mgStylLinii = mgStylLinii;
        }


        //deklaracja metod publicznych

        public void mgPrzesunDoNowegoXY(Control mgKontrolka, Graphics mgPowierzchniaGraficzna, int mgx, int mgy)
        {
            mgWymaz(mgKontrolka, mgPowierzchniaGraficzna);
            { }
            mgUstawXY(mgx, mgy);
            { }
            mgWykresl(mgPowierzchniaGraficzna);
            { }
        }
        public void mgFormatujFG(Color mgKolor, DashStyle mgStylLinii, int mgGrubość)
        {
            mgKolorLinii = mgKolor;
            this.mgStylLinii = mgStylLinii; // muszę użyć this bo argumenty klasy i parametry metody mają te same nazwy
            mgGruboscLinii = mgGrubość;
        }
        // deklaracja metod wirtualnych
        public virtual void mgWykresl(Graphics mgPowierzchniaGraficzna)
        {
            //wykreślenie punktu jako wypełnionego (elipsy)
            //deklaracja pędzla
            SolidBrush mgPędzel = new SolidBrush(this.mgKolorLinii);
            mgPowierzchniaGraficzna.FillEllipse(mgPędzel, mgX - mgRozmiarPunktu / 2, mgY - mgRozmiarPunktu / 2, mgRozmiarPunktu, mgRozmiarPunktu);
            //ustawienie stanu widoczności punktu
            mgWidoczny = true;
            // zwolnienie pędzla
            mgPędzel.Dispose();
        }
        public virtual void mgWymaz(Control mgKontrolka, Graphics mgPowierzchniaGraficzna)
        {
            if (mgWidoczny)
            {
                SolidBrush mgPędzel = new SolidBrush(mgKontrolka.BackColor);
                mgPowierzchniaGraficzna.FillEllipse(mgPędzel, mgX - mgRozmiarPunktu / 2, mgY - mgRozmiarPunktu / 2, mgRozmiarPunktu, mgRozmiarPunktu);
                mgWidoczny = false;
                // zwolnienie pędzla
                mgPędzel.Dispose();
            }
        }
        public virtual void mgUstawXY(int mgx, int mgy)
        {
            mgX = mgx;
            mgY = mgy;
        }
    }
    public class mgElipsa : mgPunkt
    {
        protected int mgOśDuża;
        protected int mgOśMała;



        public mgElipsa(int mgx, int mgy, int mgOśDuża, int mgOśMała) : base(mgx, mgy)
        {
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_ELIPSA;
            this.mgOśDuża = mgOśDuża;
            this.mgOśMała = mgOśMała;
            mgGruboscLinii = 1;
        }
        public mgElipsa(int mgx, int mgy, int mgOśDuża, int mgOśMała, Color mgKolor, DashStyle mgStylLinii, int mgGruboscLinii) : base(mgx, mgy, mgKolor, mgStylLinii, mgGruboscLinii)
        {
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_ELIPSA;
            this.mgOśDuża = mgOśDuża;
            this.mgOśMała = mgOśMała;
        }

    }
    public class mgOkrąg : mgElipsa
    {
        protected int mgPromień;

        public mgOkrąg(int mgx, int mgy, int mgPromień) : base(mgx, mgy, 2 * mgPromień, 2 * mgPromień)
        {
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_Okrag;
            this.mgPromień = mgPromień;
        }

    }
    public class mgProstokąt : mgPunkt
    {
        protected int mgSzerokość;
        protected int mgWysokość;
        public mgProstokąt(int mgx, int mgy, int mgSzerokość, int mgWysokość) : base(mgx, mgy)
        {
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_PROSTOKAT;
            this.mgSzerokość = mgSzerokość;
            this.mgWysokość = mgWysokość;
            mgGruboscLinii = 1;
        }


    }
    public class mgKwadrat : mgProstokąt
    {
        protected int mgSzer;
        public mgKwadrat(int mgx, int mgy, int mgSzerokość) : base(mgx, mgy, mgSzerokość, mgSzerokość)
        {
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_Kwadrat;
            this.mgSzerokość = mgSzer;
            mgGruboscLinii = 1;
        }
    }
    public class mgLinia : mgPunkt
    {
        //deklaracje uszczegóławiające klasę linia
        int mgXk, mgYk;
        //deklaracja konstruktorów
        public mgLinia(int mgXpoczatku, int mgYpoczatku, int mgXkonca, int mgYkonca) : base(mgXpoczatku, mgYpoczatku)
        {
            this.mgXk = mgXkonca; // nie musiałem tego zrobić bo nazwy są inne, ale można
            mgYk = mgYkonca;
            mgTypFigury = mgTypFiguryGeometrycznej.mgFG_LINIA;
        }
        //nadpisanie metod wirtualnych zadeklarowanych w klasie punkt
        public override void mgWykresl(Graphics mgPowierzchniaGraficzna)
        {
            //utworzenie egzemplarza pióra
            Pen mgpioro = new Pen(mgKolorLinii, mgGruboscLinii);
            mgpioro.DashStyle = mgStylLinii;
            //wykreślenie linii
            mgPowierzchniaGraficzna.DrawLine(mgpioro, mgX, mgY, mgXk, mgYk);
            mgWidoczny = true;
            mgpioro.Dispose();
        }
        public override void mgWymaz(Control mgKontrolka, Graphics mgPowierzchniaGraficzna)
        {
            if (mgWidoczny)
            {//utworzenie egzemplarza pióra
                Pen mgpioro = new Pen(mgKontrolka.BackColor, mgGruboscLinii);
                mgpioro.DashStyle = mgStylLinii;
                //wykreślenie linii
                mgPowierzchniaGraficzna.DrawLine(mgpioro, mgX, mgY, mgXk, mgYk);
                mgWidoczny = false;
                mgpioro.Dispose();

            }
        }
        public override void mgUstawXY(int mgx, int mgy)
        {
            mgX = mgx;
            mgY = mgy;
        }

    }
}

