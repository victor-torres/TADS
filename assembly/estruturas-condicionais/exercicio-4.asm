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
	# Realiza a leitura do terceiro número
	addi	$2, $0, 5
	syscall
	add	$10, $0, $2
	# Verifica se o primeiro é o maior que o segundo
	bgt 	$8, $9, primeiro
	j	segundo
	
primeiro:
	add	$11, $0, $8
	j 	verificaTerceiro
	
segundo:
	add	$11, $0, $9
	j 	verificaTerceiro
	
verificaTerceiro:
	bgt 	$10, $11, terceiro
	add 	$4, $0, $11
	j 	fim
	
terceiro:
	add 	$4, $0, $10
	j	fim
	
fim:
	addi	$2, $0, 1
	syscall
	nop
	