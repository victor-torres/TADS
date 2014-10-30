.text
main:
	addi	$2, $0, 5		# Código para ler número inteiro
	syscall				# Realiza chamada de sistema
	add	$9, $0, $2		# Move o resultado para o registrador 9
	
negativo:
	beq 	$9, $0, nulo		# Verifica se o número é nulo; se for, pula.
	srl	$7, $9, 31		# Desloca o número 31 bits a direita
	beq	$7, $0, positivo	# Verifica se o número é positivo; se for, pula.
	addi	$8, $0, -1		# Se não é nulo nem positivo, o número é negativo
	beq	$0, $0, fim		# Pula para o fim do programa
	
nulo:
	addi	$8, $0, 0		# O número é nulo
	beq 	$0, $0, fim		# Pula para o fim do programa
	
positivo:
	addi 	$8, $0, 1		# O número é positivo
	beq 	$0, $0, fim		# Pula para o fim do programa
	
fim:
	add	$4, $0, $8		# Move o resultado para o registrador 4
	addi	$2, $0, 1		# Código para imprimir número inteiro
	syscall				# Realiza chamada de sistema
	nop
