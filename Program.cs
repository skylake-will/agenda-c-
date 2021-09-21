using System;
using System.Collections.Generic;


namespace Agenda
{
    class Program
    {

        static void Main(string[] args)
        {

            String[] nomes = new string[100];

            String[] sobrenomes = new string[100];

            String[] telefones = new string[100];

            String[] emails = new string[100];

            String[] cidades = new string[100];

            String[] tipos = new string[100];

            String[] aniversarios = new string[100];

            String[] observações = new string[100];

            String opcao = "";

            int position = 0;

            string deletarNome = "";

            string buscarNome = "";

            //string buscarSobrenome = "";

            string buscarPhone = "";

            //string buscarEmail = "";

            //string buscarCidade = "";

            //string buscarTipo = "";

            for (int i = 0; i < 100; i++)
            {

                nomes[i] = "";
                telefones[i] = "";
            }

            do
            {
                Console.WriteLine("\nO que gostaria de fazer? -> Adicionar | Listar | Buscar | Deletar | Sair\n ");

                string entrada = Console.ReadLine();

                opcao = entrada;



                switch (opcao)
                {

                    case "Adicionar":


                        Console.WriteLine("\nPrimeiro Nome: ");
                        string addNome = Console.ReadLine();
                        nomes[position] = addNome;

                        //Console.WriteLine("\nSobrenome: ");
                        //string addSobrenome = Console.ReadLine();
                        //nomes[position] = addSobrenome;


                        Console.WriteLine("\nTelefone: ");
                        string addPhone = Console.ReadLine();
                        telefones[position] = addPhone;

                        //Console.WriteLine("\nEmail: ");
                        //string addEmail = Console.ReadLine();
                        //emails[position] = addEmail;

                        //Console.WriteLine("\nEndereço: ");
                        //string addCity = Console.ReadLine();
                        //cidades[position] = addCity;

                        //Console.WriteLine("\nTipo de telefone: ");
                        //string addTipos = Console.ReadLine();
                        //cidades[position] = addTipos;

                        position++;

                        break;

                    case "Listar":

                        for (int i = 0; i < 100; i++)
                        {
                            if (!(nomes[i].Equals("")))
                            {

                                Console.WriteLine($"\nNome: {nomes[i]}, \nTelefone: {telefones[i]}, \nSobrenomes: {sobrenomes[i]}," +
                                    $" \nEmail: {emails[i]}, \nCidade: {cidades[i]}");

                            }

                        }

                        break;

                    case "Buscar":

                        Console.WriteLine("\nBuscar pelo nome ou telefone: ");

                        string buscar = Console.ReadLine();

                        buscarNome = buscar;

                        //buscarSobrenome = buscar;

                        buscarPhone = buscar;

                        //buscarEmail = buscar;

                        //buscarCidade = buscar;

                        //buscarTipo = buscar;

                        for (int i = 0; i < 100; i++)
                        {
                            if (nomes[i].Equals(buscarNome))
                            {

                                Console.WriteLine($"\nNome: {nomes[i]}, \nTelefone: {telefones[i]}, \nSobrenomes: {sobrenomes[i]}," +
                                $" \nEmail: {emails[i]}, \nCidade: {cidades[i]}");

                            }
                            //else if (sobrenomes[i].Equals(buscarSobrenome))
                            //{
                            //    Console.WriteLine($"\nSobrenomes: {sobrenomes[i]}, \nNome: {nomes[i]}, \nTelefone: {telefones[i]}, ," +
                            //    $" \nEmail: {emails[i]}, \nCidade: {cidades[i]}");

                            //}
                            else if (telefones[i].Equals(buscarPhone))
                            {

                                Console.WriteLine($"\nTelefone: {telefones[i]}, \nNome: {nomes[i]}, , \nSobrenomes: {sobrenomes[i]}," +
                                $"\nEmail: {emails[i]}, \nCidade: {cidades[i]}");

                            }
                            //else if (emails[i].Equals(buscarEmail))
                            //{

                            //    Console.WriteLine($"\nEmail: {emails[i]}, \nNome: {nomes[i]}, \nTelefone: {telefones[i]}, \nSobrenomes: {sobrenomes[i]}," +
                            //    $"\nCidade: {cidades[i]}");

                            //}
                            //else if (cidades[i].Equals(buscarCidade))
                            //{

                            //    Console.WriteLine($"\nCidade: {cidades[i]}, \nNome: {nomes[i]}, \nTelefone: {telefones[i]}, \nSobrenomes: {sobrenomes[i]}," +
                            //    $" \nEmail: {emails[i]}");

                            //}
                            //else if (tipos[i].Equals(buscarTipo))
                            //{

                            //    Console.WriteLine($"\nTipo de telefone: {tipos[i]}, \nCidade: {cidades[i]}, \nNome: {nomes[i]}, \nTelefone: {telefones[i]}, \nSobrenomes: {sobrenomes[i]}," +
                            //    $" \nEmail: {emails[i]}");

                            //}
                        }


                        break;

                    case "Deletar":

                        Console.WriteLine("Digite o nome de quem quer excluir");

                        string apagar = Console.ReadLine();

                        deletarNome = apagar;

                        for (int i = 0; i < 100; i++)
                        {
                            if (nomes[i].Equals(deletarNome))
                            {

                                nomes[i] = "";
                                telefones[i] = "";
                            }
                        }


                        break;

                    case "Sair":

                        Console.WriteLine("O programa foi finalizado");
                        return;


                    default:

                        Console.WriteLine("Opção Inválida! \nEscolha uma das opções apresentadas.");

                        break;
                }

            } while (!(opcao.Equals("Sair")));

        }
    }
}



