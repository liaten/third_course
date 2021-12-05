package com.liaten.myapplication;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

public class UpdateActivity extends AppCompatActivity {

    EditText company_et, founder_et, product_et;
    Button update_button;
    String id_s, company_s, founder_s, product_s;

    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update);

        company_et = findViewById(R.id.company_edit_text_update);
        founder_et = findViewById(R.id.founder_edit_text_update);
        product_et = findViewById(R.id.product_edit_text_update);
        update_button = findViewById(R.id.update_button);
        updateIntentData();
        update_button.setOnClickListener(view -> {
            DatabaseHelper myDB = new DatabaseHelper(UpdateActivity.this);
            myDB.updateData(id_s,company_s,founder_s,product_s);
        });
    }

    void updateIntentData(){
        if
        (
                getIntent().hasExtra("id") &&
                        getIntent().hasExtra("company") &&
                        getIntent().hasExtra("founder") &&
                        getIntent().hasExtra("product")
        ){
            // getting data from intent
            id_s = getIntent().getStringExtra("id");
            company_s = getIntent().getStringExtra("company");
            founder_s = getIntent().getStringExtra("founder");
            product_s = getIntent().getStringExtra("product");
            // setting intent data
            company_et.setText(company_s);
            founder_et.setText(founder_s);
            product_et.setText(product_s);
        } else {
            Toast.makeText(this,"No data", Toast.LENGTH_SHORT).show();
        }
    }
}
