usando o sistema;

namespace DIO. Série
{
     Programa de classe
    {
        static SerieRepositorio repositorio = novo SerieRepositorio();
        vazio estático Principal(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			enquanto (opcaoUsuario. Toupper() !=  "X" )
			{
				switch (opcaoUsuario)
				{
					caso  "1":
						ListarSeries();
						quebrar;
					caso  "2":
						InserirSerie();
						quebrar;
					caso  "3":
						AtualizarSerie();
						quebrar;
					caso  "4":
						ExcluirSerie();
						quebrar;
					caso  "5":
						VisualizarSerie();
						quebrar;
					caso  "C":
						Console. Claro();
						quebrar;

					padrão:
						lançar novo ArgumentOutOfRangeException();
				}
				opcaoUsuario = ObterOpcaoUsuario();
			}
			Console. WriteLine("Obrigado por utilizar nossos serviços" );
			Console. ReadLine();
        }

        corda estática privada ObterOpcaoUsuario()
		{
			Console. WriteLine();
			Console. WriteLine("Informe a opção desejada:" );

			Console. WriteLine("1 - Listar séries" );
			Console. WriteLine("2 - Inserir nova série" );
			Console. WriteLine("3 - Atualizar série" );
			Console. WriteLine("4 - Excluir série" );
			Console. WriteLine("5 - Visualizar série" );
			Console. WriteLine("C - Limpa Tela" );
			Console. WriteLine("X - Sair" );
			Console. WriteLine();

			string opcaoUsuario = Console. ReadLine(). Toupper();
			Console. WriteLine();
			
			retorno opcaoUsuario;
		}

        vazio estático privado ListarSeries()
		{
			Console. WriteLine("Listar séries" );

			var lista = repositório. Lista();

			se (lista. . Conde == 0)
			{
				Console. WriteLine("Nenhuma série cadastrada". );
				retornar;
			}

			foreach (var serie na lista)
			{
                var excluido = serie. retornaExcluido();
				Console. WriteLine("#ID {0}: - {1} {2}", serie. retornaId(), serie. retornaTitulo(),(excluido ?  "*Excluído*"   ""));
			}
		}

        vazio estático privado InserirSerie()
		{
			Console. WriteLine("Inserir nova série" );

			foreach (int i em Enum. GetValues(typeof(Genero)))
			{
				Console. WriteLine("{0}-{1}", i, Enum. GetName(typeof(Genero), i));
			}

			Console. Escreva( "Digite o gênero entre as opções acima: " );
			int entradaGenero = int. Parse(Console. ReadLine());

			Console. Write("Digite o Título da Série: " );
			string entradaTitulo = Console. ReadLine();

			Console. Write("Digite o Ano de Início da Série: " );
			int entradaAno = int. Parse(Console. ReadLine());

			Console. Escreva("Digite a Descrição da Série: " );
			string entradaDescricao = Console. ReadLine();

			Serie novaSerie = nova Serie(id: repositorio. ProximoId (em proximoid).
										genero:(Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositório. Insere(novaSerie);
		}

        vazio estático privado AtualizarSerie()
		{
			Console. Escreva("Digite o ID da série: " );
			índice de intSerie  = int. Parse(Console. ReadLine());

			foreach (int i em Enum. GetValues(typeof(Genero)))
			{
				Console. WriteLine("{0}-{1}", i, Enum. GetName(typeof(Genero), i));
			}

			Console. Escreva( "Digite o gênero entre as opções acima: " );
			int entradaGenero = int. Parse(Console. ReadLine());

			Console. Write("Digite o Título da Série: " );
			string entradaTitulo = Console. ReadLine();

			Console. Write("Digite o Ano de Início da Série: " );
			int entradaAno = int. Parse(Console. ReadLine());

			Console. Escreva("Digite a Descrição da Série: " );
			string entradaDescricao = Console. ReadLine();

			Serie atualizaSerie = nova Serie(id: índiceSerie,
										genero:(Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositório. Atualiza(índiceSerie, atualizaSerie);
		}

        vazio estático privado ExcluirSerie()
		{
			Console. Escreva("Digite o ID da série: " );
			índice de intSerie  = int. Parse(Console. ReadLine());

			repositório. Exclui(índicesSerie);
		}

        vazio estático  privado VisualizarSerie()
		{
			Console. Escreva("Digite o ID da série: " );
			índice de intSerie  = int. Parse(Console. ReadLine());

			var serie = repositório. RetornaPorId(índiceSerie);
			Console. WriteLine(serie);
		}
    }
}
