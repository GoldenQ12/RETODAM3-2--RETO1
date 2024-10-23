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
        this.categoria= categoria;
        this.edad = edad;
        this.fechaNac=fechaNac;
    }
    
    public Empleado() {
        this.dni = "";
        this.nombre ="" ;
        this.categoria="" ;
        this.edad = 0;
        this.fechaNac="";
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

	public String getDni() {
		return dni;
	}




	public void setDni(String dni) {
		this.dni = dni;
	}




	public String getNombre() {
		return nombre;
	}


	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getCategoria() {
		return categoria;
	}

	public void setCategoria(String categoria) {
		this.categoria = categoria;
	}

	public int getEdad() {
		return edad;
	}

	public void setEdad(int edad) {
		this.edad = edad;
	}

	public String getFechaNac() {
		return fechaNac;
	}

	public void setFechaNac(String fechaNac) {
		this.fechaNac = fechaNac;
	}

	public String toString() {
        return "DNI: " + dni + "\nNombre: " + nombre + "\nEdad: " + edad + "\nCategoria: " + categoria + "\nFecha Nacimiento"+ fechaNac;
    }
}