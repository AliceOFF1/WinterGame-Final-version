using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHinge : MonoBehaviour, IDoorHinge
{
    private HingeJoint2D hingeJoint2D;
    private JointAngleLimits2D openDoorLimits;
    private JointAngleLimits2D closeDoorLimits;
    private bool isOpen = false;

    private void Awake()
    {
        hingeJoint2D = transform.Find("CastleMouveingPlatform").GetComponent<HingeJoint2D>();
        openDoorLimits = hingeJoint2D.limits;
        closeDoorLimits = new JointAngleLimits2D { min = 90f, max = -90f };
        CloseDoorHinge();
    }

    public void OpenDoorHinge()
    {

        hingeJoint2D.limits = openDoorLimits;
    }

    public void CloseDoorHinge()
    {

        hingeJoint2D.limits = closeDoorLimits;
    }

}
