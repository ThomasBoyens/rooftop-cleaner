using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;
public class TrashInventoryManager : MonoBehaviour
{
    public static TrashInventoryManager instance;
    public Text ScorText;
    private int score = 0;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScorText.text = score.ToString() + "/10 Trash Collected";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score += 1;
        ScorText.text = score.ToString() + "/10 Trash Collected";
    }
}
