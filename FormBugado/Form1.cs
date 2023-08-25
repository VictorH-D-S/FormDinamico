namespace FormBugado
{
    public partial class Form1 : Form
    {

        List<string> produtos = new List<string>() { "Chinela", "Relójo", "Bassora", "Mortandela" };

        public Form1()
        {
            InitializeComponent();
        }


        void geraForm(string produto)
        {
            Panel panel = new Panel();
            panel.Name = "panela";
            panel.BackColor = Color.Beige;
            panel.Size = new Size(100, 100);

            Label label = new Label();
            label.Name = "Dragon Slayer";
            label.Text = produto;
            label.AutoSize = true;

            void comprar(object sender, EventArgs e)
            {
                label.Text = "Comprado";
                panel.BackColor = Color.Green;
            }

            Button button = new Button();
            button.Name = "novoBotao";
            button.Text = "Comprar";
            button.Location = new Point(0, label.Height);
            button.Click += comprar;

            panel.Controls.Add(label);
            panel.Controls.Add(button);

            panel.Location = new Point(0, panel1.Height);

            if (panel1.Height < 500)
                panel1.Height += panel.Height + 10;

            panel1.Controls.Add(panel);
        }

        private void bota_Click(object sender, EventArgs e)
        {
            geraForm("Viado");
            imgViado.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string produto in produtos)
            {
                geraForm(produto);
            }
        }
    }
}