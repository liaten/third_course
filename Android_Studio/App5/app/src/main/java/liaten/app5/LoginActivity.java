package liaten.app5;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import java.util.regex.Pattern;

public class LoginActivity extends AppCompatActivity
{

    Button login_button, registration_button, drop_button;
    EditText login_edit_text, password_edit_text;
    DatabaseHelper db;

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if(requestCode==0){
            // Узнать, как прошла регистрация!!
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        db = new DatabaseHelper(LoginActivity.this);
        login_button = findViewById(R.id.login_button);
        registration_button = findViewById(R.id.registration_button);
        drop_button = findViewById(R.id.drop_button);
        password_edit_text = findViewById(R.id.password_edit_text);
        login_edit_text = findViewById(R.id.login_edit_text);

        login_button.setOnClickListener(onLoginButtonClickListener);
        registration_button.setOnClickListener(onRegButtonClickListener);
        drop_button.setOnClickListener(onDropButtonClickListener);

        // Запрет на ввод пробелов
        for (EditText et : new EditText[]{password_edit_text, login_edit_text})
            et.addTextChangedListener(new TextWatcher()
            {
                @Override public void beforeTextChanged(CharSequence s, int start, int count, int after){}
                @Override public void onTextChanged(CharSequence s, int start, int before, int count) {
                    if (Pattern.compile("[\\p{Space}]").matcher(et.getText().toString()).find())
                    {
                        et.setText(et.getText().toString().substring(0,et.getText().toString().length() - 1));
                        et.setSelection(et.getText().toString().length());
                    }
                }
                @Override public void afterTextChanged(Editable s){}
            });

    }



    private boolean ValidateEmailAddress(EditText email){
        String emailInput = email.getText().toString();
        if (!emailInput.isEmpty()
                && Patterns.EMAIL_ADDRESS.matcher(emailInput).matches()){
            Toast.makeText(this,"Email введён верно",Toast.LENGTH_SHORT).show();
            return true;
        } else {
            Toast.makeText(this,"Email введён неверно",Toast.LENGTH_SHORT).show();
            return false;
        }
    };

    public View.OnClickListener onLoginButtonClickListener = view ->
    {
        ValidateEmailAddress(login_edit_text);
    };

    public View.OnClickListener onRegButtonClickListener = view ->
    {
        Intent intent = new Intent(this, RegistrationActivity.class);
        startActivityForResult(intent, 0);
    };

    public View.OnClickListener onDropButtonClickListener = view ->
    {
        password_edit_text.setText("");
        login_edit_text.setText("");
    };

    public void CursorLogins()
    {
        Cursor cursor = db.readAllLogins();

        if (cursor.getCount() != 0)
        {
            while (cursor.moveToNext())
            {
                /*
                corpID.add(cursor.getString(0));
                corpName.add(cursor.getString(1));
                corpFounders.add(cursor.getString(2));
                corpProducts.add(cursor.getString(3));
                corpPrice.add(cursor.getString(4));
                corpCategory.add(cursor.getString(5));
                 */
            }
        }
    }
}
