using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarPanelInvent : MonoBehaviour
{

    public static SolarPanelInvent instance;
    public Text ScoreText;
    public int score { get; private set; } = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString() + "/7";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score += 1;
        ScoreText.text = score.ToString() + "/7";
    }
}
