using System.Reflection.PortableExecutable;

namespace AlteradorDeArquivos;

public class FormatadorDeTextos
{
    public string TextoEditado;
    private string ValorLocalizar;
    private string ValorSubstituto;


    public FormatadorDeTextos()
    {
        var cArquivos = new ControladorDeArquivos();
        var qArquivos = cArquivos.Arquivos.Length;

        for (int i = 0; i <= qArquivos-1; i++)
        {
            cArquivos.Ler(cArquivos.Arquivos, i);

            var config = new Configuracoes();
            config.Atualizar();

            ValorLocalizar = config.ValorParaLocalizar;
            ValorSubstituto = config.ValorDeSubstituicao;

            TextoEditado = cArquivos.Conteudo.Replace(ValorLocalizar, ValorSubstituto);

            cArquivos.Salvar(TextoEditado, cArquivos.Arquivos, i);
        }
    }
}