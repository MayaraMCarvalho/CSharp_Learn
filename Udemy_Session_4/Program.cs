using List01;
using List02;
using List03;

namespace Udemy_Session_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exs List01            
            Pessoa.Cadastro();
            Funcionario.Cadastro();

            // Exs List02
            Retangulo.Medidas();
            FuncionarioImposto.Impostos();
            Aluno.Notas();

            // Exs List03
            Cotacao.GetCotacao();
            Produto.Cadastro();
        }
    }
}