using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatchUpgrade : MonoBehaviour
{
    //[SerializeField] GameObject machine;

    //[SerializeField] float chanceUp1, chanceUp2, chanceUp3, chanceUp4;
    ////[SerializeField] int dropUp1, dropUp2, dropUp3, dropUp4;
    //[SerializeField] float chanceUp5, chanceUp6, chanceUp7, chanceUp8;
    ////[SerializeField] int dropUp5, dropUp6, dropUp7, dropUp8;
    //[Space(10)]
    //[SerializeField] float dropMultiply1;
    //[Space(10)]
    //[SerializeField] int dropMultiply2;

    //private bool canInteract = true;
    //private GatchaMachine gatchaScript;

    //public bool Interact()
    //{
    //    if (canInteract)
    //    {
    //        gatchaScript = machine.GetComponent<GatchaMachine>();

    //        // Checks the current level of the gatcha machine. If it can level up then it will call the allocated upgrade function
    //        switch (gatchaScript.level)
    //        {
    //            case 1:
    //                Upgrade1();
    //                break;
    //            case 2:
    //                Upgrade2();
    //                break;
    //            default:
    //                print("Error - Cannot upgrade");
    //                break;
    //        }
    //        return true;
    //    }
    //    return false;
    //}

    //private void Upgrade1()
    //{
    //    gatchaScript.chance1 = chanceUp1; gatchaScript.chance2 = chanceUp2; gatchaScript.chance3 = chanceUp3; gatchaScript.chance4 = chanceUp4;
    //    //gatchaScript.dropNum1 = dropUp1; gatchaScript.dropNum2 = dropUp2; gatchaScript.dropNum3 = dropUp3; gatchaScript.dropNum4 = dropUp4;
    //    gatchaScript.dropNum1 = Mathf.RoundToInt(gatchaScript.dropNum1 * dropMultiply1);
    //    gatchaScript.dropNum2 = Mathf.RoundToInt(gatchaScript.dropNum2 * dropMultiply1);
    //    gatchaScript.dropNum3 = Mathf.RoundToInt(gatchaScript.dropNum3 * dropMultiply1);
    //    gatchaScript.dropNum4 = Mathf.RoundToInt(gatchaScript.dropNum4 * dropMultiply1);
    //    gatchaScript.level++;
    //}

    //private void Upgrade2()
    //{
    //    gatchaScript.chance1 = chanceUp5; gatchaScript.chance2 = chanceUp6; gatchaScript.chance3 = chanceUp7; gatchaScript.chance4 = chanceUp8;
    //    //gatchaScript.dropNum1 = dropUp5; gatchaScript.dropNum2 = dropUp6; gatchaScript.dropNum3 = dropUp7; gatchaScript.dropNum4 = dropUp8;
    //    gatchaScript.dropNum1 = gatchaScript.dropNum1 * dropMultiply2;
    //    gatchaScript.dropNum2 = gatchaScript.dropNum2 * dropMultiply2;
    //    gatchaScript.dropNum3 = gatchaScript.dropNum3 * dropMultiply2;
    //    gatchaScript.dropNum4 = gatchaScript.dropNum4 * dropMultiply2;
    //    gatchaScript.level++;
    //}
}