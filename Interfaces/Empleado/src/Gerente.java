public class Gerente extends Empleado {

    public Gerente() {
        this.setDni("");
        this.setNombre("");   
        this.setCategoria("");
        this.setEdad(0);
        this.setFechaNac("");
    } 

	public Gerente(String dni, String nombre, int edad, String fechaNac) {
        this.setDni(dni);
        this.setNombre(nombre);   
        this.setCategoria("Gerente");
        this.setEdad(edad);
        this.setFechaNac(fechaNac);
    }
}