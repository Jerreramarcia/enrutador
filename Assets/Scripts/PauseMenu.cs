using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
        public string Levelstoload = "MainMenu";

    public void loadScene(){

        SceneManager.LoadScene(Levelstoload);

    }
}
