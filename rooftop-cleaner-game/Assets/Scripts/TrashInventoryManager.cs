using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;
public class TrashInventoryManager : MonoBehaviour
{
    public static TrashInventoryManager instance;
    public Text ScoreText;
    public int Score { get; private set; } = 0;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = Score.ToString() + "/25";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void AddPoint()
    {
        instance.Score += 1;
        ScoreText.text = Score.ToString() + "/25";
    }
}
