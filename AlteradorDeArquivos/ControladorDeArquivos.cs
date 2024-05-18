using System;
using System.Text.Json;
using System.IO;

namespace AlteradorDeArquivos;

public class ControladorDeArquivos
{
    private string DiretorioDeLeitura;
    public string [] Arquivos;
    private string DiretorioDeSaida;
    public string Conteudo;
    public string NomeArquivo;



    public ControladorDeArquivos()
    {
        var config = new Configuracoes();
        config.Atualizar();


        DiretorioDeLeitura = config.CaminhoEntrada;
        DiretorioDeSaida = config.CaminhoSaida;

        Arquivos = Directory.GetFiles(DiretorioDeLeitura);
    }

   public void Salvar(string conteudoNovo, string[] arquivos ,int posicao)
   {
        NomeArquivo = new DirectoryInfo(arquivos[posicao]).Name;
        using (StreamWriter arquivo = new StreamWriter(DiretorioDeSaida + NomeArquivo))
        {
            arquivo.Write(conteudoNovo);
        }
   }

    public void Ler(string[] arquivos, int posicao)
    {

        using (StreamReader arquivo = new StreamReader(arquivos[posicao]))
        {
            Conteudo = arquivo.ReadToEnd();
        }
    }

    public void Deletar(string[] arquivos, int posicao) 
    {
        File.Delete(arquivos[posicao]);
        Arquivos = Directory.GetFiles(DiretorioDeLeitura);
    }

}
