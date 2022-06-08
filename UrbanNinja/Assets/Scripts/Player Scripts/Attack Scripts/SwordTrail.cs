using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTrail : MonoBehaviour
{
    private MeleeWeaponTrail weaponTrail;
    private Transform Sword;

    public GameObject hitPoint;
    public GameObject slashThreeEffectPrefab;
    public Transform slashThreePoint;

    private AudioSource audioSource;

    public AudioClip swordHit1;
    public AudioClip swordHit2;
    public AudioClip earthHitMusic;
    public AudioClip jiaoHangSheng;

    void Awake()
    {
        Sword = GameObject.Find("Sword").transform;
        weaponTrail = Sword.gameObject.GetComponent<MeleeWeaponTrail>();
        audioSource = GetComponent<AudioSource>();
    }

    void SlashOneWeaponTrailStart(bool show)
    {
        if (show)
        {
            weaponTrail.Emit = true;
            hitPoint.SetActive(true);
            audioSource.PlayOneShot(swordHit1);
        }
    }

    void SlashOneWeaponTrailEnd(bool end)
    {
        if (end)
        {
            weaponTrail.Emit = false;
            hitPoint.SetActive(false);
        }
    }

    void SlashTwoWeaponTrailStart(bool show)
    {
        if (show)
        {
            weaponTrail.Emit = true;
            hitPoint.SetActive(true);
            audioSource.PlayOneShot(swordHit2);
        }
    }

    void SlashTwoWeaponTrailEnd(bool end)
    {
        if (end)
        {
            weaponTrail.Emit = false;
            hitPoint.SetActive(false);
        }
    }

    void SlashThreeWeaponTrailStart(bool show)
    {
        if (show)
        {
            weaponTrail.Emit = true;
            hitPoint.SetActive(true);
            audioSource.PlayOneShot(jiaoHangSheng);
        }
    }

    void SlashThreeWeaponTrailEnd(bool end)
    {
        if (end)
        {
            weaponTrail.Emit = false;
            hitPoint.SetActive(false);
        }
    }

    void SlashThreeEffect(bool show)
    {
        if (show)
        {
            Instantiate(slashThreeEffectPrefab, slashThreePoint.position,
                slashThreePoint.transform.rotation);
            audioSource.PlayOneShot(earthHitMusic);
        }
    }

}
