using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum LevelStatus
{
    Normal,
    Checked,
    Locked,
    Unselected
}

public class LevelButton : MonoBehaviour
{
    [SerializeField]
    private string Level;
    [SerializeField]
    private LevelStatus status;
    [SerializeField]
    private List<GameObject> buttons;

    private LevelInfo li;
    private bool Unlocked;
    private bool Finished;
    private bool Unselected;

    // Start is called before the first frame update
    void Start()
    {
        //ButtonObject = Button.GetComponent<Button>();
        //ButtonImage = Button.GetComponent<Image>();
        li = GameObject.Find("Menu/LevelSelect/LevelInfo").GetComponent<LevelInfo>();
        ApplyState();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeState(LevelStatus status)
    {
        this.status = status;
        ApplyState();
    }
    
    public LevelStatus GetLevelStatus()
    {
        return status;
    }

    public string GetLevel()
    {
        return Level;
    }

    public void LoadLevel()
    {
        li.LoadLevel(Level);
    }

    private void ApplyState()
    {
        int buttonStatus = 0;

        switch(status)
        {
            case LevelStatus.Normal:
                buttonStatus = 0;
                break;
            case LevelStatus.Checked:
                buttonStatus = 1;
                break;
            case LevelStatus.Locked:
                buttonStatus = 2;
                break;
            case LevelStatus.Unselected:
                buttonStatus = 3;
                break;
        }

        for (int i = 0; i < buttons.Count; ++i)
        {
            buttons[i].SetActive(i == buttonStatus);
        }
    } 
}
