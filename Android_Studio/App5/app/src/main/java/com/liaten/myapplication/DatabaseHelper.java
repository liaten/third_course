package com.liaten.myapplication;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.widget.Toast;

import androidx.annotation.Nullable;

public class DatabaseHelper extends SQLiteOpenHelper {

    private Context context;
    private static final String DATABASE_NAME = "Companies.db";
    private static final int DATABASE_VERSION = 1;

    private static final String TABLE_NAME = "company_founder_product";
    private static final String COLUMN_ID = "id";
    private static final String COLUMN_COMPANY = "company";
    private static final String COLUMN_FOUNDER = "founder";
    private static final String COLUMN_PRODUCT = "product";

    DatabaseHelper(@Nullable Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
        this.context = context;
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String query =
                "CREATE TABLE " + TABLE_NAME +
                        " (" + COLUMN_ID + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
                        COLUMN_COMPANY + " TEXT, " +
                        COLUMN_FOUNDER + " TEXT, " +
                        COLUMN_PRODUCT + " TEXT);";
        db.execSQL(query);
        Toast.makeText(context,"Database created", Toast.LENGTH_SHORT).show();
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int i, int i1) {
        db.execSQL("DROP TABLE IF EXISTS " + TABLE_NAME);
        onCreate(db);
    }

    void AddCompany(String company, String founder, String product){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues cv = new ContentValues();

        cv.put(COLUMN_COMPANY, company);
        cv.put(COLUMN_FOUNDER, founder);
        cv.put(COLUMN_PRODUCT, product);
        long result = db.insert(TABLE_NAME, null, cv);
        if(result == -1){
            Toast.makeText(context,"Addition fail", Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(context,"Successful addition", Toast.LENGTH_SHORT).show();
        }
    }

    Cursor ReadAllData(){
        String query = "SELECT * FROM " + TABLE_NAME;
        SQLiteDatabase db = this.getReadableDatabase();

        Cursor cursor = null;
        if(db != null){
            cursor = db.rawQuery(query,null);
        }
        return cursor;
    }

    void updateData(String row_id, String company, String founder, String product){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues cv = new ContentValues();
        cv.put(COLUMN_COMPANY, company);
        cv.put(COLUMN_FOUNDER, founder);
        cv.put(COLUMN_PRODUCT, product);
        long result = db.update(TABLE_NAME, cv,"id=?", new String[]{row_id});
        if(result == -1){
            Toast.makeText(context,"Update fail", Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(context,"Update success", Toast.LENGTH_SHORT).show();
        }
    }
}
