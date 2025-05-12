using System;

namespace AgendaCompromissos.Modelos
{
    public class Anotacao
    {
        public string Texto { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public Anotacao(string texto)
        {
            Texto = texto;
            DataCriacao = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Anotação: {Texto} (Criada em: {DataCriacao})";
        }
    }
}