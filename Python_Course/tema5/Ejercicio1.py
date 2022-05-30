import math


def areaTriangulo(altura, base):
    return (base * altura) / 2


def areaCirculo(radio):
    return math.pi * (radio ** 2)


print(f"area del triangulo 10*7: {areaCirculo(10 * 7)}")

print(f"area del círculo r 6: {areaCirculo(6)}")
