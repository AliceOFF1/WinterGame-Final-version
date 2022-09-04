using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class EnemyPatroolHide : MonoBehaviour
{

    //Reference to waypoints 
    public List<Transform> points;
    //The int value for next point index 
    public int nextID = 0;
    //The value of that applies to ID for changing 
    int idChangeValue = 1;
    //Speed of movement or flting 
    public float speed = 2;

    [SerializeField] private AudioSource damageSound;

    private void Reset()
    {
        Init();
    }

    void Init()
    {

        //Make box collider trigger 
        GetComponent<BoxCollider2D>().isTrigger = true;

        //Create Root object 
        GameObject root = new GameObject(name + "_Root");
        //Reset Position of Root to enemy object 
        root.transform.position = transform.position;
        //Set enemy jbject as child of root 
        transform.SetParent(root.transform);
        //Create Waypoints object 
        GameObject waypoints = new GameObject("Waypoints");
        //Reset waypoints position to root 
        //Make waypoints object child of root 
        waypoints.transform.SetParent(root.transform);
        waypoints.transform.position = root.transform.position;
        //Create two points(gameobject) and reset their position to way 
        //Make the points children of waypoin object
        GameObject p1 = new GameObject("Point1"); p1.transform.SetParent(waypoints.transform); p1.transform.position = Vector3.zero;
        GameObject p2 = new GameObject("Point1"); p2.transform.SetParent(waypoints.transform); p2.transform.position = Vector3.zero;

        //Init points list then add the points to it 
        points = new List<Transform>();
        points.Add(p1.transform);
        points.Add(p2.transform);
    }

    private void Update()
    {
        MoveToNextPoint();

    }

    void MoveToNextPoint()
    {
        //Get the next Point transform 
        Transform goalPoint = points[nextID];
        //Flip the enemy transform to look into the point's direction 
        if (goalPoint.transform.position.x > transform.position.x)
            transform.localScale = new Vector3(1, 1, 1);
        else
            transform.localScale = new Vector3(-1, 1, 1);
        //Move the enemy towards the goal point  
        transform.position = Vector2.MoveTowards(transform.position, goalPoint.position, speed * Time.deltaTime);
        //Check the distance between enemy 
        if (Vector2.Distance(transform.position, goalPoint.position) < 1f)
        {
            //Check if we are at the end of the line (make the change -1) 
            if (nextID == points.Count - 1)
                idChangeValue = -1;
            //Check if we are at the start of the line (make the change +1) 
            if (nextID == 0)
                idChangeValue = 1;
            //Apply the change on the nextID 
            nextID += idChangeValue;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        PlayerController controller = other.gameObject.GetComponent<PlayerController>();

        if (controller != null)

        {
            controller.ChangeHealth(-50);
            damageSound.Play();
        }
    }
}
