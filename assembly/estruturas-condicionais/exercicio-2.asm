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
	# Verifica se os números são iguais
	beq	$8, $9, iguais
	j	diferentes
	
iguais:
	addi	$4, $0, 1
	j 	fim
	
diferentes:
	addi	$4, $0, 0
	j 	fim
	
fim:
	addi	$2, $0, 1
	syscall
	nop
	