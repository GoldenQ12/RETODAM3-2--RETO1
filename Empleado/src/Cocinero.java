public class Cocinero extends Empleado {
	public Cocinero(String dni, String nombre, int edad, String fechaNac, String categoria) {
        this.dni = dni;
        this.nombre = nombre;
        this.categoria= "Cocinero";
        this.edad = edad;
        this.fechaNac=fechaNac;
    }
}
