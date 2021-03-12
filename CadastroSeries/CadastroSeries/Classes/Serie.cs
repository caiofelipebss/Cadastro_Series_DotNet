using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries
{
    public class Serie : EntidadeBase
    {
        //Atributos

        private Genero Genero { get; set; } //Enum
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        // Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Título: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + Ano + Environment.NewLine;
            retorno += "Exclúido: " + Excluido + Environment.NewLine;
            return retorno;
        }
        
        public string retornaTitulo()
        {
            return Titulo; 
        }

        public bool retornaExcluido()
        {
            return Excluido;
        }

        public int retornaId()
        {
            return Id;
        }

        public void Excluir()
        {
            Excluido = true;
        }
    }
}
