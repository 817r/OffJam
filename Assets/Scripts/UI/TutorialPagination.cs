using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TutorialPagination : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> pages;
    [SerializeField]
    private GameObject ButtonNext;
    [SerializeField]
    private GameObject ButtonPrevious;

    private int currentPage = 0;
    private Button next;
    private Button prev;

    void Awake()
    {
        for (int i = 0; i < pages.Count; i++)
        {
            pages[i].SetActive(i == currentPage);
        }

        ButtonNext.SetActive(currentPage != 0);
        ButtonPrevious.SetActive(currentPage != pages.Count);
    }

    private void RefreshPage()
    {
        for (int i = 0; i < pages.Count; i++)
        {
            pages[i].SetActive(i == currentPage);
        }

        ButtonNext.SetActive(currentPage != 0);
        ButtonPrevious.SetActive(currentPage != pages.Count - 1);
    }

    public void NextPage()
    {
        currentPage++;
        RefreshPage();
    }

    public void PrevPage()
    {
        currentPage--;
        RefreshPage();
    }

    public void ResetPage()
    {
        currentPage = 0;
        RefreshPage();
    }
}
