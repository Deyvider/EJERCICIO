namespace InfoMuni
{
    public partial class Form1 : Form
    {
        //create ArrayList
        private List<Municipio> mpios = new List<Municipio>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create objects municipios
            Municipio armer�a = new Municipio();
            armer�a.ciudad = "Armer�a";
            armer�a.poblacion = "27,626";
            armer�a.extension = "341 km2";
            armer�a.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\arm.png");
            mpios.Add(armer�a);

            Municipio Colima = new Municipio();
            Colima.ciudad = "Colima";
            Colima.poblacion = "157,048";
            Colima.extension = "1,668 km2";
            Colima.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\col.png");
            mpios.Add(Colima);

            Municipio Comala = new Municipio();
            Comala.ciudad = "Comala";
            Comala.poblacion = "21,661";
            Comala.extension = "254 km2";
            Comala.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\com.png");
            mpios.Add(Comala);

            Municipio Coquimatl�n = new Municipio();
            Coquimatl�n.ciudad = "Coquimatl�n";
            Coquimatl�n.poblacion = "20,837";
            Coquimatl�n.extension = "320 km2";
            Coquimatl�n.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\coq.png");
            mpios.Add(Coquimatl�n);

            Municipio Cuauht�moc = new Municipio();
            Cuauht�moc.ciudad = "Cuauht�moc";
            Cuauht�moc.poblacion = "31,267";
            Cuauht�moc.extension = "373 km2";
            Cuauht�moc.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\Cuautemoc.png");
            mpios.Add(Cuauht�moc);

            Municipio Ixtlahuac�n = new Municipio();
            Ixtlahuac�n.ciudad = "Ixtlahuac�n";
            Ixtlahuac�n.poblacion = "5,623";
            Ixtlahuac�n.extension = "376 km2";
            Ixtlahuac�n.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\ixtlahuacan.png");
            mpios.Add(Ixtlahuac�n);

            Municipio Manzanillo = new Municipio();
            Manzanillo.ciudad = "Manzanillo";
            Manzanillo.poblacion = "191,031";
            Manzanillo.extension = "1,578 km2";
            Manzanillo.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\manzanillo.png");
            mpios.Add(Manzanillo);

            Municipio Minatitl�n = new Municipio();
            Minatitl�n.ciudad = "Minatitl�n";
            Minatitl�n.poblacion = "10,231";
            Minatitl�n.extension = "215  km2";
            Minatitl�n.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\minatitlan.png");
            mpios.Add(Minatitl�n);

            Municipio Tecom�n = new Municipio();
            Tecom�n.ciudad = "Tecom�n";
            Tecom�n.poblacion = "116,305";
            Tecom�n.extension = "834 km2";
            Tecom�n.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\tecoman.png");
            mpios.Add(Tecom�n);


            Municipio Villa = new Municipio();
            Villa.ciudad = "Villa de �lvarez";
            Villa.poblacion = "149,762";
            Villa.extension = "428 km2";
            Villa.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\villa.png");
            mpios.Add(Villa);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listBox1.Text))
            {
                MessageBox.Show("No seleciconaste un Municipio, Porfavor selecciona uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int pointer = listBox1.SelectedIndex;
                //Mostrar la imagen del escudo
                pictureBox1.Image = mpios[pointer].escudo;
                //Mostrar la informaci�n del municipio seleccionado
                MessageBox.Show("-- Datos de Municipios --" + "\n" +
                    "Municipio: " + mpios[pointer].ciudad + "\n" +
                    "Extensi�n: " + mpios[pointer].extension + "\n" +
                    "Poblaci�n: " + mpios[pointer].poblacion);
                
            }
        }
    }
}