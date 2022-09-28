using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManagement
{
    public static GlobalManagement manager = new GlobalManagement();

    public string SceneToLoad;
    private GlobalManagement() { }

    public void LoadScene(string name)
    {
        SceneToLoad = name;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Loader");
    }
}
