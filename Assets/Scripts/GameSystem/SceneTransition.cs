using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int SceneIndex;

    // Update is called once per frame
    void Update()
    {
       
    }
    
    public void NextScene()
    {
        SceneManager.LoadScene(SceneIndex);
    }

}
