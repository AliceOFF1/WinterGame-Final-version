using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHolder : MonoBehaviour
{
    public event EventHandler OnFiresChanged;
    private List<Fire.FireType> fireList;

    private void Awake()
    {
        fireList = new List<Fire.FireType>();
    }

    public List<Fire.FireType> GetFireList()
    {
        return fireList;
    }

    public void AddFire(Fire.FireType fireType)
    {
        fireList.Add(fireType);
        OnFiresChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveFire(Fire.FireType fireType)
    {
        fireList.Remove(fireType);
        OnFiresChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool ContainsFire(Fire.FireType fireType)
    {
        return fireList.Contains(fireType);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Fire fire = collider.GetComponent<Fire>();
        if (fire != null)
        {
            AddFire(fire.GetFireType());
            Destroy(fire.gameObject);
        }

        FireDoor fireDoor = collider.GetComponent<FireDoor>();
        if (fireDoor != null)
        {
            if (ContainsFire(fireDoor.GetFireType()))
            {
                // Currently hplding key to open thus door 
                RemoveFire(fireDoor.GetFireType());
                fireDoor.OpenDoor();

            }
        }


    }
}