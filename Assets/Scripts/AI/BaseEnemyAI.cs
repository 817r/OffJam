using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyAI : MonoBehaviour
{
    public List<CardDatabase> deck = new List<CardDatabase>();
    public List<CardDatabase> container = new List<CardDatabase>();


    public GameObject inHand;
    public GameObject playGround;
    public GameObject discarded;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
