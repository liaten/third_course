package liaten.app4;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.Nullable;

import java.io.FileOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

class Student{
    private String Full_Name;
    private String Gender;
    private String Programming_Languages;
    private String IDE;
    public Student(String Full_Name_Add, String Gender_Add, String Programming_Languages_Add, String IDE_Add){
        this.Full_Name = Full_Name_Add;
        this.Gender = Gender_Add;
        this.Programming_Languages = Programming_Languages_Add;
        this.IDE = IDE_Add;
    }
    public String Get_Full_Name(){
        return this.Full_Name;
    }

    public void Set_Full_Name(String New_Full_Name){
        this.Full_Name = New_Full_Name;
    }

    public String Get_Gender(){
        return this.Gender;
    }

    public void Set_Gender(String New_Gender){
        this.Gender = New_Gender;
    }

    public String Get_Programming_Languages(){
        return this.Programming_Languages;
    }

    public void Set_Programming_Languages(String New_Programming_Languages){
        this.Programming_Languages = New_Programming_Languages;
    }

    public String Get_IDE(){
        return this.IDE;
    }

    public void Set_IDE(String New_IDE){
        this.IDE = New_IDE;
    }

}

public class XmlEditActivity extends Activity {
    ListView StudentLV;
    List list = new ArrayList();
    ArrayList<Student> student_list = new ArrayList<>();
    TextView head_text_view;
    EditText StudentETXml;
    Button add_button;
    ArrayAdapter adapter;
    boolean IsText = false;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.xml_edit_activity);
        add_button = findViewById(R.id.add_param_button);
        head_text_view = findViewById(R.id.xml_head);
        head_text_view.setOnClickListener(change_on_head_click_listener);
        add_button.setOnClickListener(add_listener);
        StudentETXml = findViewById(R.id.editTextMultiLineXml);
        StudentLV = findViewById(R.id.listview_student);
        Student Vlad = new Student("Пестерев Владислав Олегович","Мужской","C#, Kotlin, Java","Android Studio, Visual Studio");
        Student Alex = new Student("Ватаманов Александр Александрович","Мужской","Java, C#, Delphi","Visual Studio");
        Student Artem = new Student("Гарматко Артем Сергеевич","Мужский","C#, Java","Visual Studio");
        Student Andrey = new Student("Черняев Андрей Григорьевич","Мужской","Java","IntelliJ Idea");
        student_list.add(Vlad);
        student_list.add(Alex);
        student_list.add(Artem);
        student_list.add(Andrey);
        String to_edit_text = "<students>";
        String student;
        for (int i = 0; i < student_list.size(); i++)
        {
            student="\n    <student>\n";
            student+="        <full_name>";
            student+=student_list.get(i).Get_Full_Name();
            student+="</full_name>\n";
            student+="        <ide>";
            student+=student_list.get(i).Get_IDE();
            student+="</ide>\n";
            student+="        <gender>";
            student+=student_list.get(i).Get_Gender();
            student+="</gender>\n";
            student+="        <pl>";
            student+=student_list.get(i).Get_Programming_Languages();
            student+="</pl>\n";
            list.add
                    (
                            student_list.get(i).Get_Full_Name() +
                            "\n" + student_list.get(i).Get_IDE() +
                            " | " + student_list.get(i).Get_Gender() +
                            " | " + student_list.get(i).Get_Programming_Languages()
                    );
            student+="    </student>";
            to_edit_text+=student;
        }
        to_edit_text+="\n</students>";
        StudentETXml.setText(to_edit_text);

        adapter = new ArrayAdapter(XmlEditActivity.this, android.R.layout.simple_list_item_1,list);
        StudentLV.setAdapter(adapter);
        StudentLV.setOnItemClickListener((AdapterView<?> parent, View view, int position, long id) -> {
            Intent editIntent = new Intent("android.intent.action.ChangeAddActivity");
            editIntent.putExtra("head",1);
            PStudent PS = new PStudent(
                    student_list.get((int) id).Get_Full_Name(),
                    student_list.get((int) id).Get_Gender(),
                    student_list.get((int) id).Get_Programming_Languages(),
                    student_list.get((int) id).Get_IDE()
                    );
            editIntent.putExtra("student", PS);
            int idd = (int) id;
            editIntent.putExtra("id",idd);
            startActivityForResult(editIntent,2);
        });

    }

    private final View.OnClickListener change_on_head_click_listener = view -> {
        head_text_view = findViewById(R.id.xml_head);
        StudentETXml = findViewById(R.id.editTextMultiLineXml);
        StudentLV = findViewById(R.id.listview_student);
        if(IsText==false){
            // text is now visible
            head_text_view.setText(getString(R.string.xml_head_text));
            StudentLV.setVisibility(View.INVISIBLE);
            StudentETXml.setVisibility(View.VISIBLE);
            IsText = true;
        }
        else if(IsText){
            // text is now invisible
            head_text_view.setText(getString(R.string.xml_head_visual));
            StudentLV.setVisibility(View.VISIBLE);
            StudentETXml.setVisibility(View.INVISIBLE);
            IsText = false;
        }
    };
    private final View.OnClickListener add_listener = view -> {
        Intent addIntent = new Intent("android.intent.action.ChangeAddActivity");
        addIntent.putExtra("head",0);
        startActivityForResult(addIntent,1);
    };

    private final View.OnClickListener xml_export_listener = view -> {
        FileOutputStream f;
        try
        {
            EditText et = findViewById(R.id.editTextTxt);
            String text = et.getText().toString();
            f = openFileOutput("1.xml", MODE_PRIVATE);
            f.write(text.getBytes());
            Toast.makeText(XmlEditActivity.this,"Файл сохранен", Toast.LENGTH_SHORT).show();
        }
        catch (IOException ex)
        {
            Toast.makeText(XmlEditActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
        }
    };

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if(requestCode == 1){
            // add item to list
            if(resultCode == RESULT_OK){
                PStudent PS;
                if (data != null) {
                    PS = data.getParcelableExtra("student");
                    student_list.add(new Student(PS.Get_Full_Name(),PS.Get_Gender(),PS.Get_Programming_Languages(),PS.Get_IDE()));
                    int last_student_place = student_list.size()-1;
                    list.add(
                            student_list.get(last_student_place).Get_Full_Name() +
                                    "\n" + student_list.get(last_student_place).Get_IDE() +
                                    " | " + student_list.get(last_student_place).Get_Gender() +
                                    " | " + student_list.get(last_student_place).Get_Programming_Languages()
                    );
                    adapter = new ArrayAdapter(XmlEditActivity.this, android.R.layout.simple_list_item_1,list);
                    StudentLV.setAdapter(adapter);
                    StudentETXml = findViewById(R.id.editTextMultiLineXml);
                    String from_edit_text = StudentETXml.getText().toString();
                    from_edit_text = from_edit_text.substring(0,from_edit_text.length()-12);
                    String student = "\n    <student>\n";
                    student+="        <full_name>";
                    student+=student_list.get(last_student_place).Get_Full_Name();
                    student+="</full_name>\n";
                    student+="        <ide>";
                    student+=student_list.get(last_student_place).Get_IDE();
                    student+="</ide>\n";
                    student+="        <gender>";
                    student+=student_list.get(last_student_place).Get_Gender();
                    student+="</gender>\n";
                    student+="        <pl>";
                    student+=student_list.get(last_student_place).Get_Programming_Languages();
                    student+="</pl>\n";
                    student+="    </student>";
                    from_edit_text+=student;
                    from_edit_text+="\n</students>";
                    StudentETXml.setText(from_edit_text);
                }
            }
        }
        else if(requestCode == 2){
            // edit item from list
            if(resultCode == RESULT_OK){
                PStudent PS;
                if (data != null) {
                    PS = data.getParcelableExtra("student");
                    int id = data.getIntExtra("id",0);
                    student_list.get((int) id).Set_Full_Name(PS.Get_Full_Name());
                    student_list.get((int) id).Set_Gender(PS.Get_Gender());
                    student_list.get((int) id).Set_IDE(PS.Get_IDE());
                    student_list.get((int) id).Set_Programming_Languages(PS.Get_Programming_Languages());
                    list.clear();
                    String to_edit_text = "<students>";
                    String student;
                    for(int i = 0; i< student_list.size(); i++){
                        student="\n    <student>\n";
                        student+="        <full_name>";
                        student+=student_list.get(i).Get_Full_Name();
                        student+="</full_name>\n";
                        student+="        <ide>";
                        student+=student_list.get(i).Get_IDE();
                        student+="</ide>\n";
                        student+="        <gender>";
                        student+=student_list.get(i).Get_Gender();
                        student+="</gender>\n";
                        student+="        <pl>";
                        student+=student_list.get(i).Get_Programming_Languages();
                        student+="</pl>\n";
                        list.add
                                (
                                    student_list.get(i).Get_Full_Name() +
                                    "\n" + student_list.get(i).Get_IDE() +
                                    " | " + student_list.get(i).Get_Gender() +
                                    " | " + student_list.get(i).Get_Programming_Languages()
                                );
                        student+="    </student>";
                        to_edit_text+=student;
                    }
                    to_edit_text+="\n</students>";
                    StudentETXml.setText(to_edit_text);
                    adapter = new ArrayAdapter(XmlEditActivity.this, android.R.layout.simple_list_item_1,list);
                    StudentLV.setAdapter(adapter);
                }
            }
        }
    }

}

