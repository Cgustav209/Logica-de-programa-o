programa
{
	
	funcao inicio()
	{
		inteiro tipo,press
		real result,valor,valor2
		cadeia respo

		limpa()
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
					escreva("R:",result,"\n")
			pare
			
			caso 2:
					result= valor-valor2
					escreva("R:",result,"\n")
			pare
			
			caso 3:
			
					result= valor*valor2
					escreva("R:",result,"\n")
			pare
			
			caso 4:
				se(valor==0){
			 		escreva("Numeros nâo podem ser dividido por Zero")		
			}
				senao{
					result= valor/valor2
					escreva("R:",result,"\n")
			}
			pare
			
			caso contrario:
					escreva("Escolha uma operação valida !")
	
	}
	
			escreva("\nQuer continuar?\n")
			escreva("Não digite(N) ou Sim digite(S)?\n")
			escreva("R:")
			leia(respo)
			limpa()
		enquanto(respo=="S")
	{
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
					escreva("R:",result,"\n")
			pare
			
			caso 2:
					result= valor-valor2
					escreva("R:",result,"\n")
			pare
			
			caso 3:
			
					result= valor*valor2
					escreva("R:",result,"\n")
			pare
			
			caso 4:
				se(valor==0){
			 		escreva("Numeros nâo podem ser dividido por Zero")		
			}
				senao{
					result= valor/valor2
					escreva("R:",result,"\n")
			}
			pare
			
			caso contrario:
					escreva("Escolha uma operação valida !")
	
	}
	
		escreva("\nQuer continuar?\n")
		escreva("Não digite(N) ou Sim digite(S)?\n")
		escreva("R:")
		leia(respo)
	
	}
	
}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 106; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */