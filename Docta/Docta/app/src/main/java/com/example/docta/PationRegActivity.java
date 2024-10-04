package com.example.docta;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.graphics.Bitmap;
import android.media.MediaCodec;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.text.TextUtils;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.OnFailureListener;
import com.google.android.gms.tasks.OnSuccessListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.storage.FirebaseStorage;
import com.google.firebase.storage.StorageReference;
import com.google.firebase.storage.UploadTask;

import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;
import java.util.regex.Pattern;

import de.hdodenhof.circleimageview.CircleImageView;

public class PationRegActivity extends AppCompatActivity implements View.OnClickListener {
    private Button BtnNext;
    private Button BtnBackReg;
    private TextView textNewSignUp;
    private EditText NamePation,PhonePation,PasswordPation,AgePation,EmailPation;
    private DatabaseReference databaseReference=FirebaseDatabase.getInstance().getReferenceFromUrl("https://docta-l3mi-default-rtdb.firebaseio.com");



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pation_reg);
        //Declation of inputs info for pation regstrition
        NamePation=(EditText) findViewById(R.id.NamePation);
        PhonePation=(EditText)findViewById(R.id.PhonePation);
        PasswordPation=(EditText)findViewById(R.id.PasswordPation);
        AgePation=(EditText)findViewById(R.id.AgePation);
        EmailPation=(EditText)findViewById(R.id.EmailPation);
        //Declation of buttons move
        BtnNext=(Button) findViewById(R.id.BtnNext);
        BtnNext.setOnClickListener(this);
        //-----------------------------
        BtnBackReg=findViewById(R.id.BtnBackReg);
        textNewSignUp=findViewById(R.id.textNewSignUp);



        BtnBackReg.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(PationRegActivity.this,TypePersonActivity.class);
                startActivity(intent);
                intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                intent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
            }
        });
        textNewSignUp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(PationRegActivity.this,LoginActivity.class);
                startActivity(intent);
                intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
                intent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);

            }
        });
    }

    @Override
    public void onClick(View view) {
        switch (view.getId()){
            case R.id.BtnNext:
                BtnNext();
        }
    }

    private void BtnNext() {
         String FullName =NamePation.getText().toString().trim();
         String NumbPhone =PhonePation.getText().toString().trim();
         String Password =PasswordPation.getText().toString().trim();
         String NumbAgePation =AgePation.getText().toString().trim();
         String Email =EmailPation.getText().toString().trim();
        if (TextUtils.isEmpty(FullName)){
            NamePation.setError("Le Nom Complet est Obligatoire");
            NamePation.requestFocus();
            return;
        }
        if (TextUtils.isEmpty(NumbPhone)){
            PhonePation.setError("Le Numéro de Téléphone est Obligatoire");
            PhonePation.requestFocus();
            return;
        }
        if (TextUtils.isEmpty(Password)){
            PasswordPation.setError("Le Mot de Passe est Obligatoire");
            PasswordPation.requestFocus();
            return;
        }
        if(Password.length()<8){
            PasswordPation.setError("La longueur minimale du mot de passe doit être de 6 caractères");
            PasswordPation.requestFocus();
            return;
        }
        if (TextUtils.isEmpty(NumbAgePation)){
            AgePation.setError("âge est Obligatoire");
            AgePation.requestFocus();
            return;
        }
        if (!Patterns.EMAIL_ADDRESS.matcher(Email).matches()){
            EmailPation.setError("Le Email est Obligatoire");
            EmailPation.requestFocus();
            return;
        }
        else{
            // user user=new user(FullNameTest,PhoneNumberTest,EmailTest);
            databaseReference.child("Users").child(NumbPhone).child("FullName").setValue(FullName);
            databaseReference.child("Users").child(NumbPhone).child("Emil").setValue(Email);
            databaseReference.child("Users").child(NumbPhone).child("Age").setValue(NumbAgePation);
            databaseReference.child("Users").child(NumbPhone).child("Password").setValue(Password);
            databaseReference.child("Users").child(NumbPhone).child("NumberPhone").setValue(NumbPhone);
            //databaseReference.child("Users").child(NumbPhone).child("Gender").setValue(" ");
           // databaseReference.child("Users").child(NumbPhone).child("Diabete").setValue(" ");
            Toast.makeText(PationRegActivity.this, "User Has ben Reg", Toast.LENGTH_SHORT).show();
            Intent intent=new Intent(PationRegActivity.this,PationRegGendrActivity.class);
            intent.putExtra("ID",NumbPhone);
            startActivity(intent);


        }

    }
}