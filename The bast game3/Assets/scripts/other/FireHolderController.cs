using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHolderController : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;
    public GameObject objectToSpawn;
    private bool Activate;
    private UnityEngine.Object fireHolderRef;

    Vector3 spawnPos;




    void Start()
    {
        spawnPos = transform.position;
        fireHolderRef = Resources.Load("FireHolder");
        objectToSpawn.SetActive(false);
        Activate = false;

    }




    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        FreazenPlus controller = collision.GetComponent<FreazenPlus>();

        if (controller != null)

        {
            Activate = true;
        }

        if (collision.CompareTag("DieZone"))
        {
            gameObject.SetActive(false);
            Respawn();
        }

    }

    private void Update()
    {


        if (Activate == true)
        {
            door.OpenDoor();
            objectToSpawn.SetActive(true);
        }


    }

    void Respawn()
    {
        GameObject fireHolderCopy = (GameObject)Instantiate(fireHolderRef);
        fireHolderCopy.transform.position = new Vector3(Random.Range(spawnPos.x - 1, spawnPos.x + 1), spawnPos.y, spawnPos.z);

        Destroy(gameObject);
    }


}