using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int gernades;
        public int rockets;
        public float fuel;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            gernades = gre;
            rockets = roc;
        }
        public Stuff()
        {
            bullets = 1;
            gernades = 1;
            rockets = 1;
        }
    }

    public Stuff myStuff = new Stuff(50, 5, 5);

    
    void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
