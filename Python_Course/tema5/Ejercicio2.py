def primo(num):
    cont =0
    for n in range(2, num):
        if num % n == 0:
            cont+=1
            break

    if cont==0:
        return "es primo"
    else:
        return "no es primo"

numero = int(input("Ingrese el numero "))
print(f"El numero {numero} {primo(numero)}")