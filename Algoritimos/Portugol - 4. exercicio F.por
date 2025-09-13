programa
{
	
	funcao inicio()
	{
	inteiro nota,nota2,media,prime
	escreva("Digite a primeira nota:")
	leia(nota)
	escreva("Digite a segundo nota:")
	leia(nota2)

	enquanto(nota>10 e nota2>10)
		{
			limpa()
			escreva("Digite a primeira nota:")
			leia(nota)
			escreva("Digite a segundo nota:")
			leia(nota2)
		}
		prime=nota+nota2
		media=prime/2
			escreva("A media dele é: ",media)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 390; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
