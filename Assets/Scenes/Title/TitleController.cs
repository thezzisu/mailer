using UnityEngine;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
  void Start()
  {
    var newGameBtn = GameObject.Find("b_new").GetComponent<Button>();
    newGameBtn.onClick.AddListener(() =>
    {
      System.Console.WriteLine("New Game");
    });
    var loadGameBtn = GameObject.Find("b_load").GetComponent<Button>();
    loadGameBtn.onClick.AddListener(() =>
    {
      GlobalManagement.manager.LoadScene("GameLoad");
    });
    var exitGameBtn = GameObject.Find("b_exit").GetComponent<Button>();
    exitGameBtn.onClick.AddListener(() =>
    {
      Application.Quit();
    });
    var settingsBtn = GameObject.Find("b_settings").GetComponent<Button>();
    settingsBtn.onClick.AddListener(() =>
    {
      GlobalManagement.manager.LoadScene("Settings");
    });
  }
}
