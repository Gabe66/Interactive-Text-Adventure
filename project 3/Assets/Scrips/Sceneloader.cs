using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{



    public void LoadNextScene()
    {

        int currentSceneIndex = Sceneloader.GetActiveScene().buildIndex;
        Sceneloader.LoadScene(currentSceneIndex + 1);
    }

    public void loadStartScene()
    {
        Sceneloader.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }
 
 



 


}
