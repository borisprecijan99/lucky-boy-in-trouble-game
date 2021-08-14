using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    private Vector3 from;

    [SerializeField]
    private Vector3 to;
    private Vector3 currentTarget;
    private float speed, delayStart, delayTime, tolerance;
 
    void Start()
    {
        delayTime = 1f;
        speed = 1f;
        from = transform.position;
        currentTarget = from;
        tolerance = speed * Time.deltaTime;
    }
 
    void FixedUpdate()
    {
        if (transform.position != currentTarget)
        {
            MovePlatform();
        }
        else
        {
            UpdateTarget();
        }
    }
 
    private void MovePlatform()
    {
        Vector3 heading = currentTarget - transform.position;
        transform.position += (heading / heading.magnitude) * speed * Time.deltaTime;
        if (heading.magnitude < tolerance)
        {
            transform.position = currentTarget;
            delayStart = Time.time;
        }
    }

    private void UpdateTarget()
    {
        if (Time.time - delayStart > delayTime)
        {
             if (currentTarget == from)
                currentTarget = to;
            else
                currentTarget = from;
        }
    }
 
    void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform);
    }

    void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }
}
