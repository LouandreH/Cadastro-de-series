namespace Aprender.Classes
{
    public class Serie : EntidadeBase
    {

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.Id= id;

        }
     
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido {get; set;}


        public override string ToString()
        {
            string  retorno = "";

            retorno += "Genero: " + this.Genero +Environment.NewLine;
            retorno += "Titulo: " + this.Titulo +Environment.NewLine;
            retorno += "Descricao: " + this.Descricao +Environment.NewLine;            
            retorno += "Ano de Inicio: " + this.Ano+Environment.NewLine;
            retorno += "Execluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool Excluir(){
            return this.Excluido = true;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }

}