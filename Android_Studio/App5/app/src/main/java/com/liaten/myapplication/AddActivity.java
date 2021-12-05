package com.liaten.myapplication;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class AddActivity extends AppCompatActivity {
    EditText company_et, founder_et, product_et;
    Button add_button;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add);

        company_et = findViewById(R.id.company_edit_text);
        founder_et = findViewById(R.id.founder_edit_text);
        product_et = findViewById(R.id.product_edit_text);
        add_button = findViewById(R.id.add_button);
        add_button.setOnClickListener(add_listener);
    }
    private View.OnClickListener add_listener = view -> {
       if(!(company_et.getText().toString().trim().equals("") ||
               founder_et.getText().toString().trim().equals("") ||
               product_et.getText().toString().trim().equals("")
       ))
       {
           DatabaseHelper DB = new DatabaseHelper(AddActivity.this);
           DB.AddCompany(company_et.getText().toString().trim(),
                   founder_et.getText().toString().trim(),
                   product_et.getText().toString().trim());
       }
       else {
           Toast.makeText(AddActivity.this,"Не все поля заполнены", Toast.LENGTH_SHORT).show();
       }
    };
}
