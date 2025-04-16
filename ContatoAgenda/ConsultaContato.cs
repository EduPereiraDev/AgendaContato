using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContatoAgenda
{
    public partial class ConsultaContato : Form
    {
        public ConsultaContato()
        {
            InitializeComponent();
        }

        private void ConsultaContato_Load(object sender, EventArgs e)
        {
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string query = "SELECT id, nome, apelido, cpf, telefone, email FROM contato ORDER BY nome";

                    using (var da = new NpgsqlDataAdapter(query, conexao))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvContatos.DataSource = dt;
                    }
                }

                dgvContatos.Columns["id"].Visible = false; // Esconde a coluna de ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar contatos: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvContatos.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dgvContatos.SelectedRows[0];

                string id = linha.Cells["id"].Value.ToString();
                string nome = linha.Cells["nome"].Value.ToString();
                string apelido = linha.Cells["apelido"].Value.ToString();
                string cpf = linha.Cells["cpf"].Value.ToString();
                string telefone = linha.Cells["telefone"].Value.ToString();
                string email = linha.Cells["email"].Value.ToString();

                CadastroContato frmEditar = new CadastroContato();
                frmEditar.PreencherCampos(id, nome, apelido, cpf, telefone, email);
                frmEditar.ShowDialog();

                CarregarContatos();
            }
            else
            {
                MessageBox.Show("Selecione um contato para editar.");
            }
        }

        private void dgvContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvContatos.Rows[e.RowIndex];

                string id = linha.Cells["id"].Value.ToString();
                string nome = linha.Cells["nome"].Value.ToString();
                string apelido = linha.Cells["apelido"].Value.ToString();
                string cpf = linha.Cells["cpf"].Value.ToString();
                string telefone = linha.Cells["telefone"].Value.ToString();
                string email = linha.Cells["email"].Value.ToString();

                CadastroContato frmEditar = new CadastroContato();
                frmEditar.PreencherCampos(id, nome, apelido, cpf, telefone, email);
                frmEditar.ShowDialog();

                CarregarContatos();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // vrfica se o campo de texto para data não ta vazio
            if (string.IsNullOrWhiteSpace(txtDataCadastro.Text))
            {
                MessageBox.Show("Por favor, insira uma data para filtrar.");
                return;
            }

            DateTime dataCadastro;

            // vrfica se a data insrd e valida
            if (!DateTime.TryParse(txtDataCadastro.Text, out dataCadastro))
            {
                MessageBox.Show("Data inválida. Por favor, insira uma data válida.");
                return;
            }

            // Consulta para filtrar contatos pela data de cadastro
            string query = "SELECT id, nome, apelido, cpf, telefone, email, data_cadastro, data_ultima_alteracao " +
                           "FROM contato WHERE data_cadastro = @dataCadastro";

            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro.Date); // Considera a data sem hora

                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                // Atualiza o DataGridView com os dados filtrados
                dgvContatos.DataSource = dt;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvContatos.SelectedRows.Count > 0)
            {
                // Pega o ID da linha selecionada
                var id = dgvContatos.SelectedRows[0].Cells["id"].Value.ToString();

                var confirmar = MessageBox.Show("Tem certeza que deseja excluir esse contato?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmar == DialogResult.Yes)
                {
                    using (var conn = Conexao.ObterConexao())
                    {
                        string query = "DELETE FROM contato WHERE id = @id";
                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(id));
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Contato excluído com sucesso!");
                    CarregarContatos(); // Recarrega o DataGridView
                }
            }
            else
            {
                MessageBox.Show("Selecione um contato para excluir.");
            }
        }
    }
}
