using System;

namespace AlteradorDeArquivos;

public class Program
{
    static void Main(string[] args)
    {
        string log = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        using (StreamWriter arquivoLog = new StreamWriter(log + "\\Log.txt"))
        {
            arquivoLog.Write("");
        }
        var hora = DateTime.Now;
        while (hora.Hour < 23 )
        {
            try
            {
                var editar = new FormatadorDeTextos();
            }
            catch (Exception ex)
            {
                string logEscreve= System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                using (StreamWriter arquivoLog = new StreamWriter(logEscreve + "\\Log.txt"))
                {
                    arquivoLog.Write(ex.ToString());
                }
                Console.WriteLine("Falha na alteração!");
                Console.WriteLine("Entre em contato com o telefone (48) 2101-6770");
            }
            finally
            {
                Thread.Sleep(60000);
                Console.Clear();
            }

            var horaFinalizou = DateTime.Now;
            string logFinalizou = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            using (StreamWriter arquivoLog = new StreamWriter(logFinalizou + "\\Log.txt"))
            {
                arquivoLog.Write($"Alterador foi encerrado em {horaFinalizou}.");
            }
        }
    }
}