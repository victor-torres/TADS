.text 

main:
	# Realiza a leitura da primeira nota (0 .. 100)
	addi	$2, $0, 5
	syscall
	add	$8, $0, $2
	# Realiza a leitura da segunda nota (0 .. 100)
	addi	$2, $0, 5
	syscall
	add	$9, $0, $2
	# Soma as notas
	add 	$10, $8, $9
	# Verifica se a soma das notas é maior ou igual a 120 (média 60)
	addi 	$11, $0, 120
	bge 	$10, $11, aprovado
	j	reprovado
	
aprovado:
	addi	$4, $0, 1
	j	fim
	
reprovado:
	addi	$4, $0, 0
	j	fim
	
fim:
	addi	$2, $0, 1
	syscall
	nop
	