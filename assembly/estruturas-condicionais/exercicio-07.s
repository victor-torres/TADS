.text 

main:
	# Realiza a leitura número
	addi	$2, $0, 5
	syscall
	add	$8, $0, $2
	# Desloca o número 31 bits a esquerda
	sll 	$9, $8, 31
	# Desloca o número 31 bits a direita
	srl 	$4, $9, 31
	
fim:
	# Imprime o resultado na tela
	addi	$2, $0, 1
	syscall
	nop
	