package liaten.app5;

import android.content.Context;
import android.content.Intent;
import android.content.res.Configuration;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.SearchView;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    RecyclerView recyclerView;
    Button add_button;
    DatabaseHelper db;
    ArrayList<String> corpID, corpName, corpFounders, corpProducts;
    TextView main_header_tv;
    SearchView search_bar;
    boolean IsSearchViewable = false;

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        recreate();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        recyclerView = findViewById(R.id.RecyclerView);
        add_button = findViewById(R.id.add_button);

        corpID = new ArrayList<>();
        corpName = new ArrayList<>();
        corpFounders = new ArrayList<>();
        corpProducts = new ArrayList<>();

        db = new DatabaseHelper(MainActivity.this);
        CursorData();

        recyclerView.setAdapter(new CorpAdapter((Context) this, corpID, corpName, corpFounders, corpProducts));
        recyclerView.setLayoutManager(new LinearLayoutManager(MainActivity.this));
        main_header_tv = findViewById(R.id.header_main);
        search_bar = findViewById(R.id.search_bar);
        main_header_tv.setOnClickListener(onHeadClickListener);
    }

    public View.OnClickListener onHeadClickListener = view -> {
        search_bar = findViewById(R.id.search_bar);
        main_header_tv = findViewById(R.id.header_main);
        if(!IsSearchViewable){
            main_header_tv.setText(R.string.search_results);
            search_bar.setVisibility(View.VISIBLE);
            IsSearchViewable = true;
        }
        else {
            main_header_tv.setText(R.string.info);
            search_bar.setVisibility(View.GONE);
            IsSearchViewable = false;
        }
    };

    @Override
    public void onConfigurationChanged(@NonNull Configuration newConfig) {
        super.onConfigurationChanged(newConfig);

        // Checks the orientation of the screen
        if (newConfig.orientation == Configuration.ORIENTATION_LANDSCAPE) {
            TextView corpName = findViewById(R.id.corpName_txt);
            TextView corpFounders = findViewById(R.id.corpFounders_txt);
            TextView corpProducts = findViewById(R.id.corpProducts_txt);
            corpName.setWidth(500);
            corpFounders.setWidth(500);
            corpProducts.setWidth(500);
        }
    }

    public void CursorData(){
        Cursor cursor = db.readAllData();

        if (cursor.getCount() != 0){
            while (cursor.moveToNext()) {
                corpID.add(cursor.getString(0));
                corpName.add(cursor.getString(1));
                corpFounders.add(cursor.getString(2));
                corpProducts.add(cursor.getString(3));
            }
        }
    }

    public void onClickAddButtonMain(View view) {
        startActivityForResult(new Intent(this, SecondActivity.class), 1);
    }
}