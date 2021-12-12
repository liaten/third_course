package liaten.app5;

import android.graphics.Color;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.util.regex.Pattern;

public class RegistrationActivity extends AppCompatActivity {

    EditText login_edit_text, email_edit_text, password_edit_text;
    TextView email_error_text;
    Button confirm_button, drop_button;

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registration);

        login_edit_text = findViewById(R.id.login_edit_text);
        email_edit_text = findViewById(R.id.email_edit_text);
        password_edit_text = findViewById(R.id.password_edit_text);
        confirm_button = findViewById(R.id.confirm_button);
        drop_button = findViewById(R.id.drop_button);
        email_error_text = findViewById(R.id.email_error_text);

        confirm_button.setOnClickListener(onConfirmButtonClickListener);
        drop_button.setOnClickListener(onDropButtonClickListener);

        // Запрет на ввод нерелевантных почтовому адресу символов
        for (EditText et : new EditText[]{email_edit_text})
            et.addTextChangedListener(new TextWatcher()
            {
                @Override public void beforeTextChanged(CharSequence s, int start, int count, int after){}
                @Override public void onTextChanged(CharSequence s, int start, int before, int count) {
                    if (Pattern.compile("[[^a-zA-Z0-9@.]]").matcher(et.getText().toString()).find())
                    {
                        et.setText(et.getText().toString().substring(0,et.getText().toString().length() - 1));
                        et.setSelection(et.getText().toString().length());
                    }
                }
                @Override public void afterTextChanged(Editable s){}
            });

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

    // Возвращает true, если email подходит

    private boolean ValidateEmailAddress(EditText email){
        String emailInput = email.getText().toString();
        if (!emailInput.isEmpty()
                && Patterns.EMAIL_ADDRESS.matcher(emailInput).matches()){
            return true;
        } else {
            return false;
        }
    };

    private boolean isPasswordValid(String password) {
        return password != null && password.trim().length() > 5;
    }

    private boolean ValidatePassword(EditText password){
        String passwordInput = password.getText().toString();
        if (isPasswordValid(passwordInput)){
            //Toast.makeText(this,"Email введён верно",Toast.LENGTH_SHORT).show();
            return true;
        } else {
            //Toast.makeText(this,"Email введён неверно",Toast.LENGTH_SHORT).show();
            return false;
        }
    };

    public View.OnClickListener onDropButtonClickListener = view ->
    {
        login_edit_text.setText("");
        email_edit_text.setText("");
        password_edit_text.setText("");
    };

    public View.OnClickListener onConfirmButtonClickListener = view ->
    {
        if(
                login_edit_text.getText().toString().trim().equals("") ||
                        email_edit_text.getText().toString().trim().equals("") ||
                        password_edit_text.getText().toString().trim().equals("")
        ){
            Toast.makeText(this,"Не все поля заполнены",Toast.LENGTH_SHORT).show();
        }
        else {
            if(ValidateEmailAddress(email_edit_text)){
                senEmail();
                email_error_text.setTextColor(Color.parseColor("#4BD327"));
                email_error_text.setText(R.string.email_true_message);
            }
            else {
                email_error_text.setTextColor(Color.parseColor("#F44336"));
                email_error_text.setText(R.string.email_error_message);
            }

        }
    };

    private void senEmail() {
        String mEmail = email_edit_text.getText().toString();
        String mSubject = "Оповещение";
        String mMessage = "Ваш логин для входа в приложение: "
                + login_edit_text.getText().toString()
                + "\nВаш email для входа в приложение: " + email_edit_text.getText().toString()
                + "\nВаш пароль для входа в приложение: " + password_edit_text.getText().toString()
                + "\nИспользуйте только один вариант: логин или email в окне авторизации. Приятного пользования программой!";
        JavaMailAPI javaMailAPI = new JavaMailAPI(this, mEmail, mSubject, mMessage);
        javaMailAPI.execute();
    };

}