def bisiesto (numero):
	if numero % 4 == 0 and (numero % 100 != 0 or numero % 400 == 0):
		return "Es bisiesto"
	else:
		return "No es bisiesto"
numero = int(input("Ingrese el año "))
print(f"El año {numero}  {bisiesto(numero)}")