package tema9;

public class Main {
    public static void main(String[] args) {
        Cliente cliente = new Cliente();
        cliente.setCredito(100000);
        cliente.setEdad(15);
        cliente.setNombre("Jose");
        cliente.setTelefono("3216549874");

        System.out.println("Nombre = " + cliente.getNombre());
        System.out.println("Edad = " + cliente.getEdad());
        System.out.println("Telefono = " + cliente.getTelefono());
        System.out.println("Credito = " + cliente.getCredito());



        Trabajador trabajador = new Trabajador();
        trabajador.setSalario(456789123);
        trabajador.setEdad(25);
        trabajador.setNombre("pepe");
        trabajador.setTelefono("3216549874");

        System.out.println("Nombre = " + trabajador.getNombre());
        System.out.println("Edad = " + trabajador.getEdad());
        System.out.println("Telefono = " + trabajador.getTelefono());
        System.out.println("Salario = " + trabajador.getSalario());
    }
}
