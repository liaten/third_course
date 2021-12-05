package com.liaten.app51;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

class Company{
    private String CompanyName,Founder,Product;
    public Company(String Company_Add, String Founder_Add, String Product_Add){
        this.CompanyName = Company_Add;
        this.Founder = Founder_Add;
        this.Product = Product_Add;
    }
    public String Get_Company_Name(){
        return this.CompanyName;
    }

    public void SetCompany_Name(String New_Company_Name){
        this.CompanyName = New_Company_Name;
    }

    public String Get_Founder(){
        return this.Founder;
    }

    public void Set_Founder(String New_Founder){
        this.Founder = New_Founder;
    }

    public String Get_Product(){
        return this.Product;
    }

    public void Set_Product(String New_Product){
        this.Product = New_Product;
    }

}

public class MainActivity extends AppCompatActivity {

    ListView CompanyLV;
    List list = new ArrayList();
    ArrayList<Company> company_list = new ArrayList<>();
    TextView head_text_view;
    Button add_button;
    ArrayAdapter adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        CompanyLV = findViewById(R.id.listview_company);
        add_button = findViewById(R.id.add_button);
        add_button.setOnClickListener(add_listener);

        Company Meta = new Company("Meta", "Jeff Bezos", "Amazon Marketplace");
        company_list.add(Meta);

        for (int i = 0; i < company_list.size(); i++)
        {
            list.add
                    (
                            company_list.get(i).Get_Company_Name() +
                                    "\n" + company_list.get(i).Get_Founder() +
                                    " | " + company_list.get(i).Get_Product()
                    );
        }

        adapter = new ArrayAdapter(MainActivity.this, android.R.layout.simple_list_item_1,list);
        CompanyLV.setAdapter(adapter);
    }

    private final View.OnClickListener add_listener = view -> {
        Intent addIntent = new Intent("android.intent.action.ChangeAddActivity");
        addIntent.putExtra("head",0);
        startActivityForResult(addIntent,1);
    };
}