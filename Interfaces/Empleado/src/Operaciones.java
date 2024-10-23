import java.util.ArrayList;
import java.util.List;

public class Operaciones implements IOperaciones  {

    @Override
    public Empleado Agregar(Empleado empleado) {
        Empleado devEmpleado = new Empleado(
            empleado.getDni(), 
            empleado.getNombre(), 
            empleado.getEdad(), 
            empleado.getFechaNac(), 
            empleado.getCategoria()
        );
        return devEmpleado;
    }

    @Override
    public boolean Delete(Empleado empleado, String dni) {
        if (empleado.getDni().equals(dni)) return true;
        return false;
    }

    @Override
    public boolean Update(Empleado empleado, String dni) {
        if (empleado.getDni().equals(dni)) return true;
        return false;
    }

    @Override
    public List<Empleado> Read() {
        List<Empleado> listaEmpleados = new ArrayList<>();
        //SELECT * FROM Empleados;
        return listaEmpleados;
    }
}
