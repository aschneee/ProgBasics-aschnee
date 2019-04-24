using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour
{
    public int test1;
    public float test2;
    public string test3;
    public string name = "Alina";
    public string nachname = "Schneeberger";
    public string alter = "18";
   

    // Use this for initialization
    void Start () {
        //aufrufen der public void operators
        //Klammern sind die Parameter Liste
        test1 = 1;
        test2 = 0.25F;
        test3 = "test3";
        Debug.Log("test 1 in start (mit int): " + test1);
        Debug.Log("test 2 in start (mit float): " + test2);
        Debug.Log("test 3 in start (mit string)" + test3);


        Operators();
        Test();
        Test2();
        AddNumbers(1, 2);
        AddNumbers(3, 6);
        MultNumbers(2, 3, 6, 7);
        Combine();
        MyName();
        TestsCombined();
        NameAlter();
        changeTest2();
        Debug.Log(MyText("aschnee2"));
        // drama ist die variable 
        //return type
        string drama = MyText("aschnee1");
        Debug.Log("neu " + drama);
   
        Debug.Log(StadtLand("Salzburg", "Austria"));

        Debug.Log(MyMeal("Schnitzel"));

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

    public void TestsCombined()
    {
        Debug.Log("all tests: " + test1 + " " + test2 + " " + test3);
    }

    public void MyName()
    {
        Debug.Log("Ich bin " + name + " " + nachname);
    }

    public void NameAlter()
    {
        Debug.Log("Nname: " + name + " Alter: " + alter);
    }

    // methode referes to methode ABC
    public void XY()
    {
        Debug.Log("Methode XY - führe ABC aus");
        ABC();
    }

    public void ABC()
    {
        Debug.Log("ABC wird ausgeführt");
        Debug.Log(1 + 2);
    }

    public void intAdd()
    {
        int eins;
        eins = 1;
        int vier;
        vier = 4;

        Debug.Log("int addieren " + (eins + vier));
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

    //change value
    public void changeTest2()
    {
        test2 = 123.45F;
        Debug.Log("changed test2  " + test2);
    }


    //return type 
    public string MyText(string myName)
    {
        Debug.Log("DramaLog");
        return "Drama" + " " + myName;  //mindestens ein leerer String muss drinnen stehen
    }
    
        public string StadtLand(string stadt, string land)
    {
        return "Heimat: " + stadt + ", " + land;
    }
        public string MyMeal(string favemeal)
    {
        return "Lieblingsessen: " + favemeal;
    }

    // Methode die sring retour gibt


    // Update is called once per frame
    void Update () {
		
	}
}
