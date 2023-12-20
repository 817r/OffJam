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

    private int currentPage;
    private int lastPage;

    void Awake()
    {
        ResetPage();

        ButtonNext.SetActive(currentPage != 0);
        ButtonPrevious.SetActive(currentPage != pages.Count);
    }

    private void Update()
    {
        if (lastPage != currentPage)
        {
            lastPage = currentPage;
            RefreshPage();
        }
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
    }

    public void PrevPage()
    {
        currentPage--;
    }

    public void ResetPage()
    {
        currentPage = 0;
    }
}
