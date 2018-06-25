using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Trabalgo_LP2
{
    public partial class Form_cardapio : Form
    {
        public Form_cardapio()
        {
            InitializeComponent();
        }

        private Cardapio GetDTO()
        {
            //Pega as informações da tela
            Cardapio cardapio = new Cardapio();
            cardapio.Id = Convert.ToInt32(txt_id_adicionar.Text);
            cardapio.Nome = txt_nome_adicionar.Text;
            cardapio.Descricao = txt_descricao.Text;
            cardapio.Preco = Convert.ToDouble(txt_preco_adicionar.Text);

            return cardapio;
        }

        private void SetDTO(Cardapio c)
        {
            //Insere as informações na tela
            txt_id_adicionar.Text = c.Id.ToString();
            txt_nome_adicionar.Text = c.Nome;
            txt_descricao.Text = c.Descricao;
            txt_preco_adicionar.Text = c.Preco.ToString();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            //Fecha form
            Close();
        }

        private void btn_remover_adicionar_Click(object sender, EventArgs e)
        {
            //Quando pressionado remove um item usando o id
            if (txt_id_adicionar.Text.Equals(""))
            {
                MessageBox.Show("Certifique-se de que ID está preenchido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CardapioDAO cardapioDAO = new CardapioDAO();
                cardapioDAO.Delete(Convert.ToInt32(txt_id_adicionar.Text));
                MessageBox.Show("Item removido com sucesso!", "Item removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CardapioDAO cardapiodao = new CardapioDAO();
            dataGridView_cardapio.DataSource = cardapiodao.listAll();
        }

        private void btn_adicionar_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se alguma txt  não estiver preenchida, cria uma mensagem de aviso
                if (txt_id_adicionar.Text.Equals("") || txt_nome_adicionar.Text.Equals("") ||
                   txt_descricao.Text.Equals("") || txt_preco_adicionar.Text.Equals(""))
                    MessageBox.Show("Todos os campos precisam estar preenchidos!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!Regex.Match(txt_id_adicionar.Text, @"^\d+$").Success)
                {
                    MessageBox.Show("Erro: Só é possível adicionar números inteiros!", "ERRO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.Match(txt_preco_adicionar.Text, @"^(\d{1,3}(\.\d{3})*|\d+)(\,\d{2})?$").Success)
                {
                    MessageBox.Show("Erro: O formato permitido é XX,XX (possui vírgula e não ponto). Caracteres adicionais não são aceitos!", "ERRO!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Se tudo estiver preenchido cria o DTO e insere no bd
                    CardapioDAO cardapioDAO = new CardapioDAO();
                    Cardapio cardapio = GetDTO();
                    cardapioDAO.Create(cardapio);

                    MessageBox.Show("Item inserido com sucesso", "Item inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CardapioDAO cardapiodao = new CardapioDAO();
                dataGridView_cardapio.DataSource = cardapiodao.listAll();

                //esvazia os campos para uma nova inserção
                txt_id_adicionar.Text = "";
                txt_nome_adicionar.Text = "";
                txt_descricao.Text = "";
                txt_preco_adicionar.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Já existe o ID digitado em nosso Banco de Dados", "ERRO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form_cardapio_Load(object sender, EventArgs e)
        {
            //preenche o grid quando carrega a tela
            CardapioDAO cardapioDAO = new CardapioDAO();
            dataGridView_cardapio.DataSource = cardapioDAO.listAll();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //pesquisa por NOME
            CardapioDAO cardapioDAO = new CardapioDAO();
            dataGridView_cardapio.DataSource = cardapioDAO.Find(txt_procurar.Text);

            txt_procurar.Text = ""; // esvazia o campo, para proximo uso

        }

        private void btn_remover_adicionar_MouseHover(object sender, EventArgs e)
        {
            //tentei fazer algo para ficar mais intuitivo o remover e add com TOOLTIPS
            //bem interessante mas ta dando bug estranho entao tirei de lá mas continua aq
            ToolTip tt = new ToolTip();

            tt.Show("Somente o ID é necessário para remover", btn_remover_adicionar, 200);
          
            
        }

        private void btn_adicionar_adicionar_MouseHover(object sender, EventArgs e)
        {
            //tentei fazer algo para ficar mais intuitivo o remover e add com TOOLTIPS
            //bem interessante mas ta dando bug estranho entao tirei de lá mas continua aq
            ToolTip tt = new ToolTip();

            tt.Show("Todos os campos são necessários para adicionar", btn_adicionar_adicionar);
            
        }

        private void txt_procurar_TextChanged(object sender, EventArgs e)
        {
            CardapioDAO cardapioDAO = new CardapioDAO();
            dataGridView_cardapio.DataSource = cardapioDAO.Find(txt_procurar.Text);
        }

        private void dataGridView_cardapio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dataGridView_cardapio.Rows[e.RowIndex].Cells[1].Value;
            txt_id_adicionar.Text = cell.ToString();
        }
    }
}
