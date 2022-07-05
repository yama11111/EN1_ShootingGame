using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int playerHp = 100;

    public Text playerHpText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerHpText.text = "HP : " + playerHp;

        if (playerHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void Damage()
    {
        playerHp = playerHp - 1;
        Debug.Log(playerHp);
    }
}
