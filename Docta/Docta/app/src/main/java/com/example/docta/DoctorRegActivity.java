package com.example.docta;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.util.Patterns;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.ArrayList;
import java.util.Arrays;

public class DoctorRegActivity extends AppCompatActivity {

    private Button BtnNextDoctor;
    private EditText Name_Doctor,Years_Job,NumbPhon_Doctor,Password_Doctor;
    private DatabaseReference Dr= FirebaseDatabase.getInstance().getReference().child("Users");
    private DatabaseReference databaseReference= FirebaseDatabase.getInstance().getReferenceFromUrl("https://docta-l3mi-default-rtdb.firebaseio.com");

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_doctor_reg);

        BtnNextDoctor=findViewById(R.id.BtnNextDoctor);
        Name_Doctor= (EditText) findViewById(R.id.NameDoctor);
        Years_Job= (EditText) findViewById(R.id.YearJob);
        NumbPhon_Doctor= (EditText) findViewById(R.id.PhoneDoctor);
        Password_Doctor= (EditText) findViewById(R.id.PasswordDoctor);


        BtnNextDoctor.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                DoctorRegistration();
                Intent intent=new Intent(DoctorRegActivity.this,DoctoRegInfoActivity.class);
                startActivity(intent);
                intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                intent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
            }
        });
    }
    private void DoctorRegistration() {
        String FullNameDoctor =Name_Doctor.getText().toString().trim();
        String YearjobDoctor =Years_Job.getText().toString().trim();
        String NumbPhoneDoctor =NumbPhon_Doctor.getText().toString().trim();
        String  PasswordDoctor =Password_Doctor.getText().toString().trim();
        //String Email =EmailPation.getText().toString().trim();
        if (TextUtils.isEmpty(FullNameDoctor)){
            Name_Doctor.setError("Le Nom Complet est Obligatoire");
            Name_Doctor.requestFocus();
            return;
        }
        if (TextUtils.isEmpty(NumbPhoneDoctor)){
            NumbPhon_Doctor.setError("Le Numéro de Téléphone est Obligatoire");
            NumbPhon_Doctor.requestFocus();
            return;
        }
        if (TextUtils.isEmpty(PasswordDoctor)){
            Password_Doctor.setError("Le Mot de Passe est Obligatoire");
            Password_Doctor.requestFocus();
            return;
        }
        if(PasswordDoctor.length()<8){
            Password_Doctor.setError("La longueur minimale du mot de passe doit être de 6 caractères");
            Password_Doctor.requestFocus();
            return;
        }
        if (TextUtils.isEmpty(YearjobDoctor)){
            Years_Job.setError("âge est Obligatoire");
            Years_Job.requestFocus();
            return;
        }
        else{
            // user user=new user(FullNameTest,PhoneNumberTest,EmailTest);
            databaseReference.child("Doctors").child(NumbPhoneDoctor).child("FullNameDoctor").setValue(FullNameDoctor);
            databaseReference.child("Doctors").child(NumbPhoneDoctor).child("YearjobDoctor").setValue(YearjobDoctor);
            databaseReference.child("Doctors").child(NumbPhoneDoctor).child("NumbPhoneDoctor").setValue(NumbPhoneDoctor);
            databaseReference.child("Doctors").child(NumbPhoneDoctor).child("PasswordDoctor").setValue(PasswordDoctor);
           // databaseReference.child("Doctors").child(NumbPhoneDoctor).child("specialite").setValue(" ");
            //databaseReference.child("Doctors").child(NumbPhoneDoctor).child("Time of Job").setValue(" ");
           // databaseReference.child("Doctors").child(NumbPhoneDoctor).child("Days of job").setValue(" ");
            Toast.makeText(DoctorRegActivity.this, "User Has ben Reg", Toast.LENGTH_SHORT).show();
            Intent intent=new Intent(DoctorRegActivity.this,DoctoRegInfoActivity.class);
            intent.putExtra("IdDoctor",NumbPhoneDoctor);
            startActivity(intent);
//+"-"+YearjobDoctor

        }

    }
}