using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticClass : MonoBehaviour
{
    
    public static StaticClass GM;

    public float Gamestage = 10;
    public GameObject[] playerCharArray;
    public int PCharArrayLength = 3;


    void Awake()
    {
        if (GM != null)
            GameObject.Destroy(GM);
        else
            GM = this;
        DontDestroyOnLoad(this);

        playerCharArray = new GameObject[PCharArrayLength];

    }
    void Update()
    {
       // Debug.Log(Gamestage);
    }



}
   
