using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] float interactRange = 5f;
    [SerializeField] LayerMask interactLayer;
    private HashSet<GameObject> affectedObjects = new HashSet<GameObject>();

    void Update()
    {
        //Physics.CheckSphere(transform.position, interactRange, 1);
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, interactRange, interactLayer);
        HashSet<GameObject> currentObjects = new HashSet<GameObject>();
        
        //foreach (Collider collider in hitColliders)
        //{
        //    if (Vector3.Distance(transform.position, collider.transform.position) < interactRange) {

        //    }
        //    Interactable inter = collider.gameObject.GetComponent<Interactable>();
        //    if (inter != null) {
        //        inter.inRange = true;
        //    }
        //}

        foreach (Collider col in hitColliders)
        {
            GameObject obj = col.gameObject;
            currentObjects.Add(obj);

            if (!affectedObjects.Contains(obj))
            {
                ApplyEffect(obj);
            }
        }
        foreach (GameObject obj in new HashSet<GameObject>(affectedObjects))
        {
            if (!currentObjects.Contains(obj))
            {
                RevertEffect(obj);
            }
        }

        affectedObjects = currentObjects;
    }
    void ApplyEffect(GameObject obj)
    {
        OutlineHolder oH = obj.GetComponent<OutlineHolder>();
        if (oH != null)
        {
            oH.Activate();
            obj.GetComponent<Interactable>().inRange = true;
        }
    }

    void RevertEffect(GameObject obj)
    {
        OutlineHolder oH = obj.GetComponent<OutlineHolder>();
        if (oH != null)
        {
            oH.Deactivate();
            obj.GetComponent<Interactable>().inRange = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>() != null)
        {
            other.GetComponent<Coin>().Collect();
        }
        if (other.GetComponent<Gem>() != null)
        {
            other.GetComponent<Gem>().Collect();
        }

    }
}