.text

main:
	# ################### #
	# Informações         #
	# ################### #
	
	# Registrador	| Informação
	# ---------------------------
	# 7		| Valor A
	# 8		| Valor B
	# 9		| Valor C
	# 10		| Auxiliar
	
	# ################### #
	# Leitura dos valores #
	# ################### #
	
	# Faz a leitura do Valor A
	addi	$2, $0, 5
	syscall
	# Armazena o resultado no registrador 7
	add	$7, $2, $0
	
	# Faz a leitura do Valor B
	addi	$2, $0, 5
	syscall
	# Armazena o resultado no registrador 8
	add	$8, $2, $0
	
	# Faz a leitura do Valor C
	addi	$2, $0, 5
	syscall
	# Armazena o resultado no registrador 9
	add	$9, $2, $0
	
	# ################### #
	# Ordenação	      #
	# ################### #
	
	j	verifica_bgta
	
verifica_bgta:
	# Verifica se B é maior do que A
	bgt	$8, $7, bgta
	j 	verifica_cgta
	
verifica_cgta:
	# Verifica se C é maior do que A
	bgt	$9, $7, cgta
	j 	verifica_cgtb
	
verifica_cgtb:
	# Verifica se C é maior do que B
	bgt	$9, $8, cgtb
	j 	fim
	
bgta:
	# Troca os valores A e B
	add	$10, $7, $0
	add	$7, $8, $0
	add	$8, $10, $0
	j	verifica_cgta
	
cgta:
	# Troca os valores A e C
	add	$10, $7, $0
	add	$7, $9, $0
	add	$9, $10, $0
	j	verifica_cgtb
	
cgtb:
	# Troca os valores B e C
	add	$10, $9, $0
	add	$9, $8, $0
	add	$8, $10, $0
	j	fim
	
fim:
	# ################### #
	# Imprime valores     #
	# ################### #
	
	# Imprime o valor de A
	add	$4, $0, $7
	addi	$2, $0, 1
	syscall
	
	# Imprime o valor de B
	add	$4, $0, $8
	addi	$2, $0, 1
	syscall
	
	# Imprime o valor de C
	add	$4, $0, $9
	addi	$2, $0, 1
	syscall
	
	nop
	