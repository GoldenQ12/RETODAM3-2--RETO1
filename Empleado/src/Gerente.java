public class Gerente extends Empleado {
	public Gerente(String dni, String nombre, int edad, String fechaNac, String categoria) {
        this.dni = dni;
        this.nombre = nombre;
        this.categoria= "Gerente";
        this.edad = edad;
        this.fechaNac=fechaNac;
    }
}