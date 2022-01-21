using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerInvent1 : MonoBehaviour
{
    public static HammerInvent1 instance;
    public Text ScoreText;
    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString() + "/1";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoint()
    {
        score += 1;
        ScoreText.text = score.ToString() + "/1";
    }
}
