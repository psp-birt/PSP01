using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace pipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p;
            StartServer(out p);
            Task.Delay(1000).Wait();
            Console.WriteLine("Arrancando Servidor");


            //Client
            var client = new NamedPipeClientStream("PipesOfPiece");
            Console.WriteLine("Conectando a Servidor");
            client.Connect();
            StreamReader reader = new StreamReader(client);
            StreamWriter writer = new StreamWriter(client);

            while (true)
            {
                Console.WriteLine("Escriba el texto que quiera procesar: ");
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input)) break;
                Console.WriteLine(String.Join("","Enviado: ",input));
                writer.WriteLine(input);
                writer.Flush();
                Console.WriteLine(reader.ReadLine());
            }
        }

        static Process StartServer(out Process p1)
        {

            //Preparamos los parámetros para lanzar proceso
            ProcessStartInfo info = new ProcessStartInfo(@".\pipesServidor.exe")
            {
                CreateNoWindow = false,
                WindowStyle = ProcessWindowStyle.Normal,
                UseShellExecute = true
            };

            //Iniciamos el proceso
            p1 = Process.Start(info);
            //Devolvemos identificador del proceso.
            return p1;
        }
    }
}
