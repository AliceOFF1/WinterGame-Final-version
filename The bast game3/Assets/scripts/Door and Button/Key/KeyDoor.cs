using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private Key.KeyType keyType;

    private Animator animator;
    private bool isOpen = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public Key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenDoor()
    {
        isOpen = true;
        animator.SetBool("OpenFoor", true);
    }

}
