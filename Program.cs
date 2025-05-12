using System;
using AgendaCompromissos.Modelos;

namespace AgendaCompromissos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Agenda de Compromissos!");

            Console.Write("Informe o seu nome completo: ");
            string nomeUsuario = Console.ReadLine();

            Usuario usuario = new Usuario(nomeUsuario);

            while (true)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1. Registrar Compromisso");
                Console.WriteLine("2. Exibir Compromissos");
                Console.WriteLine("3. Sair");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RegistrarCompromisso(usuario);
                        break;
                    case "2":
                        ExibirCompromissos(usuario);
                        break;
                    case "3":
                        Console.WriteLine("Saindo do sistema...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void RegistrarCompromisso(Usuario usuario)
        {
            try
            {
                Console.Write("Data e hora do compromisso (dd/MM/yyyy HH:mm): ");
                DateTime dataHora = DateTime.Parse(Console.ReadLine());

                Console.Write("Descrição do compromisso: ");
                string descricao = Console.ReadLine();

                Console.Write("Nome do local: ");
                string nomeLocal = Console.ReadLine();

                Console.Write("Capacidade máxima do local: ");
                int capacidadeLocal = int.Parse(Console.ReadLine());

                Local local = new Local(nomeLocal, capacidadeLocal);

                Compromisso compromisso = new Compromisso(dataHora, descricao, usuario, local);

                Console.Write("Quantos participantes deseja adicionar? ");
                int numParticipantes = int.Parse(Console.ReadLine());

                for (int i = 0; i < numParticipantes; i++)
                {
                    Console.Write($"Nome do participante {i + 1}: ");
                    string nomeParticipante = Console.ReadLine();
                    Participante participante = new Participante(nomeParticipante);
                    compromisso.AdicionarParticipante(participante);
                }

                Console.Write("Quantas anotações deseja adicionar? ");
                int numAnotacoes = int.Parse(Console.ReadLine());

                for (int i = 0; i < numAnotacoes; i++)
                {
                    Console.Write($"Texto da anotação {i + 1}: ");
                    string textoAnotacao = Console.ReadLine();
                    compromisso.AdicionarAnotacao(textoAnotacao);
                }

                usuario.AdicionarCompromisso(compromisso);

                Console.WriteLine("Compromisso registrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar compromisso: {ex.Message}");
            }
        }

        static void ExibirCompromissos(Usuario usuario)
        {
            Console.WriteLine($"\nCompromissos de {usuario.NomeCompleto}:");
            if (usuario.Compromissos.Count == 0)
            {
                Console.WriteLine("Nenhum compromisso registrado.");
            }
            else
            {
                foreach (var compromisso in usuario.Compromissos)
                {
                    Console.WriteLine(compromisso);
                    foreach (var anotacao in compromisso.Anotacoes)
                    {
                        Console.WriteLine($"  - {anotacao}");
                    }
                    foreach (var participante in compromisso.Participantes)
                    {
                        Console.WriteLine($"  - {participante}");
                    }
                }
            }
        }
    }
}