package com.example.reto;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void articulos (View v) {
        Intent i = new Intent(this, Articulos.class );
        startActivity(i);
    }
    public void empleados (View v) {
        Intent i = new Intent(this, Empleados.class );
        startActivity(i);
    }
    public void pedidos (View v) {
        Intent i = new Intent(this, Pedidos.class );
        startActivity(i);
    }
}