using System;
using Xunit;

namespace FormatadorFrase
{
    public class UnitTestFrase
    {
        [Fact]
        public void Deve_retornar_quantidade_array_frase_sem_espaco()
        {
            string frase = "xxx yyy";
            Linha linha = new Linha();

            int resultado = linha.QuantidadeCaracterSemEspaco(frase);

            Assert.Equal(2, resultado);

        }
        [Fact]
        public void Deve_retornar_quantidade_array_frase_com_espaco()
        {
            string frase = "xxx yyy";
            Linha linha = new Linha();

            int resultado = linha.QuantidadeCaracterComEspaco(frase);

            Assert.Equal(7, resultado);

        }

        [Fact]
        public void Deve_quebrar_linha_acima_do_tamanho_da_coluna()
        {
            string frase = "xxx yyy";
            int coluna = 2;
            Linha linha = new Linha();

            string resultado = linha.QuebrarLinha(frase, coluna);

           // Assert.Equal(7, resultado);

        }
    }
}
