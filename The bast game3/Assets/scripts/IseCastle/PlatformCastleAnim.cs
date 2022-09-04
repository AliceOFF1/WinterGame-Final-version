using System.Collections.Generic;
using UnityEngine;

public class PlatformCastleAnim : MonoBehaviour, IDoor
{

    private Animator animator;
    private bool isOpen = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        isOpen = true;
        animator.SetBool("PlatformCastle", true);
    }

    public void CloseDoor()
    {
        isOpen = false;
        animator.SetBool("PlatformCastle", false);

    }

    public void ToggleDoor()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }
    }

}
