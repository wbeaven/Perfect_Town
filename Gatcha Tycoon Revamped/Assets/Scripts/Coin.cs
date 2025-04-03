using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    Transform player;
    Rigidbody rb;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Magnet();
    }

    public void Collect()
    {
        GameManager.AddCoin();
        gameObject.SetActive(false);
    }
    public void Magnet()
    {
        rb.AddForce(player.position - transform.position, ForceMode.Acceleration);
    }
}
