# Victor Paiva Torres
# <vpaivatorres@gmail.com>

.text

main: 
	# Registrador	| Informação
	# ---------------------------
	# 6		| Ano
	# 7		| X
	# 8		| Y
	# 9		| a
	# 10		| b
	# 11		| c
	# 12		| d
	# 13		| e
	# 14		| Auxiliar
	# 15		| Auxiliar
	# 16		| Auxiliar
	# 17		| Auxiliar
	
	# Inicializa contador
	addi	$6, $0, 0
	
	j 	leitura

leitura: 
	# Ano
	addi 	$2, $0, 5
	syscall
	add 	$6, $0, $2
	
	j 	validacao
	
validacao:
	# Ano >= 1901
	addi	$14, $0, 1901
	blt	$6, $14, invalida
	# Ano <= 2099
	addi	$14, $0, 2099
	bgt	$6, $14, invalida
	
	j	formula
	
invalida:
	addi 	$4, $0, -1
	addi	$2, $0, 1
	syscall
	
	j	fim
	
formula:
	# X = 24
	addi	$7, $0, 24
	# Y = 24
	addi	$8, $0, 5
	# a = Ano % 19
	addi	$14, $0, 19
	div	$6, $14
	mfhi	$9
	# b = Ano % 4
	addi	$14, $0, 4
	div	$6, $14
	mfhi	$10
	# c = Ano % 7
	addi	$14, $0, 7
	div	$6, $14
	mfhi	$11
	# d = (19 * a + X) % 30
	addi 	$14, $0, 19
	mul	$15, $14, $9
	add	$14, $15, $7
	addi	$15, $0, 30
	div 	$14, $15
	mfhi	$12
	# e = (2 * b + 4 * c + 6 * d + Y) % 7
	addi	$14, $0, 2
	mul	$15, $14, $10
	addi	$14, $0, 4
	mul	$16, $14, $11
	addi	$14, $0, 6
	mul	$17, $14, $12
	add 	$14, $15, $16
	add	$13, $14, $0
	add	$14, $13, $17
	add	$13, $14, $8
	addi	$14, $0, 7
	div 	$13, $14
	mfhi	$13
	
	j	condicoes
	
condicoes:
	#  (d + e) > 9 então mês = abril
	add	$14, $12, $13
	addi	$15, $0, 9
	bgt	$14, $15, abril
	# senão, mês = março
	j	marco
	
abril:
	# dia =  (d + e - 9)
	addi	$4, $14, -9
	addi	$14, $0, 26
	beq	$4, $14, caso1
	addi	$14, $0, 25
	beq	$4, $14, caso2
	
	j	normal
	
normal:
	addi	$2, $0, 1
	syscall
	addi	$4, $0, '/'
	addi	$2, $0, 11
	syscall
	addi	$4, $0, 4
	addi	$2, $0, 1
	syscall
	
	j 	fim
	
caso1:
	# dia =  19
	addi	$4, $0, 19
	addi	$2, $0, 1
	syscall
	addi	$4, $0, '/'
	addi	$2, $0, 11
	syscall
	addi	$4, $0, 4
	addi	$2, $0, 1
	syscall
	
	j	fim
	
caso2:
	# d == 28
	addi	$14, $0, 28
	bne	$12, $14, normal
	# a > 10
	addi	$14, $0, 10
	ble	$9, $14, normal
	# dia = 18
	addi	$4, $0, 18
	addi	$2, $0, 1
	syscall
	addi	$4, $0, '/'
	addi	$2, $0, 11
	syscall
	addi	$4, $0, 4
	addi	$2, $0, 1
	syscall
	
	j	fim
	
marco:
	# dia = (d + e + 22)
	addi	$4, $14, 22
	addi	$2, $0, 1
	syscall
	addi	$4, $0, '/'
	addi	$2, $0, 11
	syscall
	addi	$4, $0, 3
	addi	$2, $0, 1
	syscall
	
	j 	fim
	
fim:
	nop
	