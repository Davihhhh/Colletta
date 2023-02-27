namespace Colletta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, double>Colletta = new Dictionary<string, double>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            double quota = 0;
            try
            {
                quota = double.Parse(textBoxQuota.Text);
            }
            catch { MessageBox.Show("Quota invalida"); return; }
            Colletta.Add(nome, quota);
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {

        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            try
            {
                Colletta.Remove(nome);
            }
            catch { MessageBox.Show("Nome non trovato"); }
        }
    }
}