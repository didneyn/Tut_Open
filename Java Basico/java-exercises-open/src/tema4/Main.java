package tema4;

public class Main {

    public static void main(String[] args) {
        numeroIf(0);
        whileCicle(0);
        doWhileCicle(3);
        forCicle();
        switchSelect("otoño");
    }

    public static void numeroIf(int numeroIf){
        if ( numeroIf > 0 )
        {
            System.out.println("numero positivo");
        }
        else{
            if ( numeroIf == 0 ) {
                System.out.println("valor cero");
            }
            else {
                System.out.println("numero negativo");
            }
        }
    }
    public static void whileCicle (int cont){
        System.out.println("Ciclo While");
        while (cont <3){
            cont++;
            System.out.println("condicion while = " + cont);
        }
    }
    public static void doWhileCicle (int cont){
        System.out.println("Ciclo Do While");
        do {
            System.out.println("Entro al do while");
            cont++;
        } while(cont<3);
    }
    public static void forCicle(){
        System.out.println("Ciclo for");
        for (int i = 0; i < 3; i++) {
            System.out.println("for: "+i);
        }
    }
    public static void switchSelect (String ope){
        System.out.println("select switch");

        switch (ope){
            case "verano":{
                System.out.println("verano");
                break;
            }
            case "otoño":{
                System.out.println("otoño");
                break;
            }
            case "invierno":{
                System.out.println("invierno");
                break;
            }
            case "primavera":{
                System.out.println("primavera");
                break;
            }
            default: {
                System.out.println("Valor invalido");
            }
        }
    }
}


/*






}
*/