﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("erste Tests mit Operatoren");

     //Multiplikative Operatoren
     Debug.Log("Multiplikative Operatoren: 2*3 = " + (2 * 3));
     Debug.Log("Multiplikative Operatoren: 100/3 = " + (100 / 3));
     Debug.Log("Multiplikative Operatoren: 20%10 = " + (20 % 10));



      //Additive Operatoren
      Debug.Log("Additive Operatoren: 20+4 = " + (20 + 4));
      Debug.Log("Additive Operatoren: 20-4 = " + (20 - 4));
    }


    // Update is called once per frame
    void Update () {
		
	}
}
