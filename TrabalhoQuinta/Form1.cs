namespace TrabalhoQuinta

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstAnimais.Items.Add(textBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstAnimais.Items.Remove(textBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstAnimais.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(textBox.Text);
            MessageBox.Show(cad.mensagem);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}