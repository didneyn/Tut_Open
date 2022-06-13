import time


def main():
    hora  = time.strftime('%H')
    minutos = time.strftime('%M')
    print("la hora es: ", hora, ":", minutos)
    if int(hora) >= 19:
        print("Es hora de salir.")
    else:
        print(
            "Falta {} horas con {} minutos para la nueva hora de salida".format((18 - int(hora)), (59 - int(minutos))))


if __name__ == "__main__":
    main()
