using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDoor : MonoBehaviour
{
    [SerializeField] private Fire.FireType fireType;

    private Animator animator;
    private bool isOpen = false;
    public GameObject FireFreazenPlus;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        FireFreazenPlus.SetActive(false);
    }

    public Fire.FireType GetFireType()
    {
        return fireType;
    }

    public void OpenDoor()
    {
        isOpen = true;
        animator.SetBool("FireBonfire", true);
        FireFreazenPlus.SetActive(true);
    }

}