using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    //[SerializeField] int bossHealthMax, bossHealthCurrent, bossDamage;
    //[SerializeField] float bossAtkSpd, startDelay;
    
    //private Party party;

    //void Start()
    //{
    //    party = GameObject.Find("Party Manager").GetComponent<Party>();
    //}

    //void Update()
    //{
    //    foreach (GameObject member in party.members)
    //    {
    //        print(member);
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        foreach (GameObject member in party.members)
    //        {
    //            if (member != null)
    //                member.GetComponent<Minion>().currentBoss = this;
    //        }

    //        StartCoroutine(FightDelay());
    //        print("Player has entered boss arena");
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        foreach (GameObject member in party.members)
    //        {
    //            if (member != null)
    //            {
    //                member.GetComponent<Minion>().ResetHealth();
    //                member.GetComponent<Minion>().currentBoss = null;
    //            }
    //        }

    //        ResetHealth();
    //        print("Player has left boss arena");
    //    }
    //}

    //public void TakeDamage(int incomingDmg)
    //{
    //    if (bossHealthCurrent > 0)
    //        bossHealthCurrent -= incomingDmg;
    //    print("Boss has taken damage");
    //}

    //private void ResetHealth()
    //{
    //    bossHealthCurrent = bossHealthMax;
    //    print("Boss health is reset");

    //}

    //private void BossAttack()
    //{
    //    foreach (GameObject member in party.members)
    //    {
    //        if (member != null)
    //            member.GetComponent<Minion>().TakeDamage(bossDamage);
    //    }

    //    StartCoroutine(AttackTimer());
    //    print("Boss has attacked");
    //}

    //private IEnumerator FightDelay()
    //{
    //    yield return new WaitForSeconds(startDelay);
    //    BossAttack();

    //    foreach (GameObject member in party.members)
    //    {
    //        if (member != null)
    //        {
    //            member.GetComponent<Minion>().MinionAttack();
    //        }
    //    }
    //}

    //private IEnumerator AttackTimer()
    //{
    //    yield return new WaitForSeconds(bossAtkSpd);
    //    BossAttack();
    //}
}