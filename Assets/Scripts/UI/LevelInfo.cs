using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelInfo : MonoBehaviour
{
    private Animator animator;
    private TMP_Text LevelTxt;
    private TMP_Text EnemyTxt;
    private string LvlName;
    private int EnemyCount;

    void Awake()
    {
        animator = GetComponent<Animator>();
        LevelTxt = transform.Find("LabelLevel").GetComponent<TMP_Text>();
        EnemyTxt = transform.Find("Enemies/Enemy/E_Amt").GetComponent<TMP_Text>();
        gameObject.SetActive(false);
    }

    public void LoadLevel(string Lvl)
    {
        //kode untuk load level data di sini (level sama enemy count)

        LvlName = Lvl;
        EnemyCount = 2;

        LevelTxt.text = "Level " + Lvl;
        EnemyTxt.text = EnemyCount + "";

        gameObject.SetActive(true);
        animator.Play("LevelInfoOpen");
    }

    public void PlayLevel()
    {
        Debug.LogFormat("Playing {0}", LvlName);

        //kode untuk load level di sini
    }

    public void CloseInfo()
    {
        StartCoroutine("CloseAnimation");
    }

    public void ForceClose()
    {
        gameObject.SetActive(false);
    }

    IEnumerator CloseAnimation()
    {
        animator.Play("LevelInfoClose");

        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        gameObject.SetActive(false);
        StopCoroutine("CloseAnimation");
    }
}
