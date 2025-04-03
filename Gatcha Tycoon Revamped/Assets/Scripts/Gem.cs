using UnityEngine;

public class Gem : MonoBehaviour
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
        GameManager.AddGem();
        gameObject.SetActive(false);
    }
    public void Magnet()
    {
        rb.AddForce(player.position - transform.position, ForceMode.Acceleration);
    }
}
