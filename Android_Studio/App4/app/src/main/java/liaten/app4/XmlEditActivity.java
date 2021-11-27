package liaten.app4;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class XmlEditActivity extends Activity {
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.xml_edit_activity);
        Button add_button = (Button) findViewById(R.id.add_param_button);
        Button edit_button = (Button) findViewById(R.id.edit_param_button);
        add_button.setOnClickListener(add_listener);
        edit_button.setOnClickListener(edit_listener);
    }
    private View.OnClickListener add_listener = new View.OnClickListener(){
        @Override
        public void onClick(View view) {
            Intent addIntent = new Intent("android.intent.action.ChangeAddActivity");
            addIntent.putExtra("head",0);
            startActivity(addIntent);
            //
            //tv.setText(getString(R.string.add_student_head));
        }
    };
    private View.OnClickListener edit_listener = new View.OnClickListener(){
        @Override
        public void onClick(View view) {
            Intent addIntent = new Intent("android.intent.action.ChangeAddActivity");
            addIntent.putExtra("head",1);
            startActivity(addIntent);
        }
    };
}
