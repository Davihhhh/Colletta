namespace Colletta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        Dictionary<string, double> Colletta;
        private void Form1_Load(object sender, EventArgs e)
        {
            Colletta = new Dictionary<string, double>();
            string[] intestazione = new string[] { "NOME", "QUOTA" };
            for (int i = 0; i < intestazione.Length; i++)
            {
                listView1.Columns.Add(intestazione[i]);
            }
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
            if (Colletta.ContainsKey(nome))
            {
                MessageBox.Show("Nome già presente");
                return;
            }
            Colletta.Add(nome, quota);          
            ListViewItem riga = new ListViewItem(nome + ';' + quota.ToString());
            listView1.Items.Add(riga);
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            double quota = 0;
            try
            {
                quota = double.Parse(textBoxQuota.Text);
            }
            catch { MessageBox.Show("Quota invalida"); return; }
            if (Colletta.ContainsKey(nome))
            {
                MessageBox.Show("Nome già presente");
                return;
            }
            else
                Colletta[nome] = quota;
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Inserisci il nome da eliminare");
                return;
            }
            if (Colletta.ContainsKey(nome))
            {
                Colletta.Remove(nome);
                listView1.Items.RemoveByKey(nome);
                return;
            }
            else 
                MessageBox.Show("Nome non trovato o già eliminato"); 
        }       
    }
}