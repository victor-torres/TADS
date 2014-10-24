# Lista 2

## ￼Implementar programas em C# para:### I. Decisão
1. Ler quatro valores inteiros, calcular e mostrar a média aritmética entre eles. Mostrar também os números menores e os números maiores ou iguais à média.
	```	Digite quatro valores inteiros 1	2	3	10	Média = 4	Números menores que a média 1	2	3	Números maiores que a média 10	```
2. Ler dois valores de horas e minutos no formato hh:mm e calcular a soma entre eles. O valor somado dos minutos não deve ser maior ou igual a 60.
	```	Digite o primeiro horário no formato hh:mm 3:30	Digite o segundo horário no formato hh:mm 4:40	Total de horas = 8:10	```
3. Ler três valores inteiros e calcular a soma do menor valor com o maior.
	```	Digite três valores inteiros 2	1	3	A soma do maior com o menor número é 4.	```
4. Ler a quantidade de horas e minutos marcados em um relógio analógico e calcular o menor ângulo formado entre os ponteiros do relógio. Mostrar uma mensagem de “Hora Inválida” se os valores fornecidos não formarem uma hora válida.
	```	Digite o horário no formato hh:mm 3:30	Menor ângulo entre os ponteiros = 75 graus	```

5. Ler 4 valores inteiros diferentes e realizar as seguintes operações: verificar se os valores são realmente diferentes e mostrar uma mensagem de erro caso contrário; mostrar o maior valor lido; mostrar o menor valor lido e mostrar o resultado da soma entre o segundo maior valor e o segundo menor.

	```	Digite quatro valores inteiros 1	2	3	10	Maior valor = 10	Menor valor = 1	A soma do segundo maior valor com o segundo menor = 5	```
6. Ler 10 números inteiros do teclado, mostrar o maior e o menor número.
	```	Digite dez valores inteiros 1	2	3	4 5 6 7 8 9 10	O maior valor é 10 e o menor é 1	```
7. Ler uma data no formato "dd/mm/aaaa" e mostrar no formato "dd de mês de aaaa"
	```	Digite uma data no formato dd/mm/aaaa 11/08/2013	A data é 11 de agosto de 2013	```
8. Ler uma string com dois valores inteiros positivos entre um operador ( +, –, * ou / ) e calcular o resultado da operação matemática utilizando estes valores e o operador.
	```	Digite dois valores inteiros separados por um operador +, -, * ou / 20+100	O resultado da operação é 120	```### II. Repetição
1. Mostrar os inteiros de 1 a 10 em ordem crescente.	```	Resultado: 1 2 3 4 5 6 7 8 9 10	```

2. Mostrar os inteiros de 1 a 10 em ordem decrescente. 

	```
	Resultado: 10 9 8 7 6 5 4 3 2 13.
	```

3. Mostrar a sequência de números abaixo. 
	```	Resultado: 1 -2 3 -4 5 -6 7 -8 9 -10	```
	Obs: Sequência dada pelos números de 1 a 10, invertendo o sinal. 
4. Mostrar a sequência de números abaixo.
	```	Resultado: 1 2 4 7 11 16 22 29 37 46	```
		Obs: Sequência inicia com 1, a partir daí, soma o primeiro valor com 1, o segundo valor com 2, o terceiro com 3, o quarto por 4 e assim por diante.5. Ler uma frase e mostrar as strings obtidas a partir desta, removendo uma a uma a palavra no início.
	```	Digite uma frase:	Técnico em Informática para Internet		em Informática para Internet
	Informática para Internet 
	para Internet	Internet	```
6. Ler uma frase e mostrá-la repetidas vezes, de acordo com o número de caracteres desta, informando o número da repetição antes da frase.
	```	Digite uma frase:
	Brasil
		1 - Brasil	2 - Brasil 
	3 - Brasil 
	4 - Brasil 
	5 - Brasil 
	6 - Brasil
	```7. Ler uma frase e mostrar as strings obtidas a partir desta, passando uma a uma a letra inicial para o final, até que a frase inicial seja apresentada.
	```	Digite uma frase: 	Brasil
		rasilB 	asilBr 	silBra 
	ilBras 
	lBrasi 
	Brasil	```

8. Ler uma frase e contar o número de palavras.

	```	Digite uma frase:
		Técnico em Informática para Internet	5	```
9. Ler uma frase e mostrar cada uma de suas palavras separadamente.
	```	Digite uma frase:	Técnico em Informática para Internet
	Técnico 	em 
	Informática 
	para 
	Internet	```
10. Ler uma frase e mostrar de trás para frente.
	```	Digite uma frase:	Técnico em Informática para Internet
		tenretnI arap acitámrofni me ocincéT	```
11. Ler uma frase e montar uma senha formada pelo número de caracteres de cada palavra.
	```	Digite uma frase:	Técnico em Informática para Internet
		721148	```
12. Ler uma sequência de números inteiros separados por vírgula e calcula a soma destes valores.
	```	Digite uma sequência de números separados por vírgula: 
	1,2,3,4,5	Soma = 15	```
13. Mostrar a sequência de números abaixo.
	```	Resultado: 1 2 3 6 4 5 6 15 7 8 9 24 ... 28 29 30 87	```	Obs: Sequência de valores de 1 a 30, incluindo a cada três valores a soma dos três elementos anteriores.
14. Mostrar a tabuada de 1 a 10.
	```	Tabuada de 1 	1x1=1 1x2=2	...	1 x 10 = 10 	Tabuada de 2	2x1=2 2x2=4	...	2 x 10 = 20	...	Tabuada de 10 	10 x 1 = 10	10 x 2 = 20	...	10 x 10 = 100	```### III. Métodos
1. Ler um nome e apresentar todas as suas iniciais, utilizando o método Iniciais cujo protótipo é apresentado abaixo.	```	string Iniciais(string s)
	```
2. Ler uma frase e gerar uma senha formada pelo número de caracteres de cada palavra da frase, utilizando o método Senha cujo protótipo é apresentado abaixo.	```	string Senha(string s)
	```
3. Ler o mês e o ano de uma data e retornar a data do último dia do mês no formato "dd/mm/aaaa", utilizando o método UltimoDia cujo protótipo é apresentado abaixo.	```	string UltimoDia(int mes, int ano)	```
4. Ler uma data de nascimento no formato "dd/mm/aaaa" e calcular a idade em meses e anos, considerando o dia atual como referência, utilizando o método Idade cujo protótipo é apresentado abaixo.	```	void Idade(string data, out int anos, out int meses)
	```5. Obter a soma dos números em um intervalo, utilizando o método Soma cujo protótipo é apresentado abaixo.	```	int Soma(int inicio, int fim)
	```6. Ler dois números e calcular o MDC e o MMC entre eles, utilizando os métodos abaixo:
	```	int MDC(int x, int y)	int MMC(int x, int y)	```
---Prof. Gilbert Azevedo da Silva