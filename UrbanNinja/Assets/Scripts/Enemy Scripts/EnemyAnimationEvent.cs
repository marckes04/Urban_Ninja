using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationEvent : MonoBehaviour
{
    public GameObject attackPointOne;
    public GameObject attackpointTwo;
    public GameObject EnemyAttackEffect;

    void EnemyAttackOne(bool attacking)
    {
        if(attacking)
        {
            Instantiate(EnemyAttackEffect, attackPointOne.transform.position,
                attackPointOne.transform.rotation);
        }
    }

    void EnemyAttackTwo(bool attacking)
    {
        if (attacking)
        {
            Instantiate(EnemyAttackEffect, attackpointTwo.transform.position,
                attackpointTwo.transform.rotation);
        }
    }

    void EnemyAttackOneStar(bool attackstarted)
    {
        if (attackstarted)
        {
            attackPointOne.SetActive(true);
        }
    }

    void EnemyAttackOneEnd(bool attackEnd)
    {
        if (attackEnd)
        {
            attackPointOne.SetActive(false);
        }
    }

    void EnemyAttackTwoStar(bool attackstarted)
    {
        if (attackstarted)
        {
            attackpointTwo.SetActive(true);
        }
    }

    void EnemyAttackTwoEnd(bool attackEnd)
    {
        if (attackEnd)
        {
            attackpointTwo.SetActive(false);
        }
    }



}
