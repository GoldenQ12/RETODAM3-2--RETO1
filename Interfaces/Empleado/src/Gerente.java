public class Gerente extends Empleado {

    public Gerente() {
        this.dni = "";
        this.nombre ="" ;
        this.categoria="" ;
        this.edad = 0;
        this.fechaNac="";
    } 

	public Gerente(String dni, String nombre, int edad, String fechaNac) {
        this.dni = dni;
        this.nombre = nombre;
        this.categoria= "Gerente";
        this.edad = edad;
        this.fechaNac=fechaNac;
    }
}