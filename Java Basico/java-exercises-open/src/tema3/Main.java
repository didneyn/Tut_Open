package tema3;

public class Main {

    public static void main(String[] args) {
        suma(1,2,3);

        Coche coche = new Coche();
        coche.addPuerta();
        coche.addPuerta();
        System.out.println("coche.puertas = " + coche.puertas);
    }

    public static void suma (int a, int b, int c){
        int resultado;
        resultado= a+b+c;
        System.out.println("resultado = " + resultado);
    }

    public static class Coche {
        int puertas = 0;

        public void addPuerta() {
            puertas++;
        }
    }

}
