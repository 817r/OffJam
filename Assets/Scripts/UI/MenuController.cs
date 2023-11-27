using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class MenuController : MonoBehaviour
{
    [System.Serializable]
    public class MenuScreen
    {
        public string screenName;
        public GameObject screenObject;
    }

    [SerializeField]
    private MenuScreen[] screens;

    private void Start()
    {
        foreach(var s in screens)
        {
            s.screenObject.SetActive(s.screenName == "main");
        }
    }

    public void ChangeScreen(string menu)
    {
        foreach(var s in screens)
        {
            s.screenObject.SetActive(s.screenName == menu);
        }
    }

    public void DisplayPopup()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public bool GetScreenStatus(string menu)
    {
        MenuScreen sn = screens.FirstOrDefault(s => s.screenName == menu);
        return sn.screenObject.activeSelf;
    }
}
