using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var target = GlobalManagement.manager.SceneToLoad ?? "Title";
        UnityEngine.SceneManagement.SceneManager.LoadScene(target);
    }
}
