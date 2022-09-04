using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyantennaHolder : MonoBehaviour
{
    public event EventHandler OnKeyantennasChanged;
    private List<Keyantenna.KeyantennaType> keyantennaList;

    private void Awake()
    {
        keyantennaList = new List<Keyantenna.KeyantennaType>();
    }

    public List<Keyantenna.KeyantennaType> GetKeyantennaList()
    {
        return keyantennaList;
    }

    public void AddKeyantenna(Keyantenna.KeyantennaType keyantennaType)
    {
        keyantennaList.Add(keyantennaType);
        OnKeyantennasChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveKeyantenna(Keyantenna.KeyantennaType keyantennaType)
    {
        keyantennaList.Remove(keyantennaType);
        OnKeyantennasChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool ContainsKeyantenna(Keyantenna.KeyantennaType keyantennaType)
    {
        return keyantennaList.Contains(keyantennaType);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Keyantenna keyantenna = collider.GetComponent<Keyantenna>();
        if (keyantenna != null)
        {
            AddKeyantenna(keyantenna.GetKeyantennaType());
            Destroy(keyantenna.gameObject);
        }

        KeyantennaDoor keyantennaDoor = collider.GetComponent<KeyantennaDoor>();
        if (keyantennaDoor != null)
        {
            if (ContainsKeyantenna(keyantennaDoor.GetKeyantennaType()))
            {
                // Currently hplding key to open thus door 
                RemoveKeyantenna(keyantennaDoor.GetKeyantennaType());
                keyantennaDoor.OpenDoor();

            }
        }
    }
}
