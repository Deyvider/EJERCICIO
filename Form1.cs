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
            Municipio armería = new Municipio();
            armería.ciudad = "Armería";
            armería.poblacion = "27,626";
            armería.extension = "341 km2";
            armería.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\arm.png");
            mpios.Add(armería);

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

            Municipio Coquimatlán = new Municipio();
            Coquimatlán.ciudad = "Coquimatlán";
            Coquimatlán.poblacion = "20,837";
            Coquimatlán.extension = "320 km2";
            Coquimatlán.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\coq.png");
            mpios.Add(Coquimatlán);

            Municipio Cuauhtémoc = new Municipio();
            Cuauhtémoc.ciudad = "Cuauhtémoc";
            Cuauhtémoc.poblacion = "31,267";
            Cuauhtémoc.extension = "373 km2";
            Cuauhtémoc.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\Cuautemoc.png");
            mpios.Add(Cuauhtémoc);

            Municipio Ixtlahuacán = new Municipio();
            Ixtlahuacán.ciudad = "Ixtlahuacán";
            Ixtlahuacán.poblacion = "5,623";
            Ixtlahuacán.extension = "376 km2";
            Ixtlahuacán.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\ixtlahuacan.png");
            mpios.Add(Ixtlahuacán);

            Municipio Manzanillo = new Municipio();
            Manzanillo.ciudad = "Manzanillo";
            Manzanillo.poblacion = "191,031";
            Manzanillo.extension = "1,578 km2";
            Manzanillo.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\manzanillo.png");
            mpios.Add(Manzanillo);

            Municipio Minatitlán = new Municipio();
            Minatitlán.ciudad = "Minatitlán";
            Minatitlán.poblacion = "10,231";
            Minatitlán.extension = "215  km2";
            Minatitlán.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\minatitlan.png");
            mpios.Add(Minatitlán);

            Municipio Tecomán = new Municipio();
            Tecomán.ciudad = "Tecomán";
            Tecomán.poblacion = "116,305";
            Tecomán.extension = "834 km2";
            Tecomán.escudo = Image.FromFile("C:\\Users\\COMPUTOCKS\\Documents\\AppsMultiplataforma\\InfoMuni\\Icons\\tecoman.png");
            mpios.Add(Tecomán);


            Municipio Villa = new Municipio();
            Villa.ciudad = "Villa de Álvarez";
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
                //Mostrar la información del municipio seleccionado
                MessageBox.Show("-- Datos de Municipios --" + "\n" +
                    "Municipio: " + mpios[pointer].ciudad + "\n" +
                    "Extensión: " + mpios[pointer].extension + "\n" +
                    "Población: " + mpios[pointer].poblacion);
                
            }
        }
    }
}