package com.example.docta;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

public class DoctoRegInfoActivity extends AppCompatActivity implements View.OnClickListener {

    private DatabaseReference Dr= FirebaseDatabase.getInstance().getReference().child("Doctors");
    private Spinner spinnerSpec;
    private EditText TimeAm,TimePm;
    public CheckBox C1,C2,C3,C4,C5,C6,C7;
    private Button BtnSignUpDoctor;
    private String Id;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_docto_reg_info);
        BtnSignUpDoctor=findViewById(R.id.BtnSignUpDoctor);
        spinnerSpec=findViewById(R.id.spinnerSpec);
        TimeAm=findViewById(R.id.TimeAm);
        TimePm=findViewById(R.id.TimePm);
        C1=findViewById(R.id.Day1);
        C2=findViewById(R.id.Day2);
        C3=findViewById(R.id.Day3);
        C4=findViewById(R.id.Day4);
        C5=findViewById(R.id.Day5);
        C6=findViewById(R.id.Day6);
        C7=findViewById(R.id.Day7);
        Intent intent=getIntent();
        Id=intent.getStringExtra("IdDoctor");

        BtnSignUpDoctor.setOnClickListener(this);


        String[]Spec={"Neurologue","Cardiologie","Pneumologie","Ophtalmologie","Néphrologie","Gastroentérologie"
                ,"Hépatologie","Dermatologie","Orthopédie","Analyse de Sang","Médecine Générale","Dentiste","Pharmacie","Oto-Rhino-Laryngologie","Pédiatrie"
                ,"Gynécologue"};

        //ArrayList<String> ListSpec=new ArrayList<>(Arrays.asList(Spec));
        ArrayList<String> ListSpec=new ArrayList<>(Arrays.asList(Spec));
        ListSpec.add(0,"Choisissez Votre spécialité");
        ArrayAdapter<String> arrayAdapter =new ArrayAdapter<>(this,R.layout.spinner_spec_text,ListSpec);
        spinnerSpec.setAdapter(arrayAdapter);


    }
    @Override
    public void onClick(View view) {
        switch (view.getId()){
            case R.id.BtnSignUpDoctor:
                //DoctorRegInfo();
                DoctorRegInfo2();
        }
    }
    /*  private void DoctorRegInfo(){

          String D1="Samedi";
          String D2="Dimanche";
          String D3="Lundi";
          String D4="Mardi";
          String D5="Mercredi";
          String D6="Jeudi";
          String D7="Vendredi";
          if(C1.isChecked()){
              Dr.child(Id).child("DayJobs").child("Day1").setValue(D1);
          }
          if(C2.isChecked()){
              Dr.child(Id).child("DayJobs").child("Day2").setValue(D2);
          }
          if(C3.isChecked()){
              Dr.child(Id).child("DayJobs").child("Day3").setValue(D3);
          }
          if(C4.isChecked()){
              Dr.child(Id).child("DayJobs").child("Day4").setValue(D4);
          }
          if(C5.isChecked()){
              Dr.child(Id).child("DayJobs").child("Day5").setValue(D5);
          }
          if(C6.isChecked()){
              Dr.child(Id).child("DayJobs").child("Day6").setValue(D6);
          }
          if(C7.isChecked()){
              Dr.child(Id).child("DayJobs").child("Day7").setValue(D7);
          }else {
              Toast.makeText(DoctoRegInfoActivity.this, "Select Days", Toast.LENGTH_SHORT).show();
          }
      }*/
    private void DoctorRegInfo2(){
        String Spec =spinnerSpec.getSelectedItem().toString().trim();
        String TiemAmJob =TimeAm.getText().toString().trim();
        String TiemPmJob =TimePm.getText().toString().trim();
        if (TextUtils.isEmpty(TiemAmJob)){
            TimeAm.setError("âge est Obligatoire");
            TimeAm.requestFocus();
            return;
        }
        if (TextUtils.isEmpty(TiemPmJob)){
            TimePm.setError("âge est Obligatoire");
            TimePm.requestFocus();
            return;
        }else {
            Map<String,Object> UpdateGender=new HashMap<>();
            UpdateGender.put("TimeAm",TiemAmJob);
            UpdateGender.put("TimePm",TiemPmJob);
            UpdateGender.put("specialite",Spec);
            Dr.child(Id).updateChildren(UpdateGender);
            Intent intent=new Intent(DoctoRegInfoActivity.this, MainActivity.class);
            startActivity(intent);
            Toast.makeText(DoctoRegInfoActivity.this, "indo Added", Toast.LENGTH_SHORT).show();

        }



    }


}