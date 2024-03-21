namespace Projeto_Maua2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e) //Evento de clique do botão "Gerar"
        {
            GeradorBLL.ValidaEntrada(txtTamanho.Text); //validando a entrada do usuario

            if (Erro.TemErro == true)
            {
                MessageBox.Show(Erro.Mensagem); //mensagem de erro caso encontre algum.
            }
            else
            {
                switch (true) //switch case para melhor performance em comparação ao encadeamento de If e Else.
                {
                    case bool _ when rbNums.Checked:
                        txtResult.Text = Gerador.GeraNumero(int.Parse(txtTamanho.Text)).ToString();
                        break;
                    case bool _ when rbLetras.Checked:
                        txtResult.Text = Gerador.GeraCaracter(int.Parse(txtTamanho.Text)).ToString();
                        break;
                    case bool _ when rbLetrNum.Checked:
                        txtResult.Text = Gerador.GeraNumLetra(int.Parse(txtTamanho.Text)).ToString();
                        break;
                    case bool _ when rbTudo.Checked:
                        txtResult.Text = Gerador.GeraTudo(int.Parse(txtTamanho.Text)).ToString();
                        break;
                    default:
                        txtResult.Text = "Selecione uma opção!"; /*por padrão, caso o usuario não selecione nenhuma opção do radiobutton,
                                                                 * essa mensagem aparecerá na saída */
                        break;
                }


            }

        }
    }
}
