﻿namespace Desafio_Missait_Livraria
{
    public class CriarLivroDto
    {
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Resumo { get; set; }
        public int QtdPaginas { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
    }
}