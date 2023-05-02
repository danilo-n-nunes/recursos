﻿using System.Globalization;
namespace Properties {
    class Produto {
        private string _nome;
        // private double _preco;
        public double Preco { get; private set; }
        // private int _quantidade;

        public int Quantidade { get; private set; }
        public Produto() {

        }

        public Produto(string nome, double preco) {
            _nome = nome;
            Preco = preco;
        }

        public string Nome { 
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        /*
        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }
        */

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}