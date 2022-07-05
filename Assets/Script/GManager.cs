using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    private GameObject player;
    private GameObject[] enemy;

    public GameObject panel;
    public GameObject panel2;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        panel2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("PlayerCollisionBody");
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemy.Length == 0)
        {
            panel.SetActive(true);
        }

        if (player.GetComponent<Player>().playerHp <= 0)
        {
            panel2.SetActive(true);
        }
    }

}
