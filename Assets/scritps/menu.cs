using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

    public string playLevel;
    public string infoPage;
    public string menuPage;

    public void startGame()
    {
        Application.LoadLevel(playLevel);
    }

    public void info()
    {
        Application.LoadLevel(infoPage);
    }

    public void menuNav()
        {
            Application.LoadLevel(menuPage);
        }

    public void quit()
    {
        Application.Quit();
    }

}
