package com.example.notatki;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {


    ArrayList<String> listaNotatek = new ArrayList<>();
    ArrayAdapter<String> adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        ListView lista = findViewById(R.id.lista);
        listaNotatek.add("Zakupy: chleb, masło, ser");
        listaNotatek.add("Do zrobienia: obiad, umyć podłogi");
        listaNotatek.add("weekend: kino, spacer z psem");

        adapter = new ArrayAdapter<>(
                this,
                android.R.layout.simple_list_item_1,
                listaNotatek
        );

        lista.setAdapter(adapter);




    }

    public void dodaj(View view) {

        EditText nowy = findViewById(R.id.nowyElement);
        ListView lista = findViewById(R.id.lista);


        String nowaWartosc = nowy.getText().toString();
        listaNotatek.add(nowaWartosc);


        lista.setAdapter(adapter);





    }
}