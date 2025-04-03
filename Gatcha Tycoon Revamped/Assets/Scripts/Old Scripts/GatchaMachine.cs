using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class GatchaMachine : MonoBehaviour
{
    // The machine needs to be interacted with, pick an option from a list with different probabilities, and spawn the correlating object for the player to pick up
    //[SerializeField] private GameObject drop1, drop2, drop3, drop4;
    //public float chance1, chance2, chance3, chance4;
    //public int dropNum1, dropNum2, dropNum3, dropNum4;
    //[Space(10)]
    //public int cost;
    //[Space(10)]
    //public int level;

    //private int reward;
    //private RagdollSpawner ragdollSpawner;

    //private void Start()
    //{
    //    ragdollSpawner = GetComponent<RagdollSpawner>();
    //}

    //public bool Interact()
    //{
    //    if (GameManager.coinTotal >= cost)
    //    {
    //        // Start spinning animation or whatever
    //        GameManager.RemoveCoin(cost);
    //        StartCoroutine(ProbabilityPick());
    //        return true;
    //    }
    //    return false;
    //}

    //private IEnumerator ProbabilityPick()
    //{
    //    yield return new WaitForSeconds(1);

    //    // Pick a reward based on the probability set in inspector and set reward to corresponding case
    //    float randomNum = Random.Range(0f, 100f);
    //    if (randomNum <= chance1)
    //        reward = 1;
    //    else if (randomNum > chance1 && randomNum <= (chance1 + chance2))
    //        reward = 2;
    //    else if (randomNum > (chance1 + chance2) && randomNum <= (chance1 + chance2 + chance3))
    //        reward = 3;
    //    else if (randomNum > (chance1 + chance2 + chance3))
    //        reward = 4;
    //    else
    //        print("Error - Something went wrong with the probability picking");

    //    print("reward number " + reward);
    //    GiveReward();
    //}

    //private void GiveReward()
    //{
    //    // Spawn a reward based on what was determined
    //    switch (reward)
    //    {
    //        case 1:
    //            for (int i = 0; i < dropNum1; i++)
    //            {
    //                Instantiate(drop1);
    //            }
    //            break;
    //        case 2:
    //            for (int i = 0; i < dropNum2; i++)
    //            {
    //                Instantiate(drop2);
    //            }
    //            break;
    //        case 3:
    //            for (int i = 0; i < dropNum3; i++)
    //            {
    //                Instantiate(drop3);
    //            }
    //            break;
    //        case 4:
    //            // Spawn the big prize
    //            //for (int i = 0; i < dropNum4; i++)
    //            //{
    //            //    Instantiate(drop4);
    //            //}
    //            ragdollSpawner.Spawn();
    //            break;
    //        default:
    //            print("Error - Reward not given");
    //            break;
    //    }
    //}
}