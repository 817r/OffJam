using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuControl : MonoBehaviour
{
    private Animator animator;
    public void Awake()
    {
        animator = GetComponent<Animator>();
        gameObject.SetActive(false);
    }

    public void EnablePause()
    {
        //kode untuk pause game di sini
        //GameManager.PauseGame();

        gameObject.SetActive(true);
        animator.Play("PauseOpen");
    }

    //function sementara, nanti yg manage GameManager
    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResumeGame()
    {
        StartCoroutine("ClosePauseMenu");
    }

    IEnumerator ClosePauseMenu()
    {
        animator.Play("PauseClose");

        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        //kode untuk pause game di sini
        //GameManager.ResumeGame();
        
        gameObject.SetActive(false);
        StopCoroutine("ClosePauseMenu");
    }
}
