
public interface IOperaciones {
	public boolean agregar (String dni, String nombre, int edad, String fechaNac, String categoria);
	public boolean delete(String dni, String nombre, int edad, String fechaNac, String categoria);
	public boolean ubdate(String dni, String nombre, int edad, String fechaNac, String categoria);
	public boolean read(String dni, String nombre, int edad, String fechaNac, String categoria);
}
