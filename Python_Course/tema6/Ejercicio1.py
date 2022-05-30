class Vehiculo:
    color = None
    ruedas = None
    puertas = None
    def __init__(self, color, ruedas, puertas):
        self.color = color
        self.ruedas = ruedas
        self.puertas = puertas

    def __str__(self):
        return "Color {}, {} ruedas".format(self.color, self.ruedas, self.puertas)

class Coche(Vehiculo):
    color = None
    ruedas = None
    puertas = None
    velocidad = None
    cilindrada = None

    def __init__(self, color, ruedas, puertas, velocidad, cilindrada):
        self.color = color
        self.ruedas = ruedas
        self.puertas = puertas
        self.velocidad = velocidad
        self.cilindrada = cilindrada

    def __str__(self):
        return "color {}, {} km/h, {} ruedas, {} puertas, {} cc".format( self.color, self.velocidad, self.ruedas, self.puertas, self.cilindrada )

coche = Coche("rojo", 4, 4, 120, 100)
print(coche)
