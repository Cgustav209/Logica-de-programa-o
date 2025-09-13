programa
{
	
	funcao inicio()
	{
		inteiro tipo
		real result,valor,valor2
		
		escreva("Selecione que tipo de conta você quer fazer\n")
		escreva("1) para adiçâo, 2) para subtração, 3) para multiplicação, 4) para divisão")
		escreva("digite: ")
		leia(tipo)
		escreva("selecione um valor: ")
		leia(valor)
		escreva("selecione um valor: ")
		leia(valor2)

		escolha(tipo){
			caso 1:
					result= valor+valor2
					escreva("R:",result)
			pare
			
			caso 2:
					result= valor-valor2
					escreva("R:",result)
			pare
			
			caso 3:
			
					result= valor*valor2
					escreva("R:",result)
			pare
			
			caso 4:
				se(valor==0){
			 		escreva("Numeros nâo podem ser dividido por Zero")		
			}
				senao{
					result= valor/valor2
					escreva("R:",result)
			}
			pare
			
			caso contrario:
					escreva("Escolha uma operação valida !")
	}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 805; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
