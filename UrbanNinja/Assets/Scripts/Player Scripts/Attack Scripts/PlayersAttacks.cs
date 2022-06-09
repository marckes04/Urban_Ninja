using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersAttacks : MonoBehaviour
{
    private Animator anim;

    private string ANIMATION_ATTACK = "Attack";


    void Awake()
    {
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        HandleButtonPresses();
    }

    void HandleButtonPresses()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            anim.SetBool(ANIMATION_ATTACK, true);
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            anim.SetBool(ANIMATION_ATTACK, false);
        }

    }
}