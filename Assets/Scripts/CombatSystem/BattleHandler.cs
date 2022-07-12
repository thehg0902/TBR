using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    
    public Transform Spot1;
    public Transform Spot2;
    public Transform Spot3;
    public GameObject selector;



    void Start()
    {
        selector= Resources.Load("LoadablePrefabs/Green", typeof(GameObject)) as GameObject;
        Instantiate(StaticClass.GM.playerCharArray[0], Spot1.transform.position, Quaternion.identity);
        Instantiate(StaticClass.GM.playerCharArray[1], Spot2.transform.position, Quaternion.identity);
        Instantiate(StaticClass.GM.playerCharArray[2], Spot3.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
