public class Camarero extends Empleado {

    public Camarero() {
        this.dni = "";
        this.nombre ="" ;
        this.categoria="" ;
        this.edad = 0;
        this.fechaNac="";
    }

    public Camarero(String dni, String nombre, int edad, String fechaNac) {
        this.dni = dni;
        this.nombre = nombre;
        this.categoria= "Camarero";
        this.edad = edad;
        this.fechaNac=fechaNac;
    }
}