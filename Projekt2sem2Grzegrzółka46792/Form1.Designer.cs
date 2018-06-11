namespace projekt22
{
    partial class btnWlaczenieSlajdera
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnWlaczenieSlajdera));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWziewnik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbLiniaKreslona = new System.Windows.Forms.RadioButton();
            this.RbKwadrat = new System.Windows.Forms.RadioButton();
            this.RbProstokat = new System.Windows.Forms.RadioButton();
            this.RbOkrag = new System.Windows.Forms.RadioButton();
            this.RbElipsa = new System.Windows.Forms.RadioButton();
            this.RbLinia = new System.Windows.Forms.RadioButton();
            this.RBPkt = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnWlaczenieSlajdu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPrzyciskowy = new System.Windows.Forms.RadioButton();
            this.rtbSterowanieZegarem = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumerFiguryGeometrycznej = new System.Windows.Forms.TextBox();
            this.btnNastepny = new System.Windows.Forms.Button();
            this.btnPoprzedni = new System.Windows.Forms.Button();
            this.btnWylaczenieSlajdera = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrzesunFiguryGeometryczne = new System.Windows.Forms.Button();
            this.btnZmianaTla = new System.Windows.Forms.Button();
            this.btnZmianakoloruPiora = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnZmianaKoloruPedzla = new System.Windows.Forms.Button();
            this.txtWziernikKoloruPedzla = new System.Windows.Forms.TextBox();
            this.txtWziernikKolorTla = new System.Windows.Forms.TextBox();
            this.tbGrubośćLinii = new System.Windows.Forms.TrackBar();
            this.lbGruboscLinii = new System.Windows.Forms.Label();
            this.txtGrubLinii = new System.Windows.Forms.TextBox();
            this.btnZapisdoPliku = new System.Windows.Forms.Button();
            this.btnOdczytzPliku = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbOłówek = new System.Windows.Forms.RadioButton();
            this.rbGumka = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Plik = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDoBitmapyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytajZBitmapyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GumkaOłówek = new System.Windows.Forms.ToolStripMenuItem();
            this.ołówekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gumkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrubośćLinii)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(375, 120);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(839, 462);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Współrzędne X i Y aktualnego położenia myszki ";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(652, 46);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 17);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X:";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(891, 46);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 17);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1212, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 47);
            this.panel1.TabIndex = 4;
            // 
            // lblWziewnik
            // 
            this.lblWziewnik.AutoSize = true;
            this.lblWziewnik.Location = new System.Drawing.Point(1267, 84);
            this.lblWziewnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWziewnik.Name = "lblWziewnik";
            this.lblWziewnik.Size = new System.Drawing.Size(143, 17);
            this.lblWziewnik.TabIndex = 5;
            this.lblWziewnik.Text = "Wziernik kreślony linii";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbLiniaKreslona);
            this.groupBox1.Controls.Add(this.RbKwadrat);
            this.groupBox1.Controls.Add(this.RbProstokat);
            this.groupBox1.Controls.Add(this.RbOkrag);
            this.groupBox1.Controls.Add(this.RbElipsa);
            this.groupBox1.Controls.Add(this.RbLinia);
            this.groupBox1.Controls.Add(this.RBPkt);
            this.groupBox1.Location = new System.Drawing.Point(384, 620);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(923, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz jedną z figur geometrycznych ";
            // 
            // RbLiniaKreslona
            // 
            this.RbLiniaKreslona.AutoSize = true;
            this.RbLiniaKreslona.Location = new System.Drawing.Point(764, 25);
            this.RbLiniaKreslona.Margin = new System.Windows.Forms.Padding(4);
            this.RbLiniaKreslona.Name = "RbLiniaKreslona";
            this.RbLiniaKreslona.Size = new System.Drawing.Size(121, 21);
            this.RbLiniaKreslona.TabIndex = 6;
            this.RbLiniaKreslona.Text = "Linia kreślona ";
            this.RbLiniaKreslona.UseVisualStyleBackColor = true;
            this.RbLiniaKreslona.CheckedChanged += new System.EventHandler(this.RbLiniaKreslona_CheckedChanged);
            // 
            // RbKwadrat
            // 
            this.RbKwadrat.AutoSize = true;
            this.RbKwadrat.Location = new System.Drawing.Point(637, 25);
            this.RbKwadrat.Margin = new System.Windows.Forms.Padding(4);
            this.RbKwadrat.Name = "RbKwadrat";
            this.RbKwadrat.Size = new System.Drawing.Size(80, 21);
            this.RbKwadrat.TabIndex = 5;
            this.RbKwadrat.Text = "Kwadrat";
            this.RbKwadrat.UseVisualStyleBackColor = true;
            // 
            // RbProstokat
            // 
            this.RbProstokat.AutoSize = true;
            this.RbProstokat.Location = new System.Drawing.Point(511, 25);
            this.RbProstokat.Margin = new System.Windows.Forms.Padding(4);
            this.RbProstokat.Name = "RbProstokat";
            this.RbProstokat.Size = new System.Drawing.Size(89, 21);
            this.RbProstokat.TabIndex = 4;
            this.RbProstokat.Text = "Prostokąt";
            this.RbProstokat.UseVisualStyleBackColor = true;
            // 
            // RbOkrag
            // 
            this.RbOkrag.AutoSize = true;
            this.RbOkrag.Location = new System.Drawing.Point(401, 25);
            this.RbOkrag.Margin = new System.Windows.Forms.Padding(4);
            this.RbOkrag.Name = "RbOkrag";
            this.RbOkrag.Size = new System.Drawing.Size(68, 21);
            this.RbOkrag.TabIndex = 3;
            this.RbOkrag.Text = "Okrąg";
            this.RbOkrag.UseVisualStyleBackColor = true;
            // 
            // RbElipsa
            // 
            this.RbElipsa.AutoSize = true;
            this.RbElipsa.Location = new System.Drawing.Point(272, 25);
            this.RbElipsa.Margin = new System.Windows.Forms.Padding(4);
            this.RbElipsa.Name = "RbElipsa";
            this.RbElipsa.Size = new System.Drawing.Size(67, 21);
            this.RbElipsa.TabIndex = 2;
            this.RbElipsa.Text = "Elipsa";
            this.RbElipsa.UseVisualStyleBackColor = true;
            // 
            // RbLinia
            // 
            this.RbLinia.AutoSize = true;
            this.RbLinia.Location = new System.Drawing.Point(120, 25);
            this.RbLinia.Margin = new System.Windows.Forms.Padding(4);
            this.RbLinia.Name = "RbLinia";
            this.RbLinia.Size = new System.Drawing.Size(104, 21);
            this.RbLinia.TabIndex = 1;
            this.RbLinia.Text = "Linia Prosta";
            this.RbLinia.UseVisualStyleBackColor = true;
            // 
            // RBPkt
            // 
            this.RBPkt.AutoSize = true;
            this.RBPkt.Checked = true;
            this.RBPkt.Location = new System.Drawing.Point(9, 25);
            this.RBPkt.Margin = new System.Windows.Forms.Padding(4);
            this.RBPkt.Name = "RBPkt";
            this.RBPkt.Size = new System.Drawing.Size(65, 21);
            this.RBPkt.TabIndex = 0;
            this.RBPkt.TabStop = true;
            this.RBPkt.Text = "Punkt";
            this.RBPkt.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnWlaczenieSlajdu
            // 
            this.btnWlaczenieSlajdu.Location = new System.Drawing.Point(1270, 161);
            this.btnWlaczenieSlajdu.Name = "btnWlaczenieSlajdu";
            this.btnWlaczenieSlajdu.Size = new System.Drawing.Size(149, 91);
            this.btnWlaczenieSlajdu.TabIndex = 7;
            this.btnWlaczenieSlajdu.Text = "Włączenie pokazu (slajdera) figur geometrycznych\r\n";
            this.btnWlaczenieSlajdu.UseVisualStyleBackColor = true;
            this.btnWlaczenieSlajdu.Click += new System.EventHandler(this.btnWlaczenieSlajdu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPrzyciskowy);
            this.groupBox2.Controls.Add(this.rtbSterowanieZegarem);
            this.groupBox2.Location = new System.Drawing.Point(1270, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz tryb pokazu";
            // 
            // rdbPrzyciskowy
            // 
            this.rdbPrzyciskowy.AutoSize = true;
            this.rdbPrzyciskowy.Location = new System.Drawing.Point(6, 61);
            this.rdbPrzyciskowy.Name = "rdbPrzyciskowy";
            this.rdbPrzyciskowy.Size = new System.Drawing.Size(172, 21);
            this.rdbPrzyciskowy.TabIndex = 10;
            this.rdbPrzyciskowy.Text = "Sterowany przyciskami";
            this.rdbPrzyciskowy.UseVisualStyleBackColor = true;
            // 
            // rtbSterowanieZegarem
            // 
            this.rtbSterowanieZegarem.AutoSize = true;
            this.rtbSterowanieZegarem.Checked = true;
            this.rtbSterowanieZegarem.Location = new System.Drawing.Point(6, 21);
            this.rtbSterowanieZegarem.Name = "rtbSterowanieZegarem";
            this.rtbSterowanieZegarem.Size = new System.Drawing.Size(154, 21);
            this.rtbSterowanieZegarem.TabIndex = 9;
            this.rtbSterowanieZegarem.TabStop = true;
            this.rtbSterowanieZegarem.Text = "Sterowany zegarem";
            this.rtbSterowanieZegarem.UseVisualStyleBackColor = true;
            this.rtbSterowanieZegarem.CheckedChanged += new System.EventHandler(this.rtbSterowanieZegarem_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1267, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numer figury geometrycznej";
            // 
            // txtNumerFiguryGeometrycznej
            // 
            this.txtNumerFiguryGeometrycznej.Location = new System.Drawing.Point(1304, 407);
            this.txtNumerFiguryGeometrycznej.Name = "txtNumerFiguryGeometrycznej";
            this.txtNumerFiguryGeometrycznej.Size = new System.Drawing.Size(100, 22);
            this.txtNumerFiguryGeometrycznej.TabIndex = 10;
            // 
            // btnNastepny
            // 
            this.btnNastepny.Enabled = false;
            this.btnNastepny.Location = new System.Drawing.Point(1270, 435);
            this.btnNastepny.Name = "btnNastepny";
            this.btnNastepny.Size = new System.Drawing.Size(83, 37);
            this.btnNastepny.TabIndex = 11;
            this.btnNastepny.Text = "Następna";
            this.btnNastepny.UseVisualStyleBackColor = true;
            this.btnNastepny.Click += new System.EventHandler(this.btnNastepny_Click);
            // 
            // btnPoprzedni
            // 
            this.btnPoprzedni.Enabled = false;
            this.btnPoprzedni.Location = new System.Drawing.Point(1359, 435);
            this.btnPoprzedni.Name = "btnPoprzedni";
            this.btnPoprzedni.Size = new System.Drawing.Size(89, 37);
            this.btnPoprzedni.TabIndex = 12;
            this.btnPoprzedni.Text = "Poprzednia";
            this.btnPoprzedni.UseVisualStyleBackColor = true;
            this.btnPoprzedni.Click += new System.EventHandler(this.btnPoprzedni_Click);
            // 
            // btnWylaczenieSlajdera
            // 
            this.btnWylaczenieSlajdera.Enabled = false;
            this.btnWylaczenieSlajdera.Location = new System.Drawing.Point(1223, 477);
            this.btnWylaczenieSlajdera.Name = "btnWylaczenieSlajdera";
            this.btnWylaczenieSlajdera.Size = new System.Drawing.Size(130, 68);
            this.btnWylaczenieSlajdera.TabIndex = 13;
            this.btnWylaczenieSlajdera.Text = "Wyłącz pokaz figur geometrycznych";
            this.btnWylaczenieSlajdera.UseVisualStyleBackColor = true;
            this.btnWylaczenieSlajdera.Click += new System.EventHandler(this.btnWylaczenieSlajdera_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPrzesunFiguryGeometryczne
            // 
            this.btnPrzesunFiguryGeometryczne.Location = new System.Drawing.Point(1359, 478);
            this.btnPrzesunFiguryGeometryczne.Name = "btnPrzesunFiguryGeometryczne";
            this.btnPrzesunFiguryGeometryczne.Size = new System.Drawing.Size(120, 67);
            this.btnPrzesunFiguryGeometryczne.TabIndex = 14;
            this.btnPrzesunFiguryGeometryczne.Text = "Przesuń do nowego położenia XY (wybranego losowo)";
            this.btnPrzesunFiguryGeometryczne.UseVisualStyleBackColor = true;
            this.btnPrzesunFiguryGeometryczne.Click += new System.EventHandler(this.btnPrzesunFiguryGeometryczne_Click);
            // 
            // btnZmianaTla
            // 
            this.btnZmianaTla.Location = new System.Drawing.Point(12, 645);
            this.btnZmianaTla.Name = "btnZmianaTla";
            this.btnZmianaTla.Size = new System.Drawing.Size(114, 51);
            this.btnZmianaTla.TabIndex = 15;
            this.btnZmianaTla.Text = "Zmiana koloru tła";
            this.btnZmianaTla.UseVisualStyleBackColor = true;
            this.btnZmianaTla.Click += new System.EventHandler(this.btnZmianaTla_Click);
            // 
            // btnZmianakoloruPiora
            // 
            this.btnZmianakoloruPiora.Location = new System.Drawing.Point(1485, 483);
            this.btnZmianakoloruPiora.Name = "btnZmianakoloruPiora";
            this.btnZmianakoloruPiora.Size = new System.Drawing.Size(114, 51);
            this.btnZmianakoloruPiora.TabIndex = 16;
            this.btnZmianakoloruPiora.Text = "Zmiana koloru pióra";
            this.btnZmianakoloruPiora.UseVisualStyleBackColor = true;
            this.btnZmianakoloruPiora.Click += new System.EventHandler(this.btnZmianakoloruPiora_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(1485, 540);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnZmianaKoloruPedzla
            // 
            this.btnZmianaKoloruPedzla.Location = new System.Drawing.Point(1485, 568);
            this.btnZmianaKoloruPedzla.Name = "btnZmianaKoloruPedzla";
            this.btnZmianaKoloruPedzla.Size = new System.Drawing.Size(114, 51);
            this.btnZmianaKoloruPedzla.TabIndex = 18;
            this.btnZmianaKoloruPedzla.Text = "Zmiana koloru pedzla";
            this.btnZmianaKoloruPedzla.UseVisualStyleBackColor = true;
            this.btnZmianaKoloruPedzla.Click += new System.EventHandler(this.btnZmianaKoloruPedzla_Click);
            // 
            // txtWziernikKoloruPedzla
            // 
            this.txtWziernikKoloruPedzla.BackColor = System.Drawing.SystemColors.Control;
            this.txtWziernikKoloruPedzla.Location = new System.Drawing.Point(1485, 625);
            this.txtWziernikKoloruPedzla.Name = "txtWziernikKoloruPedzla";
            this.txtWziernikKoloruPedzla.Size = new System.Drawing.Size(114, 22);
            this.txtWziernikKoloruPedzla.TabIndex = 19;
            // 
            // txtWziernikKolorTla
            // 
            this.txtWziernikKolorTla.BackColor = System.Drawing.Color.Beige;
            this.txtWziernikKolorTla.Location = new System.Drawing.Point(132, 659);
            this.txtWziernikKolorTla.Name = "txtWziernikKolorTla";
            this.txtWziernikKolorTla.Size = new System.Drawing.Size(114, 22);
            this.txtWziernikKolorTla.TabIndex = 20;
            // 
            // tbGrubośćLinii
            // 
            this.tbGrubośćLinii.Location = new System.Drawing.Point(1434, 181);
            this.tbGrubośćLinii.Minimum = 1;
            this.tbGrubośćLinii.Name = "tbGrubośćLinii";
            this.tbGrubośćLinii.Size = new System.Drawing.Size(104, 56);
            this.tbGrubośćLinii.TabIndex = 21;
            this.tbGrubośćLinii.Value = 1;
            this.tbGrubośćLinii.Scroll += new System.EventHandler(this.tbGrubośćLinii_Scroll);
            // 
            // lbGruboscLinii
            // 
            this.lbGruboscLinii.AutoSize = true;
            this.lbGruboscLinii.Location = new System.Drawing.Point(1447, 161);
            this.lbGruboscLinii.Name = "lbGruboscLinii";
            this.lbGruboscLinii.Size = new System.Drawing.Size(91, 17);
            this.lbGruboscLinii.TabIndex = 22;
            this.lbGruboscLinii.Text = "Grubość Linii";
            // 
            // txtGrubLinii
            // 
            this.txtGrubLinii.Location = new System.Drawing.Point(1438, 215);
            this.txtGrubLinii.Name = "txtGrubLinii";
            this.txtGrubLinii.Size = new System.Drawing.Size(100, 22);
            this.txtGrubLinii.TabIndex = 23;
            this.txtGrubLinii.Text = "1";
            this.txtGrubLinii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrubLinii.TextChanged += new System.EventHandler(this.txtGrubLinii_TextChanged);
            // 
            // btnZapisdoPliku
            // 
            this.btnZapisdoPliku.Location = new System.Drawing.Point(1314, 581);
            this.btnZapisdoPliku.Name = "btnZapisdoPliku";
            this.btnZapisdoPliku.Size = new System.Drawing.Size(149, 38);
            this.btnZapisdoPliku.TabIndex = 24;
            this.btnZapisdoPliku.Text = "Zapis do pliku BMP";
            this.btnZapisdoPliku.UseVisualStyleBackColor = true;
            this.btnZapisdoPliku.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdczytzPliku
            // 
            this.btnOdczytzPliku.Location = new System.Drawing.Point(1314, 625);
            this.btnOdczytzPliku.Name = "btnOdczytzPliku";
            this.btnOdczytzPliku.Size = new System.Drawing.Size(149, 38);
            this.btnOdczytzPliku.TabIndex = 25;
            this.btnOdczytzPliku.Text = "Odczyt z pliku BMP";
            this.btnOdczytzPliku.UseVisualStyleBackColor = true;
            this.btnOdczytzPliku.Click += new System.EventHandler(this.btnOdczytzPliku_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOłówek);
            this.groupBox3.Controls.Add(this.rbGumka);
            this.groupBox3.Location = new System.Drawing.Point(1458, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gumka / Ołówek";
            // 
            // rbOłówek
            // 
            this.rbOłówek.AutoSize = true;
            this.rbOłówek.Checked = true;
            this.rbOłówek.Location = new System.Drawing.Point(6, 21);
            this.rbOłówek.Name = "rbOłówek";
            this.rbOłówek.Size = new System.Drawing.Size(75, 21);
            this.rbOłówek.TabIndex = 10;
            this.rbOłówek.TabStop = true;
            this.rbOłówek.Text = "Ołówek";
            this.rbOłówek.UseVisualStyleBackColor = true;
            // 
            // rbGumka
            // 
            this.rbGumka.AutoSize = true;
            this.rbGumka.Location = new System.Drawing.Point(7, 61);
            this.rbGumka.Name = "rbGumka";
            this.rbGumka.Size = new System.Drawing.Size(74, 21);
            this.rbGumka.TabIndex = 9;
            this.rbGumka.Text = "Gumka";
            this.rbGumka.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Plik,
            this.GumkaOłówek});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1712, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Plik
            // 
            this.Plik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszDoBitmapyToolStripMenuItem,
            this.odczytajZBitmapyToolStripMenuItem,
            this.wyjdźToolStripMenuItem});
            this.Plik.Name = "Plik";
            this.Plik.Size = new System.Drawing.Size(44, 24);
            this.Plik.Text = "Plik";
            // 
            // zapiszDoBitmapyToolStripMenuItem
            // 
            this.zapiszDoBitmapyToolStripMenuItem.Name = "zapiszDoBitmapyToolStripMenuItem";
            this.zapiszDoBitmapyToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.zapiszDoBitmapyToolStripMenuItem.Text = "Zapisz do bitmapy";
            this.zapiszDoBitmapyToolStripMenuItem.Click += new System.EventHandler(this.zapiszDoBitmapyToolStripMenuItem_Click);
            // 
            // odczytajZBitmapyToolStripMenuItem
            // 
            this.odczytajZBitmapyToolStripMenuItem.Name = "odczytajZBitmapyToolStripMenuItem";
            this.odczytajZBitmapyToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.odczytajZBitmapyToolStripMenuItem.Text = "Odczytaj z bitmapy";
            this.odczytajZBitmapyToolStripMenuItem.Click += new System.EventHandler(this.odczytajZBitmapyToolStripMenuItem_Click);
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            // 
            // GumkaOłówek
            // 
            this.GumkaOłówek.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ołówekToolStripMenuItem,
            this.gumkaToolStripMenuItem});
            this.GumkaOłówek.Name = "GumkaOłówek";
            this.GumkaOłówek.Size = new System.Drawing.Size(131, 24);
            this.GumkaOłówek.Text = "Ołówek / Gumka";
            // 
            // ołówekToolStripMenuItem
            // 
            this.ołówekToolStripMenuItem.Name = "ołówekToolStripMenuItem";
            this.ołówekToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.ołówekToolStripMenuItem.Text = "Ołówek";
            this.ołówekToolStripMenuItem.Click += new System.EventHandler(this.ołówekToolStripMenuItem_Click);
            // 
            // gumkaToolStripMenuItem
            // 
            this.gumkaToolStripMenuItem.Name = "gumkaToolStripMenuItem";
            this.gumkaToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.gumkaToolStripMenuItem.Text = "Gumka";
            this.gumkaToolStripMenuItem.Click += new System.EventHandler(this.gumkaToolStripMenuItem_Click);
            // 
            // btnWlaczenieSlajdera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 708);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOdczytzPliku);
            this.Controls.Add(this.btnZapisdoPliku);
            this.Controls.Add(this.txtGrubLinii);
            this.Controls.Add(this.lbGruboscLinii);
            this.Controls.Add(this.tbGrubośćLinii);
            this.Controls.Add(this.txtWziernikKolorTla);
            this.Controls.Add(this.txtWziernikKoloruPedzla);
            this.Controls.Add(this.btnZmianaKoloruPedzla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnZmianakoloruPiora);
            this.Controls.Add(this.btnZmianaTla);
            this.Controls.Add(this.btnPrzesunFiguryGeometryczne);
            this.Controls.Add(this.btnWylaczenieSlajdera);
            this.Controls.Add(this.btnPoprzedni);
            this.Controls.Add(this.btnNastepny);
            this.Controls.Add(this.txtNumerFiguryGeometrycznej);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnWlaczenieSlajdu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWziewnik);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "btnWlaczenieSlajdera";
            this.Text = "Mój MiniPaint by Mateusz Grzegrzółka 46792";
            this.Load += new System.EventHandler(this.btnWlaczenieSlajdera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrubośćLinii)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWziewnik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbLiniaKreslona;
        private System.Windows.Forms.RadioButton RbKwadrat;
        private System.Windows.Forms.RadioButton RbProstokat;
        private System.Windows.Forms.RadioButton RbOkrag;
        private System.Windows.Forms.RadioButton RbElipsa;
        private System.Windows.Forms.RadioButton RbLinia;
        private System.Windows.Forms.RadioButton RBPkt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnWlaczenieSlajdu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rtbSterowanieZegarem;
        private System.Windows.Forms.RadioButton rdbPrzyciskowy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumerFiguryGeometrycznej;
        private System.Windows.Forms.Button btnNastepny;
        private System.Windows.Forms.Button btnPoprzedni;
        private System.Windows.Forms.Button btnWylaczenieSlajdera;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPrzesunFiguryGeometryczne;
        private System.Windows.Forms.Button btnZmianaTla;
        private System.Windows.Forms.Button btnZmianakoloruPiora;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtWziernikKoloruPedzla;
        private System.Windows.Forms.Button btnZmianaKoloruPedzla;
        private System.Windows.Forms.TextBox txtWziernikKolorTla;
        private System.Windows.Forms.Label lbGruboscLinii;
        private System.Windows.Forms.TrackBar tbGrubośćLinii;
        private System.Windows.Forms.TextBox txtGrubLinii;
        private System.Windows.Forms.Button btnZapisdoPliku;
        private System.Windows.Forms.Button btnOdczytzPliku;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbOłówek;
        private System.Windows.Forms.RadioButton rbGumka;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Plik;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoBitmapyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytajZBitmapyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GumkaOłówek;
        private System.Windows.Forms.ToolStripMenuItem ołówekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gumkaToolStripMenuItem;
    }
}

