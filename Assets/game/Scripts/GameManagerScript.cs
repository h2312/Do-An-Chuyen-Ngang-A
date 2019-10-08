using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int cur_coins = 0;
    public int max_coin = 0;

    public Text coinLeft;

    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        Door.SetActive(false);
        max_coin = cur_coins;
        UpdateUI();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateUI()
    {
        if (cur_coins > 0)
        {
            coinLeft.text = "Coin Left: " + cur_coins + "/" + max_coin;
        }
        else if (cur_coins <= 0)
        {
            Door.SetActive(true);
        }
        
        
    }
}
