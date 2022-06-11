using System.Collections;
using UnityEngine;

public class PlayersAttacks : MonoBehaviour
{
    public GameObject skillOneEffectPrefab;
    public GameObject skillOneDamagePrefab;

    public Transform skillOne_Point;
    public Transform skillOnePoint_1;
    public Transform skillOnePoint_2;
    public Transform skillOnePoint_3;
    public Transform skillOnePoint_4;
    public Transform skillOnePoint_5;
    public Transform skillOnePoint_6;
    public Transform skillOnePoint_7;
    public Transform skillOnePoint_8;

    public GameObject skillTwo_EffectPrefab;
    public GameObject skillTwo_DamagePrefab;

    public Transform skillTwo_Point;

    public Transform skillTwoPoint_1;
    public Transform skillTwoPoint_2;
    public Transform skillTwoPoint_3;
    public Transform skillTwoPoint_4;
    public Transform skillTwoPoint_5;
    public Transform skillTwoPoint_6;

    public GameObject skillThree_EffectPrefab;

    public Transform skillThreePoint_1;
    public Transform skillThreePoint_2;
    public Transform skillThreePoint_3;
    public Transform skillThreePoint_4;
    public Transform skillThreePoint_5;

    public AudioClip skillOneMusic1;
    public AudioClip skillOneMusic2;
    public AudioClip playerSkillOneSound;
    public AudioClip skillTwoMusic;
    public AudioClip skillThreeMusic;

    private Animator anim;
    private AudioSource audioSource;

    private bool s1_NotUsed;
    private bool s2_NotUsed;
    private bool s3_NotUsed;

    private string ANIMATION_ATTACK = "Attack";
    private string ANIMATION_SKILL_1 = "Skill1";
    private string ANIMATION_SKILL_2 = "Skill2";
    private string ANIMATION_SKILL_3 = "Skill3";




    void Awake()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        s1_NotUsed = true;
        s2_NotUsed = true;
        s3_NotUsed = true;

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

        if (Input.GetKeyDown(KeyCode.J))
        {
            if (s1_NotUsed)
            {
                s1_NotUsed = false;
                anim.SetBool(ANIMATION_SKILL_1, true);
                StartCoroutine(ResetSkills(1));
            }
        }

    }

    // SKILL EFFECTS

    // SKILL ONE
    void SkillOne(bool SkillOne)
    {
        if (SkillOne)
        {
            Instantiate(skillOneEffectPrefab,skillOne_Point.position, 
                skillOne_Point.rotation);
            audioSource.PlayOneShot(skillOneMusic1);
            StartCoroutine(SkillOneCoroutine());
        }
    }

    void SkillOneSound(bool play)
    {
        if (play)
        {
            audioSource.PlayOneShot(playerSkillOneSound);
        }
    }

    void SkillOneEnd(bool skillOneEnd)
    {
        anim.SetBool(ANIMATION_SKILL_1, false);
    }

    IEnumerator SkillOneCoroutine()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(skillOneDamagePrefab, skillOnePoint_1.position, skillOnePoint_1.rotation);
        Instantiate(skillOneDamagePrefab, skillOnePoint_2.position, skillOnePoint_2.rotation);
        Instantiate(skillOneDamagePrefab, skillOnePoint_3.position, skillOnePoint_3.rotation);
        Instantiate(skillOneDamagePrefab, skillOnePoint_4.position, skillOnePoint_4.rotation);
        Instantiate(skillOneDamagePrefab, skillOnePoint_5.position, skillOnePoint_5.rotation);
        Instantiate(skillOneDamagePrefab, skillOnePoint_6.position, skillOnePoint_6.rotation);
        Instantiate(skillOneDamagePrefab, skillOnePoint_7.position, skillOnePoint_7.rotation);
        Instantiate(skillOneDamagePrefab, skillOnePoint_8.position, skillOnePoint_8.rotation);
    }

    IEnumerator ResetSkills(int skill)
    {
        yield return new WaitForSeconds(3f);

        switch (skill)
        {
            case 1:
                s1_NotUsed = true;
                break;
            case 2:
                s2_NotUsed = true;
                break;
            case 3:
                s3_NotUsed = true;
                break;
        }
    }
}
