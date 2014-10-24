.text 

main:
	# Inicializa o contador
	addi 	$6, $0, 4
	addi 	$7, $0, 0
	
	# Realiza a primeira leitura de um número
	addi	$2, $0, 5
	syscall
	
	# Inicializa o menor e o maior número
	add	$8, $0, $2
	add	$9, $0, $2
	
	j 	condicao
	
leitura:
	# Realiza a leitura de um número
	addi	$2, $0, 5
	syscall
	
verifica:
	# Verifica se é o maior 
	bgt 	$2, $9, maior
	# Verifica se é o menor 
	blt 	$2, $8, menor
	
decrementa:
	addi 	$5, $6, -1
	add 	$6, $0, $5
	
condicao:
	blt 	$7, $6, leitura
	j 	fim
	
menor:
	add 	$8, $0, $2
	j 	decrementa
	
maior:
	add 	$9, $0, $2
	j 	decrementa
	
fim:
	# Imprime o resultado na tela
	add 	$4, $0, $8
	addi	$2, $0, 1
	syscall
	add 	$4, $0, $9
	addi	$2, $0, 1
	syscall
	nop
	