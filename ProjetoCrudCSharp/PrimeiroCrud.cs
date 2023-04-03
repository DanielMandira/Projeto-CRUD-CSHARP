using System.Windows.Forms;

namespace ProjetoCrudCSharp
{
    public partial class PrimeiroCrud : Form
    {
        public PrimeiroCrud()
        {
            InitializeComponent();
        }
        Class_Pessoas newPe = new Class_Pessoas();
        private void BTN_Inserir_Click(object sender, EventArgs e)
        {
            //Receber e enviar dados do Form para a Classe

            try
            {
                newPe.set_nome(TXT_Nome.Text);
                newPe.set_endereco(TXT_Endereco.Text);
                newPe.set_celular(TXT_Celular.Text);
                newPe.inserir();
                DGV_Dados.DataSource = newPe.consultar();

            }
            finally
            {
                MessageBox.Show("Registro Inserido com SUCESSO!!!");
                TXT_Nome.Clear();
                TXT_Endereco.Clear();
                TXT_Celular.Clear();
                TXT_Nome.Focus();

            }
        }

        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            DGV_Dados.ClearSelection();
            TXT_Nome.Clear();
            TXT_Endereco.Clear();
            TXT_Celular.Clear();
            TXT_Nome.Focus();
        }

        private void BTN_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Pesquisa_Click(object sender, EventArgs e)
        {

            DGV_Dados.DataSource = newPe.consultar();
            //Alteração dos Registros 
            DGV_Dados.Columns[1].HeaderText= "Nome";
            DGV_Dados.Columns[2].HeaderText ="Endereço";
            DGV_Dados.Columns[3].HeaderText = "Telefone";
            TXT_Nome.Focus();


        }

        private void BTN_Apagar_Click(object sender, EventArgs e)
        {
            try
            {
                newPe.set_idx(Convert.ToInt32(LBL_Idx.Text));
                newPe.apagar();
                DGV_Dados.DataSource = newPe.consultar();
            }
            finally
            {
                MessageBox.Show("Registro Apagado com Sucesso!!");
                TXT_Nome.Clear();
                TXT_Endereco.Clear();
                TXT_Celular.Clear();
                TXT_Nome.Focus();
            }
        }

        private void BTN_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                newPe.set_idx(Convert.ToInt32(LBL_Idx.Text));
                newPe.set_nome(TXT_Nome.Text);
                newPe.set_endereco(TXT_Endereco.Text);
                newPe.set_celular(TXT_Celular.Text);
                newPe.atualizar();
                DGV_Dados.DataSource = newPe.consultar();

            }
            finally
            {
                MessageBox.Show("Registro Atualizado com SUCESSO!!!");
                TXT_Nome.Clear();
                TXT_Endereco.Clear();
                TXT_Celular.Clear();
                TXT_Nome.Focus();
                
            }
        }

        private void DGV_Dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Dados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                DGV_Dados.CurrentRow.Selected = true;
                LBL_Idx.Text = DGV_Dados.Rows[e.RowIndex].Cells["idx"].FormattedValue.ToString();
                TXT_Nome.Text = DGV_Dados.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                TXT_Endereco.Text = DGV_Dados.Rows[e.RowIndex].Cells["endereco"].FormattedValue.ToString();
                TXT_Celular.Text = DGV_Dados.Rows[e.RowIndex].Cells["celular"].FormattedValue.ToString();
            }
        }

    }
}