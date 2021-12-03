package com.liaten.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;

public class MainActivity extends AppCompatActivity {

    Button add_button;
    RecyclerView company_recycler_view;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        add_button = findViewById(R.id.add_button);
        company_recycler_view = findViewById(R.id.company_recycler_view);

        add_button.setOnClickListener(add_button_listener);
    }
    private View.OnClickListener add_button_listener = view -> {
        Intent intent = new Intent(MainActivity.this, AddActivity.class);
        startActivity(intent);
    };
}