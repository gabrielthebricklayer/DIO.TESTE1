using System;
using System.Collections.Generic;

namespace DIO.TESTE
{
    class Program
    {    
        
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();
         {
            while (opcaoUsuario.ToUpper() != "X") 
              {
               switch (opcaoUsuario)
               {
                  case "1":
                   ListarSeries();
                   break;
                   case "2":
                   inserirserie();
                   break;
                   case "3":
                  // atualizarserie();
                   break;
                   case "4":
                   //excluirserie();
                   break;
                   case "5":
                   //visualizarserie();
                   break;
                   case"c":
                   Console.Clear();
                   break;
                   default:
                   throw new ArgumentOutOfRangeException();

               }

              }

            
           opcaoUsuario = ObterOpcaoUsuario();
         

        }
        Console.WriteLine("Obrigado por Atualizar nossos serviços.");
        Console.ReadLine();
        }
        
        public static void ListarSeries()
        {
            Console.WriteLine(" listar serie");
             
             var lista = repositorio.lista();
             if (lista.Count == 0)
             {    
                 Console.WriteLine("nenhuma lista encontada.");
                 return;
             }
             foreach ( var serie in lista)
             {
                 Console.WriteLine("#ID{0}:- {1}", serie.Retornaid(), serie.retornatitulo());

             }
        } 

        private static void inserirserie()
        {

            Console.WriteLine("inserie serie");

            foreach (int i in Enum.GetValues(typeof(genero)))
            {
                  Console.WriteLine("{0}-{1}",  i, Enum.GetName(typeof(genero), i));

            }
            Console.Write("digite o genero entre as opcoes a cima:");
            int entradagenero = int.Parse(Console.ReadLine());
            
            
            Console.Write("digite o titulo da serie: ");
            string entragdatitulo = Console.ReadLine();


            Console.Write("digite o ano de inicio da serie:");
            int entradaano = int.Parse(Console.ReadLine());

            Console.Write("digite a descriçao da serie: ");
            string entradadescricao = Console.ReadLine();

            serie novaserie = new serie(Id:  repositorio.ProximoId().
                                       genero: (genero) entradagenero, 
                                       titulo: entragdatitulo,
                                        ano:entradaano,
                                        descricao: entradadescricao);
             repositorio.inserie(novaserie);                            
                                         



        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO SERIES A O SEU DISPOR!!!");
            Console.WriteLine("INFORME A OPCAO DESEJADA:");
            
            
            Console.WriteLine("1-ISTAR SERIES");
            Console.WriteLine("2- INSERIR NOCVA SERIE");
            Console.WriteLine("3- ATUALIZAR SERIES");
            Console.WriteLine("4- EXCLUIR SERIE");
            Console.WriteLine("5- VISUALIZAR SERIE");
            Console.WriteLine("C- LIMPAR TELA");
            Console.WriteLine("X- SAIR ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.ReadLine();
            return opcaoUsuario;


        } 
    }
}
