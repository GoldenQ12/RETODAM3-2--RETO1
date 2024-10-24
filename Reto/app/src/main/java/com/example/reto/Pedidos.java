package com.example.reto;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;
import java.util.ArrayList;

public class Pedidos extends AppCompatActivity {
    private ListView lvtra;
    private EditText etart;
    // ArrayList donde almacenaremos los ítems seleccionados
    ArrayList<String> selectedItems = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pedidos);
        lvtra = findViewById(R.id.lvtra);
        etart = findViewById(R.id.etart);

        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        Cursor fila = bd.rawQuery("select * from articulos", null);
        ArrayList<String> datos = new ArrayList<>();
        if (fila.moveToFirst()) {
            do {
                String codart = fila.getString(0);
                String nombre = fila.getString(1);
                String precio = fila.getString(2);
                String cantidad = fila.getString(3);
                datos.add("Código: "+codart +" | Nombre: "+ nombre +" | Precio: "+ precio +"€ | Cantidad: "+ cantidad);
            } while (fila.moveToNext());
            ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, datos);
            lvtra.setAdapter(adapter);
        }

        lvtra.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView adapterView, View view, int position, long id) {
                // Obtenemos el ítem clicado basándonos en la posición
                String selectedItem = datos.get(position);

                // Mostramos el ítem seleccionado con un Toast
                Toast.makeText(Pedidos.this, "Artículo seleccionado: " + selectedItem, Toast.LENGTH_SHORT).show();

                // Almacenamos el ítem seleccionado en el ArrayList
                selectedItems.add(selectedItem);

                // Suponemos que 'selectedItem' contiene el código del artículo al inicio
                String codart = obtenerCodigoDeArticulo(selectedItem);  // Función para extraer el código del artículo
                if (codart == null) {
                    Toast.makeText(Pedidos.this, "Error al obtener el código del artículo.", Toast.LENGTH_SHORT).show();
                    return;
                }

                //Reducir cantidad
                AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(Pedidos.this, "cafeteria", null, 1);
                SQLiteDatabase bd = admin.getWritableDatabase();
                AdminSQLiteOpenHelper2 admin2 = new AdminSQLiteOpenHelper2(Pedidos.this, "cafeteria2", null, 1);
                SQLiteDatabase bd2 = admin2.getWritableDatabase();
                // Primero obtenemos la cantidad actual del artículo seleccionado
                Cursor fila = bd.rawQuery("SELECT cantidad FROM articulos WHERE codart = ?", new String[]{codart});
                Cursor fila2 = bd2.rawQuery("SELECT cantidad FROM articuloslocal WHERE codart = ?", new String[]{codart});
                if (fila.moveToFirst()) {
                    int cantidadActual = fila.getInt(0);  // Obtenemos la cantidad actual
                    if (cantidadActual > 0) {
                        // Reducimos la cantidad en 1
                        ContentValues registro = new ContentValues();
                        registro.put("cantidad", cantidadActual - 1);

                        // Actualizamos la base de datos
                        int cant = bd.update("articulos", registro, "codart=?", new String[]{codart});

                        if (cant > 0) {} else {
                            Toast.makeText(Pedidos.this, "Error al actualizar la cantidad.", Toast.LENGTH_SHORT).show();
                        }
                    } else {
                        Toast.makeText(Pedidos.this, "No hay suficiente cantidad en stock.", Toast.LENGTH_SHORT).show();
                    }
                } else {
                    Toast.makeText(Pedidos.this, "Artículo no encontrado.", Toast.LENGTH_SHORT).show();
                }
                if (fila2.moveToFirst()) {
                    int cantidadActual2 = fila2.getInt(0);// Obtenemos la cantidad actual
                    if (cantidadActual2 >= 0) {
                        // Reducimos la cantidad en 1
                        ContentValues registro2 = new ContentValues();
                        registro2.put("cantidad", cantidadActual2 + 1);

                        // Actualizamos la base de datos
                        int cant = bd2.update("articuloslocal", registro2, "codart=?", new String[]{codart});

                        if (cant > 0) {} else {
                            Toast.makeText(Pedidos.this, "Error al actualizar la cantidad.", Toast.LENGTH_SHORT).show();
                        }
                    } else {
                        Toast.makeText(Pedidos.this, "No hay suficiente cantidad en stock.", Toast.LENGTH_SHORT).show();
                    }
                } else {
                    Toast.makeText(Pedidos.this, "Artículo no encontrado.", Toast.LENGTH_SHORT).show();
                }

                fila.close();
                fila2.close();
                bd.close();
                bd2.close();

                // Para depurar: mostramos en consola los ítems seleccionados
                System.out.println("Ítems seleccionados: " + selectedItems);
            }
        });
    }
    private String obtenerCodigoDeArticulo(String selectedItem) {
        // Dividimos el string usando " | " como separador
        String[] partes = selectedItem.split("\\|");

        // Verificamos que la primera parte contiene "Código: X"
        if (partes.length > 0) {
            // La primera parte es algo como "Código: 123", por lo que extraemos el valor después de "Código: "
            String codigo = partes[0].trim().replace("Código: ", "").trim();
            return codigo;  // Devolvemos el código del artículo (por ejemplo "123")
        }

        return null;  // Si no se puede obtener el código, devolvemos null
    }
    public void tramitar (View v) {
        Intent i = new Intent(this, Tramitar.class );
        // Pasamos el ArrayList como un "extra" al Intent
        i.putStringArrayListExtra("selectedItems", selectedItems);
        startActivity(i);
    }
    public void consulta(View v) {
        if (!etart.getText().toString().equals("")) {
            AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
            SQLiteDatabase bd = admin.getWritableDatabase();
            String nom = etart.getText().toString();
            Cursor fila = bd.rawQuery("select * from articulos where nombre='" + nom+"'", null);
            ArrayList<String> datos = new ArrayList<>();
            if (fila.moveToFirst()) {
                do {
                    String codart = fila.getString(0);
                    String nombre = fila.getString(1);
                    String precio = fila.getString(2);
                    String cantidad = fila.getString(3);
                    datos.add("Código: "+codart +" | Nombre: "+ nombre +" | Precio: "+ precio +"€ | Cantidad: "+ cantidad);
                } while (fila.moveToNext());
                ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,android.R.layout.simple_list_item_1, datos);
                lvtra.setAdapter(adapter);
            } else
                Toast.makeText(this, "No existe un articulo con dicho nombre",
                        Toast.LENGTH_SHORT).show();
            bd.close();
        }
        else{
            Toast.makeText(this, "Introduzca el codigo", Toast.LENGTH_SHORT).show();
        }
    }
    public void volver (View v) {
        Intent i = new Intent(this, MainActivity.class );
        startActivity(i);
    }
}