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
	# Verifica se o primeiro é o maior
	bgt 	$8, $9, primeiro
	j	segundo
	
primeiro:
	add	$4, $0, $8
	j 	fim
	
segundo:
	add	$4, $0, $9
	j 	fim
	
fim:
	addi	$2, $0, 1
	syscall
	nop
	