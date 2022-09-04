using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodDoor : MonoBehaviour
{
    [SerializeField] private Wood.WoodType woodType;

    private Animator animator;
    private bool isOpen = false;

    public GameObject SmokeTube;
    public GameObject FreazenPlus;

    public GameObject ComputerTriggerDialog;
    public GameObject ComputerE;
    public GameObject ComputerMesage;

    public GameObject StoveTriggerDialog;
    public GameObject StoveMessage;
    public GameObject StoveE;

    public GameObject BlockExit;



    private void Awake()
    {
        animator = GetComponent<Animator>();
        SmokeTube.SetActive(false);
        FreazenPlus.SetActive(false);
    }

    public void Start()
    {
        ComputerTriggerDialog.SetActive(false);
        ComputerE.SetActive(false);
        ComputerMesage.SetActive(false);
        BlockExit.SetActive(false);
    }

    public Wood.WoodType GetWoodType()
    {
        return woodType;
    }

    public void OpenDoor()
    {
        isOpen = true;
        animator.SetBool("Stove", true);
        SmokeTube.SetActive(true);
        FreazenPlus.SetActive(true);
        ComputerTriggerDialog.SetActive(true);
        ComputerE.SetActive(true);
        ComputerMesage.SetActive(true);
        StoveTriggerDialog.SetActive(false);
        StoveMessage.SetActive(false);
        StoveE.SetActive(false);
        BlockExit.SetActive(true);


    }

}
