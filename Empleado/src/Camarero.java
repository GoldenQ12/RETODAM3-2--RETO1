public class Camarero extends Empleado {
    public Camarero(String dni, String nombre, int edad, String fechaNac, String categoria) {
        this.dni = dni;
        this.nombre = nombre;
        this.categoria= "Camarero";
        this.edad = edad;
        this.fechaNac=fechaNac;
    }
}