.text

main: 
	# Registrador	| Informação
	# ---------------------------
	# 7		| Dia
	# 8		| Mês
	# 9		| Ano
	# 10		| Auxiliar
	# 11		| Auxiliar
	# 15		| Auxiliar (último valor do [dia/mês/ano])
	
	j 	leitura

leitura: 
	# Lê o Dia
	addi 	$2, $0, 5
	syscall
	add 	$7, $0, $2
	
	# Lê o Mês
	addi 	$2, $0, 5
	syscall
	add 	$8, $0, $2
	
	# Lê o Ano
	addi 	$2, $0, 5
	syscall
	add 	$9, $0, $2
	
	j 	testes
	
testes:
	# Verifica se o ano é válido,
	# ou seja, se ele é maior ou igual a 0
	blt 	$9, $0, invalida
	
	# Verifica se o mês é valido,
	# ou seja, se é maior que 0 e
	# menor que 13
	addi 	$10, $0, 1
	blt 	$8, $10, invalida
	addi 	$10, $0, 12
	bgt 	$8, $10, invalida
	
	# Verifica, inicialmente, se o dia
	# é válido, ou seja, se é maior do que 0
	addi 	$10, $0, 1
	blt 	$7, $10, invalida
	
	# Verifica se o mês é fevereiro
	addi 	$10, $0, 2
	beq	$8, $10, fevereiro
	
	# Verifica se o mês é anterior a agosto
	addi 	$10, $0, 8
	blt	$8, $10, anterior
	j 	posterior
	
fevereiro:
	# Verifica se o ano pode ser bissexto
	addi 	$10, $0, 4
	div	$9, $10
	mfhi	$10
	bne	$10, $0, normal
	j 	bissexto
	
normal:
	addi	$10, $0, 28
	add	$15, $10, $0
	j 	verifica
	
anterior:
	# Verifica se o mês é par
	add	$10, $0, $8
	sll	$11, $10, 31
	srl 	$10, $11, 31
	beq 	$10, $0, trinta
	j 	trintaeum

posterior: 
	# Verifica se o mês é par
	add	$10, $0, $8
	sll	$11, $10, 31
	srl 	$10, $11, 31
	beq 	$10, $0, trintaeum
	j 	trinta

trinta:
	# Verifica se o dia é válido,
	# ou seja, possui até 30 dias
	addi 	$10, $0, 30
	add	$15, $10, $0
	j	verifica

trintaeum:
	# Verifica se o dia é válido,
	# ou seja, possui até 31 dias
	addi 	$10, $0, 31
	add 	$15, $10, $0
	j	verifica
	
verifica:
	bgt	$7, $10, invalida
	j 	valida
	
valida:
	addi	$10, $0, 1
	j 	segundaparte
	
invalida:
	addi 	$10, $0, 0
	j 	segundaparte
	
bissexto:
	# Verifica se é divisível por 100
	addi 	$10, $0, 100
	div 	$9, $10
	mfhi 	$10
	beq	$10, $0, podenaoser
	j 	bissextosim
	
podenaoser:
	# Verifica se não é divisível por 400
	addi 	$10, $0, 400
	div 	$9, $10
	mfhi 	$10
	bne 	$10, $0, normal
	j 	bissextosim
	
bissextosim:
	# O ano é bissexto
	addi 	$10, $0, 29
	add	$15, $10, $0
	j 	verifica
	
segundaparte:
	# Verifica se a data é válida
	beq	$10, $0, datainvalida
	# Verifica se é o último dia do mês
	beq 	$7, $15, ultimodia
	# Não é o último dia, apenas incrementa
	add	$11, $7, $0
	addi	$7, $11, 1
	j 	imprimedata
	
ultimodia:
	# Define o dia como sendo o primeiro do mês
	addi 	$7, $0, 1
	# Verifica se é o último mês do ano
	addi	$10, $0, 12
	beq	$8, $10, ultimomes
	# Apenas incrementa o mês
	add	$11, $8, $0
	addi	$8, $11, 1
	j 	imprimedata
	
ultimomes:
	# Define o mês como sendo o primeiro do ano
	addi	$8, $0, 1
	# Incrementa o ano
	add	$11, $9, $0
	addi	$9, $11, 1
	j	imprimedata
	
imprimedata:
	# Imprime o dia
	add	$4, $0, $7
	addi	$2, $0, 1
	syscall
	# Imprime o mês
	add	$4, $0, $8
	addi	$2, $0, 1
	syscall
	# Imprime o ano
	add	$4, $0, $9
	addi	$2, $0, 1
	syscall
	j 	fim
	
datainvalida:
	add 	$4, $0, $10
	addi 	$2, $0, 1
	syscall
	j	fim
	
fim:
	nop
