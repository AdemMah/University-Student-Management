package com.example.docta;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.HashMap;
import java.util.Map;

public class PationRegGendrActivity extends AppCompatActivity {
    private Button BtnBackGender;
    private Button BtnNext;
    private RadioButton Meal,Femeal;
    public RadioButton Noun,TypeI,TypeII;
    private DatabaseReference Dr= FirebaseDatabase.getInstance().getReference().child("Users");
    private DatabaseReference databaseReference= FirebaseDatabase.getInstance().getReferenceFromUrl("https://docta-l3mi-default-rtdb.firebaseio.com");
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pation_reg_gendr);

        Intent intent=getIntent();
        String Id=intent.getStringExtra("ID");
        BtnBackGender=findViewById(R.id.BtnBackGender);
        BtnNext=findViewById(R.id.BtnNext);
        Meal=findViewById(R.id.RBtnMeal);
        Femeal=findViewById(R.id.RBtnFemale);
        Noun=findViewById(R.id.radioDiabNoun);
        TypeI=findViewById(R.id.radioDiabTypeI);
        TypeII=findViewById(R.id.radioDiabTypeII);

        BtnBackGender.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                 Intent intent=new Intent(PationRegGendrActivity.this,PationRegActivity.class);
               startActivity(intent);
                intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                intent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
            }
        });
        BtnNext.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String MealG ="Meal";
                String FemaleG ="Femeal";
                String Noun ="Noun";
                String TypeI ="TypeI";
                String TypeII ="TypeII";
                String id=Id.trim();
                SelectGender(MealG,FemaleG,id);
                SelectDiabete(Noun,TypeI,TypeII,id);
            }
        });
    }

    private void SelectGender(String MealG,String Female,String id) {
        if(Meal.isChecked()){
            Map<String,Object> UpdateGender=new HashMap<>();
            UpdateGender.put("Gender",MealG);
            Dr.child(id).updateChildren(UpdateGender);

            //Toast.makeText(PationRegGendrActivity.this, "MealAdded", Toast.LENGTH_SHORT).show();
        }
        if (Femeal.isChecked()){
            Map<String,Object> UpdateGender=new HashMap<>();
            UpdateGender.put("Gender",Female);
            Dr.child(id).updateChildren(UpdateGender);

            //Toast.makeText(PationRegGendrActivity.this, "Femeal Added", Toast.LENGTH_SHORT).show();
        }
        else {
            Toast.makeText(PationRegGendrActivity.this, "Select gender", Toast.LENGTH_SHORT).show();
        }

    }
    private void SelectDiabete(String NounD,String TypeID,String TypeIID,String id) {

        if(Noun.isChecked()){
            Map<String,Object> UpdateGender=new HashMap<>();
            UpdateGender.put("Diabete",NounD);
            Dr.child(id).updateChildren(UpdateGender);

            Toast.makeText(PationRegGendrActivity.this, "Noune Selected", Toast.LENGTH_SHORT).show();

            Intent intent=new Intent(PationRegGendrActivity.this,MainActivity.class);
            startActivity(intent);
            intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
            intent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
        }
        if (TypeI.isChecked()){
            Map<String,Object> UpdateGender=new HashMap<>();
            UpdateGender.put("Diabete",TypeID);
            Dr.child(id).updateChildren(UpdateGender);

            Toast.makeText(PationRegGendrActivity.this, "TypeI Selected", Toast.LENGTH_SHORT).show();
            Intent intent=new Intent(PationRegGendrActivity.this,MainActivity.class);
            startActivity(intent);
            intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
            intent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
        }
        if (TypeII.isChecked()){
            Map<String,Object> UpdateGender=new HashMap<>();
            UpdateGender.put("Diabete",TypeIID);
            Dr.child(id).updateChildren(UpdateGender);

            Toast.makeText(PationRegGendrActivity.this, "TypeII Selected", Toast.LENGTH_SHORT).show();
            Intent intent=new Intent(PationRegGendrActivity.this,MainActivity.class);
            startActivity(intent);
            intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
            intent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
        }
        else {
            Toast.makeText(PationRegGendrActivity.this, "Select Diabet", Toast.LENGTH_SHORT).show();
        }
    }

}