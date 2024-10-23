public class Cocinero extends Empleado {

    public Cocinero() {
        this.setDni("");
        this.setNombre("");
        this.setCategoria("");
        this.setEdad(0);
        this.setFechaNac("");
    }


	public Cocinero(String dni, String nombre, int edad, String fechaNac) {
        this.setDni(dni);
        this.setNombre(nombre);
        this.setCategoria("Cocinero");
        this.setEdad(edad);
        this.setFechaNac(fechaNac);
    }
}
