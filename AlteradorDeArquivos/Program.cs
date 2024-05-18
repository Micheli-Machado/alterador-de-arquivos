using System;

namespace AlteradorDeArquivos;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            var editar = new FormatadorDeTextos();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Falha na alteração!");
            Console.WriteLine("Entre em contato com o telefone (48) 2101-6770");
        }
        finally
        {
            Console.WriteLine("Operação Finalizada!");
            Thread.Sleep(2000);
        }
    }
}