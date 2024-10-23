import java.util.List;

public interface IOperaciones {
	public boolean agregar (Empleado empleado);
	public boolean delete(Empleado empleado, String dni);
	public boolean ubdate(Empleado empleado, String dni);
	public List<Empleado> read();
}
