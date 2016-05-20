using UnityEngine;
using System.Collections;

public class deathMenu : MonoBehaviour {

    public string menuScreen;

    public void restart()
    {
        FindObjectOfType<GameController>().resetGame();
    }

    public void quitToMenu()
    {
        Application.LoadLevel(menuScreen);
    }
    
}
