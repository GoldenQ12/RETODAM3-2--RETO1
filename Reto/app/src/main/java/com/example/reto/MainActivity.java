package com.example.reto;

import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    private String username,password;
    private String categoriaEmpleado;

    // Variable para controlar si ya se ha mostrado el diálogo
    private boolean dialogoMostrado = false;
    // Referencias a los botones
    private Button btnArticulos, btnEmpleados, btnPedidos;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Inicializar botones
        btnArticulos = findViewById(R.id.btarticulos);
        btnEmpleados = findViewById(R.id.btcamarero);
        btnPedidos = findViewById(R.id.btped);

        // Deshabilitamos inicialmente los botones
        btnArticulos.setEnabled(false);
        btnEmpleados.setEnabled(false);
        btnPedidos.setEnabled(false);

        // Mostrar el diálogo solo si no se ha mostrado previamente en esta sesión
        if (!dialogoMostrado) {
            mostrarDialogoInicioSesion();
            dialogoMostrado = true; // Marcar que ya se ha mostrado el diálogo
        }
    }

    public void articulos(View v) {
        Intent i = new Intent(this, Articulos.class);
        startActivity(i);
    }

    public void empleados(View v) {
        Intent i = new Intent(this, Empleados.class);
        startActivity(i);
    }

    public void pedidos(View v) {
        Intent i = new Intent(this, Pedidos.class);
        startActivity(i);
    }

    private void mostrarDialogoInicioSesion() {
        // Lógica del diálogo
        LayoutInflater inflater = getLayoutInflater();
        View dialogView = inflater.inflate(R.layout.popup, null);
        EditText etUsername = dialogView.findViewById(R.id.etUsername);
        EditText etPassword = dialogView.findViewById(R.id.etpass);

        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setView(dialogView)
                .setTitle("Iniciar Sesión")
                .setPositiveButton("Iniciar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        username = etUsername.getText().toString();
                        password = etPassword.getText().toString();
                        if (!username.isEmpty() && !password.isEmpty()) {
                            validarUsuarioYAsignarPermisos(username, password);
                        }else{
                            Toast.makeText(MainActivity.this, "Usuario no detectado. Reiniciando aplicación", Toast.LENGTH_SHORT).show();
                            Intent i = new Intent(MainActivity.this, Portada.class);
                            startActivity(i);
                        }
                    }
                })
                .setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        // Usar MainActivity.this para referenciar al contexto correcto
                        Intent i = new Intent(MainActivity.this, Portada.class);
                        startActivity(i);
                    }
                });

        builder.create().show();
    }

    private void validarUsuarioYAsignarPermisos(String username, String pass) {
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();

        // Consulta para obtener la categoría del empleado
        Cursor fila = bd.rawQuery("SELECT categoria FROM empleados WHERE nombre = ? AND password = ?", new String[]{username,pass});

        if (fila.moveToFirst()) {
            categoriaEmpleado = fila.getString(0); // Obtenemos la categoría del empleado
            Toast.makeText(MainActivity.this, "Inicio de sesión exitoso. Categoría: " + categoriaEmpleado, Toast.LENGTH_SHORT).show();

            // Habilitar botones según la categoría del empleado
            habilitarBotonesPorCategoria(categoriaEmpleado);

        } else {
            Toast.makeText(MainActivity.this, "Usuario sin credenciales. Reiniciando aplicación", Toast.LENGTH_SHORT).show();
            Intent i = new Intent(MainActivity.this, Portada.class);
            startActivity(i);
        }

        fila.close();
        bd.close();
    }

    private void habilitarBotonesPorCategoria(String categoria) {
        switch (categoria) {
            case "Gerente":
                // Un administrador puede acceder a todo
                btnArticulos.setEnabled(true);
                btnEmpleados.setEnabled(true);
                btnPedidos.setEnabled(true);
                break;

            case "Camarero":
                // El mesero solo puede acceder a los pedidos
                btnPedidos.setEnabled(true);
                break;

            default:
                // Si la categoría no es reconocida, no habilitamos ningún botón
                Toast.makeText(MainActivity.this, "No tienes permisos asignados.", Toast.LENGTH_SHORT).show();
                break;
        }
    }
}
