using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Npgsql;
using System;
using System.Windows.Forms;

namespace ContatoAgenda
{
    public partial class CadastroContato : Form
    {
        private bool modoEdicao = false;
        private int idContatoEditar = -1;

        public CadastroContato()
        {
            InitializeComponent();
        }

        // Este método é chamado quando estamos editando um contato existente
        public void PreencherCampos(string id, string nome, string apelido, string cpf, string telefone, string email)
        {
            modoEdicao = true;
            idContatoEditar = int.Parse(id);

            // Preenche os campos com os dados do contato que será editado
            txtNome.Text = nome;
            txtApelido.Text = apelido;
            mtxCpf.Text = cpf;
            mtxTelefone.Text = telefone;
            txtEmail.Text = email;

            // Desabilita o campo de data de cadastro, pois não deve ser alterado
            dtpCadastro.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    if (modoEdicao)
                    {
                        // Atualiza os dados do contato se estamos no modo de edição
                        string query = @"UPDATE contato SET 
                                        nome = @nome,
                                        apelido = @apelido,
                                        cpf = @cpf,
                                        telefone = @telefone,
                                        email = @email,
                                        data_ultima_alteracao = @data_ultima_alteracao
                                    WHERE id = @id";

                        using (var cmd = new NpgsqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@apelido", txtApelido.Text);
                            cmd.Parameters.AddWithValue("@cpf", mtxCpf.Text);
                            cmd.Parameters.AddWithValue("@telefone", mtxTelefone.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@data_ultima_alteracao", DateTime.Now.Date);
                            cmd.Parameters.AddWithValue("@id", idContatoEditar);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Contato atualizado com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        // Salva um novo contato no banco de dados
                        string query = @"INSERT INTO contato 
                            (nome, apelido, cpf, telefone, email, data_cadastro, data_ultima_alteracao)
                            VALUES 
                            (@nome, @apelido, @cpf, @telefone, @email, @data_cadastro, @data_ultima_alteracao)";

                        using (var cmd = new NpgsqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@apelido", txtApelido.Text);
                            cmd.Parameters.AddWithValue("@cpf", mtxCpf.Text);
                            cmd.Parameters.AddWithValue("@telefone", mtxTelefone.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@data_cadastro", dtpCadastro.Value.Date);
                            cmd.Parameters.AddWithValue("@data_ultima_alteracao", DateTime.Now.Date);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Contato salvo com sucesso!");
                        LimparCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            // Verifica se todos os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtApelido.Text)) return false;
            if (string.IsNullOrWhiteSpace(mtxCpf.Text)) return false;
            if (string.IsNullOrWhiteSpace(mtxTelefone.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) return false;
            return true;
        }

        private void LimparCampos()
        {
            // Limpa os campos de entrada para um novo cadastro
            txtNome.Clear();
            txtApelido.Clear();
            mtxCpf.Clear();
            mtxTelefone.Clear();
            txtEmail.Clear();
            dtpCadastro.Value = DateTime.Today;
        }

        private void CadastroContato_Load(object sender, EventArgs e)
        {
            // Método que será executado ao carregar o formulário (não implementado por enquanto)
        }
    }
}
