using Xunit;
using Shouldly;

public class FizzBuzzTests
{
    [Fact]
    public void Quando_Passado_1_DeveRetornar_1()
    {
        // Arrange
        var numeroParaTestar = 1;
        var resultadoEsperado = "1";

        // Act
        var resultadoReal = FizzBuzz.Of(numeroParaTestar);

        // Assert
        resultadoReal.ShouldBe(resultadoEsperado);
    }
}
