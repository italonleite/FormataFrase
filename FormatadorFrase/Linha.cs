using System;

namespace FormatadorFrase
{
    public class Linha
    {
        public string Frase { get; set; }
        string[] split = null;

        public Linha()
        {
           
        }

        public int QuantidadeCaracterSemEspaco(string frase)
        {
        
            var split = frase.Split(" ");

            return split.Length;
        }

        public int QuantidadeCaracterComEspaco(string frase)
        {

            var chars = frase.ToCharArray();

            return chars.Length;
        }

        public string QuebrarLinha(string frase, int coluna)
        {
            var split = frase.Split(" ");
            
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Length > coluna) {

                }
            }
            return "text";
        }
    }
}