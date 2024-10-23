public class Cocinero extends Empleado {

    public Cocinero() {
        this.dni = "";
        this.nombre ="" ;
        this.categoria="" ;
        this.edad = 0;
        this.fechaNac="";
    }


	public Cocinero(String dni, String nombre, int edad, String fechaNac) {
        this.dni = dni;
        this.nombre = nombre;
        this.categoria= "Cocinero";
        this.edad = edad;
        this.fechaNac=fechaNac;
    }
}
