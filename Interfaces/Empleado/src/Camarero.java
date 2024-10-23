public class Camarero extends Empleado {

    public Camarero() {
        this.setDni("");
        this.setNombre("");
        this.setCategoria("");
        this.setEdad(0);
        this.setFechaNac("");
    }

    public Camarero(String dni, String nombre, int edad, String fechaNac) {
        this.setDni(dni);
        this.setNombre(nombre);
        this.setCategoria("Camarero");
        this.setEdad(edad);
        this.setFechaNac(fechaNac);
    }
}