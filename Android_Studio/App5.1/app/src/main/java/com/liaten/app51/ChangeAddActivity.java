package com.liaten.app51;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.Parcel;
import android.os.Parcelable;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

class PCompany implements Parcelable {
    private String CompanyName,Founder,Product;
    public PCompany(String Company_Name_Add, String Founder_Add, String Product_Add){
        this.CompanyName = Company_Name_Add;
        this.Founder = Founder_Add;
        this.Product = Product_Add;
    }

    protected PCompany(Parcel in) {
        CompanyName = in.readString();
        Founder = in.readString();
        Product = in.readString();
    }

    public static final Creator<PCompany> CREATOR = new Creator<PCompany>() {
        @Override
        public PCompany createFromParcel(Parcel in) {
            return new PCompany(in);
        }

        @Override
        public PCompany[] newArray(int size) {
            return new PCompany[size];
        }
    };

    public String Get_Company_Name(){
        return this.CompanyName;
    }

    public void Set_Company_Name(String New_Company_Name){
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

    @Override
    public int describeContents() {
        return 0;
    }

    @Override
    public void writeToParcel(Parcel parcel, int i) {
        parcel.writeString(CompanyName);
        parcel.writeString(Founder);
        parcel.writeString(Product);
    }
}

public class ChangeAddActivity extends AppCompatActivity
{
    Button save_company_button;
    EditText
            CompanyEditText,
            FounderEditText,
            ProductEditText;
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.change_add_activity);
        save_company_button = findViewById(R.id.save_company_button);
        CompanyEditText = findViewById(R.id.company_edit_text);
        FounderEditText = findViewById(R.id.founder_edit_text);
        ProductEditText = findViewById(R.id.product_edit_text);
        PCompany PC = null;
        int id = 0;
        Bundle arguments = getIntent().getExtras();
        int head = (int)arguments.get("head");
        if(arguments.get("company")!=null){
            PC = (PCompany) arguments.get("company");
            id = (int) arguments.get("id");
        }
        TextView tv = findViewById(R.id.change_add_head);
        if(head==0)
        {
            tv.setText(getString(R.string.add_company_head));
        }
        else {
            tv.setText(getString(R.string.change_company_head));
            CompanyEditText.setText(PC.Get_Company_Name());
            FounderEditText.setText(PC.Get_Founder());
            ProductEditText.setText(PC.Get_Product());
        }
        int finalId = id;
        save_company_button.setOnClickListener(view -> {
            if(     CompanyEditText.getText().toString().trim().equals("")
                    || FounderEditText.getText().toString().trim().equals("")
                    || ProductEditText.getText().toString().trim().equals("")
            ){
                Toast.makeText(ChangeAddActivity.this,"Не все поля заполнены",Toast.LENGTH_SHORT).show();
            }
            else{
                String Company = CompanyEditText.getText().toString().trim();
                String Founder = FounderEditText.getText().toString().trim();
                String Product = ProductEditText.getText().toString().trim();
                PCompany PC2 = new PCompany(Company,Founder,Product);
                Intent resultIntent = new Intent(ChangeAddActivity.this,MainActivity.class);
                resultIntent.putExtra("company",PC2);
                resultIntent.putExtra("id", finalId);
                setResult(Activity.RESULT_OK,resultIntent);
                finish();
            }
        });
    }

}
