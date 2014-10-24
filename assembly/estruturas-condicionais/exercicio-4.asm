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
	# O primeiro número é umcandidato a maior número
	add	$11, $0, $8
	j 	verificaTerceiro
	
segundo:
	# O segundo número é umcandidato a maior número
	add	$11, $0, $9
	j 	verificaTerceiro
	
verificaTerceiro:
	# Verifica se o terceiro número é maior que o outro candidato
	bgt 	$10, $11, terceiro
	# O candidato é o maior número
	add 	$4, $0, $11
	j 	fim
	
terceiro:
	# O terceiro é o maior número
	add 	$4, $0, $10
	j	fim
	
fim:
	addi	$2, $0, 1
	syscall
	nop
	