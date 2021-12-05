package com.liaten.myapplication;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    Button add_button;
    RecyclerView company_recycler_view;
    DatabaseHelper MyDB;
    ArrayList<String> id, company, founder, product;
    CustomAdapter customAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        add_button = findViewById(R.id.add_button);
        company_recycler_view = findViewById(R.id.company_recycler_view);
        MyDB = new DatabaseHelper(MainActivity.this);
        id = new ArrayList<>();
        company = new ArrayList<>();
        founder = new ArrayList<>();
        product = new ArrayList<>();
        StoreDataInArrays();
        add_button.setOnClickListener(add_button_listener);
        customAdapter = new CustomAdapter(MainActivity.this,this, id, company, founder, product);
        company_recycler_view.setAdapter(customAdapter);
        company_recycler_view.setLayoutManager(new LinearLayoutManager(MainActivity.this));
    }
    private View.OnClickListener add_button_listener = view -> {
        Intent intent = new Intent(MainActivity.this, AddActivity.class);
        startActivity(intent);
    };

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data){
        super.onActivityResult(requestCode,resultCode,data);
        if(requestCode == 1){
            recreate();
        }
    }

    void StoreDataInArrays(){
        Cursor cursor = MyDB.ReadAllData();
        if(cursor.getCount() == 0){
            Toast.makeText(this,"No data", Toast.LENGTH_SHORT).show();
        } else {
            while (cursor.moveToNext()){
                id.add(cursor.getString(0));
                company.add(cursor.getString(1));
                founder.add(cursor.getString(2));
                product.add(cursor.getString(3));
            }
        }
    }
}