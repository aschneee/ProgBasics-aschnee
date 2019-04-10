﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour
{

	// Use this for initialization
	void Start () {
        //aufrufen der public void operators
        //Klammern sind die Parameter Liste
        Operators();
        Test();
        Test2();
        AddNumbers(1,2);
        Mult(2, 3, 6, 7);
    }

    public void Operators()
    {
        Debug.Log("erste Tests mit Operatoren");

        //Multiplikative Operatoren
        Debug.Log("Multiplikative Operatoren: 2*3 = " + (2 * 3));
        Debug.Log("Multiplikative Operatoren: 100/3 = " + (100 / 3));
        Debug.Log("Multiplikative Operatoren: 20%10 = " + (20 % 10));



        //Additive Operatoren
        Debug.Log("Additive Operatoren: 20+4 = " + (20 + 4));
        Debug.Log("Additive Operatoren: 20-4 = " + (20 - 4));



        //Relationale Operatoren
        Debug.Log("Relationale Operatoren: 20<4 = " + (20 < 4));
        Debug.Log("Relationale Operatoren: 20<=20 = " + (20 <= 20));
        Debug.Log("Relationale Operatoren: 20>4 = " + (20 > 4));
        Debug.Log("Relationale Operatoren: 20>=4 = " + (20 >= 21));


        //Gleichheits Operatoren
        Debug.Log("Gleichheits Operatoren: 20==20 = " + (20 == 20));
        Debug.Log("Gleichheits Operatoren: 10!=20 = " + (10 != 20));

        //Logische Operatoren
        Debug.Log("Logische Operatoren: true&true = " + (true & true));
        Debug.Log("Logische Operatoren: false&&true = " + (false && true));
        Debug.Log("Logische Operatoren: false|true = " + (false | true));
        Debug.Log("Logische Operatoren: true||false = " + (true || false));
    }

    // Methoden Deklaration
    public void xy ()
    {

    }

    public void Test ()
    {
        Debug.Log("Hallo du!");
    }

    public void Test2 ()
    {
        Debug.Log("Test2 Logischer Operator: true und true = " + (true & true));
    }

    //int a ist eine Dekalration einer Variable 
    //innerhalb de methode kann ich darauf zugreifen
    public void AddNumbers(int a, int b)
    {
        int c = a + b;
        Debug.Log("add numbers = " + c);
    }

    public void Mult(int a, int b, int c, int d)
    {
        int e = a * b * c * d;
        Debug.Log("multiply numbers = " + e);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
