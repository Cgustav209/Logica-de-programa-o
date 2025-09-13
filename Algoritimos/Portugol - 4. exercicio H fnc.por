programa
{
	
	funcao inicio()
	{
		inteiro num,menor,maior,aux
	menor=0
	maior=0
	aux=0

	faca{

		escreva("digite um valor:")
		leia(num)
		se(num>maior){
			maior = num
			}
			enquanto(aux==0 e num>=0)
			{
			menor=num
			aux++	
			}
		se(menor>num e num>=0){
	
		menor=num
			
		}
			
		}
	enquanto(num>0)
	escreva("O maoir numero é: ",maior,"\n")
	escreva("O menor numero é: ", menor)
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 96; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
