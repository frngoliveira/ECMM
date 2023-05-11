using System.ComponentModel.DataAnnotations.Schema;

namespace FRN.Domain.Notifications
{
    public class Notifies
    {
        public Notifies() 
        {
            Notitycoes = new List<Notifies>();
        }
        [NotMapped]
        public String NomePropriedade { get; set; }
        [NotMapped]
        public String Mensagem { get; set; }
        [NotMapped]
        public List<Notifies> Notitycoes;    

        public bool ValidPropriesString(string valor, string NomePropriedade)
        {
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(NomePropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = NomePropriedade
                });
                return false;
            }
            return true;
        }
        public bool ValidPropriesInt(int valor, string NomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(NomePropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = NomePropriedade
                });
                return false;
            }
            return true;
        }
        public bool ValidPropriesDecimal(decimal valor, string NomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(NomePropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = NomePropriedade
                });
                return false;
            }
            return true;
        }
    }
}
