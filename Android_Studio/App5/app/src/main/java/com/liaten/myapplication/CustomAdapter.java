package com.liaten.myapplication;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class CustomAdapter extends RecyclerView.Adapter<CustomAdapter.ViewHolder> {

    private Context context;
    private ArrayList id, company, founder, product;

    CustomAdapter(Context context,
                  ArrayList _id,
                  ArrayList _company,
                  ArrayList _founder,
                  ArrayList _product){
        this.context = context;
        this.id = _id;
        this.company = _company;
        this.founder = _founder;
        this.product = _product;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(context);
        View view = inflater.inflate(R.layout.row,parent,false);
        return new ViewHolder(view);

    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        holder.company_id_text.setText(String.valueOf(id.get(position)));
        holder.company_text.setText(String.valueOf(company.get(position)));
        holder.founder_text.setText(String.valueOf(founder.get(position)));
        holder.product_text.setText(String.valueOf(product.get(position)));
    }

    @Override
    public int getItemCount() {
        return id.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {

        TextView company_id_text, company_text, founder_text, product_text;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            company_id_text = itemView.findViewById(R.id.company_id_text);
            company_text = itemView.findViewById(R.id.company_text);
            founder_text = itemView.findViewById(R.id.founder_text);
            product_text = itemView.findViewById(R.id.product_text);
        }
    }
}
