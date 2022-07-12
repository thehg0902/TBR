using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{

    private int maxCharCount = 2;
    bool active = false;
    float charNum;

    void Awake()
    {
        
    }
    // Resources.Load("LoadablePrefabs/Green", typeof(GameObject)) as GameObject;
    private void Update()
    {
        Debug.Log(maxCharCount);
    }

    public void selectCharacter(int CharID)
    {
        if (maxCharCount >= 0)
        {
           
                switch (CharID)
                {
                    case 0:
                    
                    StaticClass.GM.playerCharArray[maxCharCount] = Resources.Load("LoadablePrefabs/Green", typeof(GameObject)) as GameObject;
                    maxCharCount--;
                    break;

                    case 1:
                    StaticClass.GM.playerCharArray[maxCharCount] = Resources.Load("LoadablePrefabs/Red", typeof(GameObject)) as GameObject;
                    maxCharCount--;
                    break;

                    case 2:
                    StaticClass.GM.playerCharArray[maxCharCount] = Resources.Load("LoadablePrefabs/Purple", typeof(GameObject)) as GameObject;
                    maxCharCount--;
                    break;

                    case 3:
                    StaticClass.GM.playerCharArray[maxCharCount] = Resources.Load("LoadablePrefabs/Yellow", typeof(GameObject)) as GameObject;
                    maxCharCount--;
                    break;
            }

            Debug.Log("Select Character");
            
        }
        else { Debug.Log("EnoughCharacters"); }
    }
   


}
