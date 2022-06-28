using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerAttackButton: MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private PlayersAttacks playerAttack;

    void Awake()
    {
        playerAttack = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayersAttacks>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        if(gameObject.name == "AttackButton")
        {
            playerAttack.AttackButtonPressed();
        }
    }
    public void OnPointerUp(PointerEventData data)
    {
        if (gameObject.name == "AttackButton")
        {
            playerAttack.AttackButtonReleased();
        }
    }
}
