namespace Colletta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Colletta = new Dictionary<string, double>();
            Index = new Dictionary<string, int>();
            totale = 0;
            cont = 0;
        }

        private Dictionary<string, double> Colletta;
        private Dictionary<string, int> Index;
        private double totale;
        private int cont;
        private void Form1_Load(object sender, EventArgs e)
        {             
            listView1.Columns.Add("NOME");
            listView1.Columns.Add("QUOTA");
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
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Nome invalido");
                return;
            }
            if (Colletta.ContainsKey(nome))
            {
                MessageBox.Show("Nome già presente");
                return;
            }
            if (quota < 0)
            {
                MessageBox.Show("Quota invalida");
                return;
            }
            Colletta.Add(nome, quota);
            Index.Add(nome, cont);
            cont++;
            totale += quota;
            string[] str = new string[] { nome, quota.ToString() };
            ListViewItem riga = new ListViewItem(str);
            listView1.Items.Add(riga);
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if(Colletta.Count == 0)
            {
                MessageBox.Show("Colletta vuota");
                return;
            }    
            string nome = textBoxNome.Text;
            double quota = 0;
            try
            {
                quota = double.Parse(textBoxQuota.Text);
            }
            catch { MessageBox.Show("Quota invalida"); return; }            
            if (quota < 0)
            {
                MessageBox.Show("Quota invalida");
                return;
            }
            else if (Colletta.ContainsKey(nome))                                    
            {
                totale -= Colletta[nome];
                totale += quota;
                Colletta[nome] = quota;
                listView1.Items.RemoveAt(Index[nome]);
                string[] str = new string[] { nome, quota.ToString() };
                ListViewItem riga = new ListViewItem(str);
                listView1.Items.Add(riga);
                cont++;
            }

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
                totale -= Colletta[nome];       
                Colletta.Remove(nome);
                listView1.Items.RemoveAt(Index[nome]);
                Index.Remove(nome);              
                return;
            }
            else 
                MessageBox.Show("Nome non trovato o già eliminato"); 
        }

        private void buttonTotale_Click(object sender, EventArgs e)
        {
            if (Colletta.Count == 0)
            { }
            else
            {
                textBoxNome.Text = "Totale =";
                textBoxQuota.Text = totale.ToString();
            }
                
        }
    }
}