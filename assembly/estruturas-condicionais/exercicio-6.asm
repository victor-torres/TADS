.text 

main:
	# Realiza a leitura do primeiro número
	addi	$2, $0, 5
	syscall
	add	$8, $0, $2
	# Realiza a leitura do segundo número
	addi	$2, $0, 5
	syscall
	add	$9, $0, $2
	# Verifica se o segundo é o maior que o primeiro
	bgt 	$8, $9, trocaValores
	j	imprimeValores
	
trocaValores:
	add 	$10, $0, $8
	add 	$8, $0, $9
	add 	$9, $0, $10
	j 	imprimeValores
	
imprimeValores:
	# Imprime primeiro número
	add 	$4, $0, $8
	addi	$2, $0, 1
	syscall
	# Imprime segundo número
	add 	$4, $0, $9
	addi	$2, $0, 1
	syscall
	j	fim
	
fim:
	nop
	