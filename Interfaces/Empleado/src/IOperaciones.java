import java.util.List;

public interface IOperaciones {
	public Empleado Agregar (Empleado empleado);
	public boolean Delete(Empleado empleado, String dni);
	public boolean Update(Empleado empleado, String dni);
	public List<Empleado> Read();
}
