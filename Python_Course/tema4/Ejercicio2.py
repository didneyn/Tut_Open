inicio = int(input("numero inicial"))
final = int(input("numero final"))
impares = []
while inicio<final:
    if( inicio % 2 != 0 ):
        impares.append(inicio)
    inicio+=1
print(impares)