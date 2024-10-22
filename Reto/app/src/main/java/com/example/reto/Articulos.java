package com.example.reto;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class Articulos extends AppCompatActivity {
    private EditText etcod,etnom,etprecio,etcant;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_articulos);

        etcod=findViewById(R.id.etcod);
        etnom=findViewById(R.id.etnom);
        etprecio=findViewById(R.id.etprecio);
        etcant=findViewById(R.id.etcant);
    }
    public void alta(View v) {
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String cod = etcod.getText().toString();
        String nom = etnom.getText().toString();
        String precio = etprecio.getText().toString();
        String cant = etcant.getText().toString();
        ContentValues registro = new ContentValues();
        registro.put("codart", cod);
        registro.put("nombre", nom);
        registro.put("precio", precio);
        registro.put("cantidad", cant);
        bd.insert("articulos", null, registro);
        bd.close();
        etcod.setText("");
        etnom.setText("");
        etprecio.setText("");
        etcant.setText("");
        Toast.makeText(this, "Se cargaron los datos del artículo", Toast.LENGTH_SHORT).show();
    }
    public void baja(View v) {
        try {
            if (!etcod.getText().toString().equals("")) {
                AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
                SQLiteDatabase bd = admin.getWritableDatabase();
                String cod = etcod.getText().toString();
                int cantidad = bd.delete("articulos", "codart=" + cod, null);
                bd.close();
                etcod.setText("");
                etnom.setText("");
                etprecio.setText("");
                etcant.setText("");
                if (cantidad == 1)
                    Toast.makeText(this, "Se borró el artículo con dicho código", Toast.LENGTH_SHORT).show();
                else
                    Toast.makeText(this, "No existe un artículo con dicho código", Toast.LENGTH_SHORT).show();
            }else{
                Toast.makeText(this, "Introduzca el codigo", Toast.LENGTH_SHORT).show();
            }
        }catch(Exception e) {
            Toast.makeText(this, "Error inseperado: " + e.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }
    public void consulta(View v) {
        if (!etcod.getText().toString().equals("")) {
            AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
            SQLiteDatabase bd = admin.getWritableDatabase();
            String cod = etcod.getText().toString();
            Cursor fila = bd.rawQuery(
                    "select nombre,precio,cantidad from articulos where codart=" + cod, null);
            if (fila.moveToFirst()) {
                etnom.setText(fila.getString(0));
                etprecio.setText(fila.getString(1));
                etcant.setText(fila.getString(2));
            } else
                Toast.makeText(this, "No existe una persona con dicho código",
                        Toast.LENGTH_SHORT).show();
            bd.close();
        }
        else{
            Toast.makeText(this, "Introduzca el codigo",
                    Toast.LENGTH_SHORT).show();
        }
    }

    public void modificacion(View v) {
        try{
            if (!etcod.getText().toString().equals("")) {
                AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
                SQLiteDatabase bd = admin.getWritableDatabase();
                String cod = etcod.getText().toString();
                String nombre = etnom.getText().toString();
                String pre = etprecio.getText().toString();
                String cantidad = etcant.getText().toString();
                ContentValues registro = new ContentValues();
                registro.put("codart", cod);
                registro.put("nombre", nombre);
                registro.put("precio", pre);
                registro.put("cantidad", cantidad);
                int cant = bd.update("articulos", registro, "codart=" + cod, null);
                bd.close();
                if (cant == 1)
                    Toast.makeText(this, "Se modificaron los datos", Toast.LENGTH_SHORT).show();
                else
                    Toast.makeText(this, "No existe un articulo con el código ingresado", Toast.LENGTH_SHORT).show();
            }else{
                Toast.makeText(this, "Introduzca el codigo", Toast.LENGTH_SHORT).show();
            }
        }catch(Exception e){
            Toast.makeText(this, "Error inesperado "+ e.getMessage(),
                    Toast.LENGTH_SHORT).show();
        }
    }
    public void volver (View v) {
        Intent i = new Intent(this, MainActivity.class );
        startActivity(i);
    }
}