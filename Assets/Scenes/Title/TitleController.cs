using UnityEngine;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
  public Button NewGameBtn, LoadGameBtn, ExitGameBtn, SettingsBtn;

  void Start()
  {
    var newGameBtn = GameObject.Find("b_new").GetComponent<Button>();
    NewGameBtn.onClick.AddListener(() =>
    {
      System.Console.WriteLine("New Game");
    });
    LoadGameBtn.onClick.AddListener(() =>
    {
      GlobalManagement.manager.LoadScene("GameLoad");
    });
    ExitGameBtn.onClick.AddListener(() =>
    {
      Application.Quit();
    });
    SettingsBtn.onClick.AddListener(() =>
    {
      GlobalManagement.manager.LoadScene("Settings");
    });
  }
}
