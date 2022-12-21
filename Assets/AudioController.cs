using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource audioSource;

    public AudioClip Audio_Jump;
    public AudioClip Audio_Attack;
    public AudioClip Audio_PlayerDamaged;
    public AudioClip Audio_LevelUp;
    public AudioClip Audio_Die;
    public AudioClip Audio_Finish;
    public AudioClip Audio_Potion;
    public AudioClip Audio_Teleport;
    public AudioClip Audio_CoinDrop;
    public AudioClip Audio_BossAwake;
    public AudioClip Audio_ObjectOpen;
    public AudioClip Audio_RockBreak;
    public AudioClip Audio_ObjectBreak;





    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlaySound(string action)
    {
        switch (action)
        {
            case "JUMP": // using
                audioSource.clip = Audio_Jump;
                break;
            case "ATTACK": 
                audioSource.clip = Audio_Attack;
                break;
            case "PLAYERDAMAGED": // using
                audioSource.clip = Audio_PlayerDamaged;
                break;
            case "LEVELUP": // using
                audioSource.clip = Audio_LevelUp;
                break;
            case "DIE": //using
                audioSource.clip = Audio_Die;
                break;
            case "FINISH":
                audioSource.clip = Audio_Finish;
                break;
            case "POTION": // using 소리가 좀 작음
                audioSource.clip = Audio_Potion;
                break;
            case "TELEPORT": // using 소리가 좀 작음
                audioSource.clip = Audio_Teleport;
                break;
            case "COINDROP":
                audioSource.clip = Audio_CoinDrop;
                break;
            case "BOSSAWAKE": // 221221 seongik
                audioSource.clip = Audio_BossAwake;
                break;
            case "OBJOPEN": // 221221 seongik
                audioSource.clip = Audio_ObjectOpen;
                break;
            case "ROCKBREAK": // 221221 seongik using
                audioSource.clip = Audio_RockBreak;
                break;
            case "OBJBREAK": // 221221 seongik 
                audioSource.clip = Audio_ObjectBreak;
                break;            
        }
        audioSource.Play();

    }
}
