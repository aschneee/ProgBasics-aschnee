using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour
{
    public int test1;
    public float test2;
    public string test3;

	// Use this for initialization
	void Start () {
        //aufrufen der public void operators
        //Klammern sind die Parameter Liste
        test1 = 1;
        Debug.Log("test 1 in Start" + test1);
        Operators();
        Test();
        Test2();
        AddNumbers(1, 2);
        AddNumbers(3, 6);
        MultNumbers(2, 3, 6, 7);
        Combine();
        Debug.Log(MyText("aschnee2"));
        // drama ist die variable 
        string drama = MyText("aschnee1");
        Debug.Log("neu " + drama);
    }

    public string MyText(string myName)
    {
        Debug.Log("DramaLog");
        return "Drama" + " " + myName;  //mindestens ein leerer String muss drinnen stehen
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
        test1 = 3;
        Debug.Log("test 1 in AddNumbers " + c);
    }

    public void MultNumbers(int a, int b, int c, int d)
    {
        int e = a * b * c * d;
        Debug.Log("multiply numbers = " + e);
    }

    public void Combine()
    {
        
        //MultNumbers(4, 5, 3, 2);
        //Operators();
        AddNumbers(200, 500);

    }

    // Methode die sring retour gibt

  
    // Update is called once per frame
    void Update () {
		
	}
}
