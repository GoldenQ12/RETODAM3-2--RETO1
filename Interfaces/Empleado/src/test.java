public class test {
    public static void main(String[] args) {
        // Create instances of different employee types
        Empleado empleado = new Empleado("12345678A", "Juan Pérez", 30, "1993-05-15", "General");
        Camarero camarero = new Camarero("23456789B", "María García", 25, "1998-10-20");
        Cocinero cocinero = new Cocinero("34567890C", "Pedro López", 35, "1988-03-08");
        Gerente gerente = new Gerente("45678901D", "Ana Martínez", 40, "1983-12-01");

        // Print information about each employee
        System.out.println("Empleado general:");
        System.out.println(empleado.toString());
        System.out.println("\nCamarero:");
        System.out.println(camarero.toString());
        System.out.println("\nCocinero:");
        System.out.println(cocinero.toString());
        System.out.println("\nGerente:");
        System.out.println(gerente.toString());

        // Demonstrate the use of some methods
        empleado.setEdad(31);
        camarero.setNombre("María Rodríguez");

        System.out.println("\nAfter updates:");
        System.out.println("Empleado general edad: " + empleado.getEdad());
        System.out.println("Camarero nombre: " + camarero.getNombre());

        // Demonstrate the equals method
        Empleado empleadoCopy = new Empleado("12345678A", "Juan Pérez", 31, "1993-05-15", "General");
        System.out.println("\nEmpleado equals empleadoCopy: " + empleado.equals(empleadoCopy));
        System.out.println("Empleado equals camarero: " + empleado.equals(camarero));
    }
}
