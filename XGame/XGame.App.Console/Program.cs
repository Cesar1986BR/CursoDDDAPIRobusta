using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inciianlizando...");

            var servico = new ServiceJogador();

            Console.WriteLine("Servico Jogador Iniciado...");

            //AutenticarJogadorRequest Autenticarrequest = new AutenticarJogadorRequest();
            //Autenticarrequest.Email = "cesar@gmail.com";
            //Autenticarrequest.Senha = "flora1313";
            //Console.WriteLine("Objeto request iniciado");


            //var Addrequest = new AddJogadorRequest
            //{
            //    PrimeiroNome ="Cesar",
            //    UltimoNome= "Augusto Gadelha  Santos",
            //    Email = "cesarmgla@hotmail.com",
            //    Senha = "Flora2019"
            //};

            servico.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });

            // var responseAutenticar = servico.Autenticar(Autenticarrequest);
            // var responseAdicionar = servico.AddJogador(Addrequest);

            var result = servico.ListaJogador();

            List<string> listErrors = new List<string>();
            foreach (var erros in servico.Notifications)
            {
                listErrors.Add(erros.Message);
            }

            if (listErrors.Any())
            {
                foreach (var item in listErrors)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Autenticado com sucesso!!");
            }

            //if (servico.IsValid())
            //{
            //    // return response; -> returna pra api o resultado da insercao
            //}

            Console.ReadKey();
        }
    }
}
