class Alumno:
    def __int__(self, nombre, nota):
        self.nombre = nombre
        self.nota = nota

    def __str__(self):
        return "El alumno {} saco {} en la materia".format(self.nombre, self.nota)
    def aprobado(self):
        if(self.nota >3 and self.nota<=5):
            print("Alumno Aprobado")
        else:
            print("Alumno reprobado")

alumno=Alumno()
alumno.__int__("Jose", 4.3)
alumno.aprobado()
print(alumno)
