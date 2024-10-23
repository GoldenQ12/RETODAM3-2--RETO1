// Clase base Empleado

import java.util.Objects;

public class Empleado {
	String dni;
	String nombre;
	String categoria;
    int edad;
    String fechaNac;

    public Empleado(String dni, String nombre, int edad, String fechaNac, String categoria) {
        this.dni = dni;
        this.nombre = nombre;
        this.edad = edad;
        this.fechaNac=fechaNac;
		this.categoria= categoria;
    }
    
    public Empleado() {
        this.dni = "";
        this.nombre ="" ;
        this.edad = 0;
        this.fechaNac="";
		this.categoria="" ;
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
        return Objects.equals(dni, empleado.dni);  
    }

	public String getDni() {return dni;} 	
	public String getNombre() {return nombre;}	
	public int getEdad() {return edad;}		
	public String getFechaNac() {return fechaNac;}	
	public String getCategoria() {return categoria;}	
	
	public void setNombre(String nombre) {this.nombre = nombre;}
	public void setDni(String dni) {this.dni = dni;}
	public void setEdad(int edad) {this.edad = edad;}
	public void setFechaNac(String fechaNac) {this.fechaNac = fechaNac;}
	public void setCategoria(String categoria) {this.categoria = categoria;}
	
	
	

	public String toString() {
        return "DNI: " + dni + 
		"\nNombre: " + nombre + 
		"\nEdad: " + edad + 
		"\nCFecha Nacimiento: " + fechaNac + 
		"\nFCategoria"+ categoria ;
    }
}