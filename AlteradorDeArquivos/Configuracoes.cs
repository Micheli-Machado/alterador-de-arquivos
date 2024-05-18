using System;
using System.Text.Json;

namespace AlteradorDeArquivos;

public class Configuracoes
{
    public string CaminhoEntrada { get; set; }

    public string CaminhoSaida { get; set; }

    public string ValorParaLocalizar { get; set; }

    public string ValorDeSubstituicao { get; set; }

    public Configuracoes()
    {
    }

    public void Atualizar()
    {
        string jsonString = File.ReadAllText("configuracoes.json");
        var configuracoes = JsonSerializer.Deserialize<Configuracoes>(jsonString);

        CaminhoEntrada = configuracoes.CaminhoEntrada;
        CaminhoSaida = configuracoes.CaminhoSaida;
        ValorParaLocalizar = configuracoes.ValorParaLocalizar;
        ValorDeSubstituicao = configuracoes.ValorDeSubstituicao;

    }

}
