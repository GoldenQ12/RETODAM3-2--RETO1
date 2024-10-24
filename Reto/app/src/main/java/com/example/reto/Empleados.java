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

public class Empleados extends AppCompatActivity {
    private EditText etcod,etnom,etfec,etcat,etedad,etpass;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_empleados);

        etcod=findViewById(R.id.etcod);
        etnom=findViewById(R.id.etnom);
        etfec=findViewById(R.id.etfec);
        etcat=findViewById(R.id.etcat);
        etedad=findViewById(R.id.etedad);
        etpass=findViewById(R.id.etpass);
    }
    public void alta(View v) {
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String cod = etcod.getText().toString();
        String nom = etnom.getText().toString();
        String fecha = etfec.getText().toString();
        String cat = etcat.getText().toString();
        String edad = etedad.getText().toString();
        String pass = etpass.getText().toString();
        ContentValues registro = new ContentValues();
        registro.put("codemp", cod);
        registro.put("nombre", nom);
        registro.put("fechanac", fecha);
        registro.put("categoria", cat);
        registro.put("edad", edad);
        registro.put("password", pass);
        bd.insert("empleados", null, registro);
        bd.close();
        etcod.setText("");
        etnom.setText("");
        etfec.setText("");
        etcat.setText("");
        etedad.setText("");
        etpass.setText("");
        Toast.makeText(this, "Se cargaron los datos del empleado"+cod, Toast.LENGTH_SHORT).show();
    }
    public void baja(View v) {
        try {
            if (!etcod.getText().toString().equals("")) {
                AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
                SQLiteDatabase bd = admin.getWritableDatabase();
                String cod = etcod.getText().toString();
                int cantidad = bd.delete("empleados", "codemp=" + cod, null);
                bd.close();
                etcod.setText("");
                etnom.setText("");
                etfec.setText("");
                etcat.setText("");
                etedad.setText("");
                etpass.setText("");
                if (cantidad == 1)
                    Toast.makeText(this, "Se borró el empleado con dicho código", Toast.LENGTH_SHORT).show();
                else
                    Toast.makeText(this, "No existe un empleado con dicho código", Toast.LENGTH_SHORT).show();
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
            Cursor fila = bd.rawQuery("select nombre,fechanac,categoria,edad,password from empleados where codemp=" + cod, null);
            if (fila.moveToFirst()) {
                etnom.setText(fila.getString(0));
                etfec.setText(fila.getString(1));
                etcat.setText(fila.getString(2));
                etedad.setText(fila.getString(3));
                etpass.setText(fila.getString(4));
            } else
                Toast.makeText(this, "No existe un empleado con dicho código",
                        Toast.LENGTH_SHORT).show();
            bd.close();
        }
        else{
            Toast.makeText(this, "Introduzca el codigo", Toast.LENGTH_SHORT).show();
        }
    }

    public void modificacion(View v) {
        try{
            if (!etcod.getText().toString().equals("")) {
                AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "cafeteria", null, 1);
                SQLiteDatabase bd = admin.getWritableDatabase();
                String cod = etcod.getText().toString();
                String nombre = etnom.getText().toString();
                String fec = etfec.getText().toString();
                String cat = etcat.getText().toString();
                String edad = etedad.getText().toString();
                String pass = etpass.getText().toString();
                ContentValues registro = new ContentValues();
                registro.put("codemp", cod);
                registro.put("nombre", nombre);
                registro.put("fechanac", fec);
                registro.put("categoria", cat);
                registro.put("edad", edad);
                registro.put("password", pass);
                int cant = bd.update("empleados", registro, "codemp=" + cod, null);
                bd.close();
                if (cant == 1)
                    Toast.makeText(this, "Se modificaron los datos", Toast.LENGTH_SHORT).show();
                else
                    Toast.makeText(this, "No existe un empleado con el código ingresado", Toast.LENGTH_SHORT).show();
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