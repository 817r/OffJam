using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour
{
    [SerializeField] private GameObject[] fills;
    [SerializeField][Range(0, 16)] private int amount = 10;
    private int lastAmount;

    void Start()
    {
        lastAmount = amount;
        RefreshBar();
    }

    void Update()
    {
        if (amount != lastAmount)
        {
            lastAmount = amount;
            RefreshBar();
        }   
    }

    public void SetDisplayEnergyBarAmount(int amount)
    {
        this.amount = amount;
    }

    private void RefreshBar()
    {
        for (int i = 0; i < fills.Length; i++)
        {
            fills[i].SetActive(i + 1 <= amount);
        }
    }
}
