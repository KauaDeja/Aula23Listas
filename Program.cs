﻿using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {
             // Criamos uma nova lista do tipo "Produto"
            List<Produto> produtos = new List<Produto>();

            // Criamos um produto através do construtor padrão
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "SmartTV LG";
            produto1.Preco = 2300.99f;

            // Adicionamos o produto criado na lista
            produtos.Add(produto1);

            // Adicionamos mais produtos utilizando o novo construtor
            produtos.Add( new Produto(2, "Geladeira Eletrolux", 6800.90f) );
            produtos.Add( new Produto(3, "Microondas", 6800.99f) );
            produtos.Add( new Produto(4, "Fogão Eletrolux", 6800.99f) );
            produtos.Add( new Produto(5, "Xbox Series X", 16800.99f) );
            produtos.Add( new Produto(7, "Microondas", 6800.99f) );
            produtos.Add( new Produto(6, "PS5", 16800.99f) );

            // Varremos a lista com foreach
            foreach(Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine( $"R$ {item.Preco} - {item.Nome} " );
                Console.ResetColor();
            }
            
            // Remover item passando o objeto como argumento
            produtos.Remove(produto1);

            // Remover item pelo índice
            produtos.RemoveAt(2);

            // Usamos expressão lambda para eliminar um registro
            produtos.RemoveAll(y => y.Nome == "Microondas");

            // Varremos nossa lista depois que foi alterada
            foreach(Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine( $"R$ {item.Preco} - {item.Nome} " );
                Console.ResetColor();
            }

            // Podemos encontrar um produto específico utilizando Lambda
            Produto ps5 = produtos.Find(x => x.Codigo == 6);

            Console.WriteLine("PS5 - R$ " + ps5.Preco);

            // Aplicar o complemento da atividade:

            // Lista com método construtor
            List<Cartao> cartaos = new List<Cartao>();
            cartaos.Add(new Cartao("Kaua Deja da Silva",123456789,"MasterCard"));
            cartaos.Add(new Cartao("Yan Advincula",987654321,"Scielo"));
            cartaos.Add(new Cartao("Leila",123456789,"Visa"));
            cartaos.Add(new Cartao("nicolas",123456789,"Elo"));
            cartaos.Add(new Cartao("Lucca",246810578,"HiperCard"));
            cartaos.Add(new Cartao("Leila",53789698,"Itau"));

            //Varrer Lista
            foreach (Cartao item in cartaos)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine( $"R$ {item.titular} - {item.numero} / {item.bandeira} " );
                Console.ResetColor();
            }   
            //Usamos expressão lambda para eliminar um registro
                cartaos.RemoveAll(a =>a.titular == "Leila");

              foreach (Cartao item in cartaos)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine( $"R$ {item.titular} - {item.numero} / {item.bandeira} " );
                Console.ResetColor();
            }

        }

    }
}
