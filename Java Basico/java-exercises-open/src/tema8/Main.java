package tema8;

public class Main {
    public static void main(String[] args) {
        Persona persona= new Persona();
        persona.setEdad(10);
        persona.setNombre("Jose");
        persona.setTelefono("571234567891");

        System.out.println("Nombre = " + persona.getNombre());
        System.out.println("Edad = " + persona.getEdad());
        System.out.println("Telefono = " + persona.getTelefono());
    }
}
