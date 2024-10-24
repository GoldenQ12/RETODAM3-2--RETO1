package com.example.reto;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class AdminSQLiteOpenHelper extends SQLiteOpenHelper {
    public AdminSQLiteOpenHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        //para que funcione cambiar nueva base de datos para crear nueva tabla
        db.execSQL("create table articulos(codart int primary key,nombre text,precio real, cantidad int, link_imagen text)");
        db.execSQL("create table empleados (codemp int primary key, nombre text, fechanac text, categoria text, edad int, password text)");
        db.execSQL("create table pedidos(codped int primary key,fecha text, disponibilidad int)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }
}
