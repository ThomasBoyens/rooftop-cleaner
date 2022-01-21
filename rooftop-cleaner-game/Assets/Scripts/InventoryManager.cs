using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public Text inventoryText;

    private int remainingTrees = 15;

    private void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        inventoryText.text = remainingTrees.ToString();
    }

    public void SubtractPoint()
    {
        remainingTrees -= 1;
        inventoryText.text = remainingTrees.ToString();
    }
}
