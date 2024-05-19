using TesteUnitarioDesafioConcole.service;

namespace TesteUnitarioDesafioTeste
{
    public class ValidacoesStringTeste
    {
        private readonly ValidacoesString _validacoesLista = new ValidacoesString();


        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            string texto = "matrix";

            var result = _validacoesLista.RetornarQuantidadeCaracteres(texto);

            Assert.Equal(6, result);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            string texto = "Esse é um texto qualquer";
            string textoProcurado = "qualquer";

            var result = _validacoesLista.ContemCaractere(texto, textoProcurado);

            Assert.True(result);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            string texto = "Esse é um texto qualquer";
            string textoProcurado = "teste";

            var result = _validacoesLista.ContemCaractere(texto, textoProcurado);

            Assert.False(result);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            var texto = "Começo, meio e fim do texto procurado";
            var TextoProcurado = " procurado";

            var result = _validacoesLista.TextoTerminaCom(texto, TextoProcurado);

            Assert.True(result);
        }
    }
}