using UnityEngine;
using System.Collections;

public class deathMenu : MonoBehaviour {

    public string menuScreen;

    public void restart()
    {

    }

    public void quitToMenu()
    {
        Application.LoadLevel(menuScreen);
    }
    
}
