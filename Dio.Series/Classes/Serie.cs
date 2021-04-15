using System;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos

        private Genero _genero { get; set; }

        private string _titulo { get; set; }

        private string _descricao { get; set; }

        private int _ano { get; set; }

        private bool _excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            _genero = genero;
            _titulo = titulo;
            _descricao = descricao;
            _ano = ano;
            _excluido = false;
        }

        public override string ToString()
        {
            string retorno = " ";
            retorno += "Gênero: " + _genero + Environment.NewLine;
            retorno += "Título: " + _titulo + Environment.NewLine;
            retorno += "Descrição: " + _descricao + Environment.NewLine;
            retorno += "Ano de Início: " + _ano;
            retorno += " Excluída: " + _excluido;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return _titulo;
        }

        public int RetornaId()
        {
            return Id;
        }

        public bool RetornaExcluido()
        {
            return _excluido;
        }

        public void Excluir()
        {
            _excluido = true;
        }
    }
}
