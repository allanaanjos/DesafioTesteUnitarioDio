using TesteUnitarioDesafioConcole.service;

namespace TesteUnitarioDesafioTeste;

public class ValidacoesListaTeste
{
    private readonly ValidacoesLista _validacoesLista = new ValidacoesLista();


    [Theory]
    [InlineData(new int[] { 1, -2, 4, 10, 12, -9 }, new int[] { 1, 4, 10, 12 })]
    [InlineData(new int[] { -1, -2, -3 }, new int[] { })]
    [InlineData(new int[] { 0, 1, 2 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 5, 3, -2, 0 }, new int[] { 5, 3 })]
    public void DeveRemoverNumerosNegativosDeUmaLista(int[] numeros, int[] expected)
    {
       
        var result = _validacoesLista.RemoverNumerosNegativos(numeros.ToList());

        
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 4, 10, 9, 10, 19 })]
    public void DeveConterONumero9NaLista(int[] numeros)
    {
        Assert.All(numeros, num => Assert.True(_validacoesLista.ListaContemDeterminadoNumero(numeros.ToList(), 9)));
    }

    [Theory]
    [InlineData(new int[] { 1, 4, 8, 9, 14, 19 })]
    public void NaoDeveConterONumero10NaLista(int[] numeros)
    {
        Assert.All(numeros, num => Assert.False(_validacoesLista.ListaContemDeterminadoNumero(numeros.ToList(), 10)));
    }

    [Theory]
    [InlineData(new int[] { 5, 3, 4, 10, 7 }, new int[] { 10 , 6, 8, 20, 14 })]
    public void DeveMultiplicarOsElementosDaListaPor2(int[] numeros, int[] expected)
    {
        
        var result = _validacoesLista.MultiplicarNumerosLista(numeros.ToList(), 2);
 
        
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 4, 8, 9, 2 })]
    public void DeveRetornar9ComoMaiorNumeroDaLista(int[] numeros)
    {
        var result = _validacoesLista.RetornarMaiorNumeroLista(numeros.ToList());

        Assert.Equal(9, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 4, -8, 9, 2 })]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaList(int[] numeros)
    {
        var result = _validacoesLista.RetornarMenorNumeroLista(numeros.ToList());

        Assert.Equal(-8, result);
    }


}