package liaten.app4;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class ChangeAddActivity extends Activity
{
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.change_add_activity);
        Bundle arguments = getIntent().getExtras();
        int head = (int)arguments.get("head");
        TextView tv = (TextView) findViewById(R.id.change_add_head);
        if(head==0){
            tv.setText(getString(R.string.add_student_head));
        }
        else{
            tv.setText(getString(R.string.change_student_head));
        }
    }
}
