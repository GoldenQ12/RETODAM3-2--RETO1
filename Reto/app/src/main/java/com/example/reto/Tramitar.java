package com.example.reto;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class Tramitar extends AppCompatActivity {
    private ListView lvtramitar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tramitar);
        lvtramitar = findViewById(R.id.lvtramitar);
        // Recuperamos el ArrayList de la intención
        Intent intent = getIntent();
        ArrayList<String> selectedItems = intent.getStringArrayListExtra("selectedItems");

        // Comprobamos si el ArrayList no es nulo y tiene elementos
        if (selectedItems != null && !selectedItems.isEmpty()) {
            // Configuramos el adaptador para mostrar los datos en el ListView
            ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, selectedItems);
            lvtramitar.setAdapter(adapter);
        }
    }
    public void editar (View v) {
        Intent i = new Intent(this, Pedidos.class );
        startActivity(i);
    }
}