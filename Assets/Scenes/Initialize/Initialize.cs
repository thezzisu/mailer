using UnityEngine;

public class Initialize : MonoBehaviour
{
  void Start()
  {
    Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
    GlobalManagement.manager.LoadScene("Title");
  }
}
