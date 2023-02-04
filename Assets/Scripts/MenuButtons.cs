using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public string Levelstoload="SampleScene";

    public void loadScene(){

        SceneManager.LoadScene(Levelstoload);

    }

    public void exitGame(){

        Application.Quit();

    }

}
