using System;
using System.Text;
using Aprender;
using Aprender.Classes;

class MainClass {
  static SerieRepositorio repositorio = new SerieRepositorio();
  public static void Main (string[] args) 
  {
    string opcaoUsuario = ObeterOpcaoUsuario();

    while (opcaoUsuario.ToUpper()!= "x")
    {
      switch(opcaoUsuario)
      {
        case "1":
            ListarSeries();
            break;
        case "2":
            InserieSerie();
            break;
        case "3":
            AtualizarSerie();
            break;
        case "4":
            ExcluirSerie();
            break;
        case "5":
            VisualizarSerie();
            break;
        case "C":
            Console.Clear();
            break;
        default:
            throw new ArgumentOutOfRangeException();
      }
      opcaoUsuario = ObeterOpcaoUsuario();
    }   

  }
       private static void ListarSeries()
      {
        System.Console.WriteLine("Listar Serie");        

            var lista = repositorio.Lista();
            
            if(lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma Serie Encontrada");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                System.Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }
        }
        private static void InserieSerie()
        {
          System.Console.WriteLine("Inserir Nova Serie");

          foreach (int i in Enum.GetValues(typeof(Genero)))
          {
            System.Console.WriteLine(" {0} - {1}", i , Enum.GetName(typeof(Genero),i));
          }

            System.Console.WriteLine("Digite o genero entre as opcoes acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo da serie: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Descricao da Serie");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie (id: repositorio.ProximoId(),
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            ano: entradaAno,
            descricao : entradaDescricao);

            repositorio.Insere(novaSerie);
        }

      private static void AtualizarSerie()
      {
        System.Console.WriteLine("Inserir o ID da serie: ");
        int indeceSerie = int.Parse(Console.ReadLine());
        
          foreach (int i in Enum.GetValues(typeof(Genero)))
          {
            System.Console.WriteLine(" {0} - {1}", i , Enum.GetName(typeof(Genero),i));
          }

              System.Console.WriteLine("Digite o genero entre as opcoes acima: ");
              int entradaGenero = int.Parse(Console.ReadLine());

              System.Console.WriteLine("Digite o Titulo da serie: ");
              string entradaTitulo = Console.ReadLine();

              System.Console.WriteLine("Digite o Ano da serie: ");
              int entradaAno = int.Parse(Console.ReadLine());

              System.Console.WriteLine("Digite a Descricao da Serie");
              string entradaDescricao = Console.ReadLine();

              Serie novaSerie = new Serie (id: indeceSerie,
              genero: (Genero)entradaGenero,
              titulo: entradaTitulo,
              ano: entradaAno,
              descricao : entradaDescricao);

              repositorio.Atualizar(indeceSerie, novaSerie);
      }

      private static void ExcluirSerie()
      {
        System.Console.WriteLine("Insira o ID Da serie que deseja Excluir");
        int indeceSerie = int.Parse(Console.ReadLine());

        repositorio.Exclui(indeceSerie);

      }
      private static void VisualizarSerie()
      {
        System.Console.WriteLine("Inserir ID da serie: ");
        int indeceSerie = int.Parse(Console.ReadLine());

        var serie = repositorio.RetornaPorId(indeceSerie);

        System.Console.WriteLine(serie);
      }
      private static string ObeterOpcaoUsuario()
      {
        System.Console.WriteLine();
        System.Console.WriteLine("DIO SERIES AO SEU DIPOES!!");
        System.Console.WriteLine("Informe a opcao desejada:");

        System.Console.WriteLine("1- Lista de Serie");
        System.Console.WriteLine("2- Inserir nova Serie");
        System.Console.WriteLine("3- Atualziar Serie");
        System.Console.WriteLine("4- Excluir serie");
        System.Console.WriteLine("5- Visualizar serie");
        System.Console.WriteLine("C- Limpar Tela");
        System.Console.WriteLine("X- Sair");
        System.Console.WriteLine();

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
      }
    
}
