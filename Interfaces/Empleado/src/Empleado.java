// Clase base Empleado

import java.util.Objects;

public class Empleado {
	private String _dni;
	private String _nombre;
	private String _categoria;
    private int _edad;
    private String _fechaNac;

    public Empleado(String dni, String nombre, int edad, String fechaNac, String categoria) {
        this._dni = dni;
        this._nombre = nombre;
        this._edad = edad;
        this._fechaNac=fechaNac;
		this._categoria= categoria;
    }
    
    public Empleado() {
        this._dni = "";
        this._nombre ="" ;
        this._edad = 0;
        this._fechaNac="";
		this._categoria="" ;
    }
    
    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;  
        }
        if (obj == null || getClass() != obj.getClass()) {
            return false;  
        }
        Empleado empleado = (Empleado) obj;  
        return Objects.equals(_dni, empleado._dni);  
    }

	public String getDni() {return _dni;} 	
	public String getNombre() {return _nombre;}	
	public int getEdad() {return _edad;}		
	public String getFechaNac() {return _fechaNac;}	
	public String getCategoria() {return _categoria;}	
	

	public void setDni(String dni) {this._dni = dni;}
	public void setNombre(String nombre) {this._nombre = nombre;}
	public void setEdad(int edad) {this._edad = edad;}
	public void setFechaNac(String fechaNac) {this._fechaNac = fechaNac;}
	public void setCategoria(String categoria) {this._categoria = categoria;}
	
	public String toString() {
        return "DNI: " + _dni + 
		"\nNombre: " + _nombre + 
		"\nEdad: " + _edad + 
		"\nFecha Nacimiento: " + _fechaNac + 
		"\nCategoria: "+ _categoria ;
    }
}