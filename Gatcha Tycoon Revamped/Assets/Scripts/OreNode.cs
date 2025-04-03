using System.Collections;
using UnityEngine;

public class OreNode : MonoBehaviour
{
    [SerializeField] Transform[] orePieces;
    [SerializeField] Rigidbody[] oreRB;
    [SerializeField] BoxCollider[] oreBC;
    [SerializeField] float progressPerClick = 10f, respawnTime = 3f;

    private float progress = 0f;
    private bool mineable = true;

    void Start()
    {
        SpawnOre();
    }

    private void SpawnOre()
    {
        mineable = true;
        foreach (Transform ore in orePieces)
        {
            ore.localPosition = new Vector3(Random.Range(-0.2f, 0.2f), ore.position.y, Random.Range(-0.2f, 0.2f));
            ore.rotation = Random.rotation;
        }
        foreach (Rigidbody i in oreRB)
        {
            i.isKinematic = true;
        }
        foreach (BoxCollider i in oreBC)
        {
            i.enabled = false;
        }
    }

    public void MineOre()
    {
        if (mineable)
            progress += progressPerClick;
        if (progress >= 100f)
        {
            progress = 0f;
            Finished();
        }
    }

    private void Finished()
    {
        mineable = false;
        foreach (Rigidbody i in oreRB)
        {
            i.isKinematic = false;
        }
        foreach (BoxCollider i in oreBC)
        {
            i.enabled = true;
        }
        StartCoroutine(RespawnTimer());
    }

    private IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(respawnTime);
        SpawnOre();
    }
}
