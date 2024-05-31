using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField]
    private float tumble;
    private float distance = 3;
    private float t = 1;
    private Vector3 camara;

    void Start()
    {
       GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
       camara = Camera.main.transform.position;
    
    }

    void Update()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
        //transform.position = transform.position + Camera.main.transform.forward * distance * time;
        // transform.Translate(Vector3.forward * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, camara, t*Time.deltaTime );
    }
}
