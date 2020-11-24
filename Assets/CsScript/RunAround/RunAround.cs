using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAround : MonoBehaviour
{
    public Transform sun;
    private float m_Distance = 3f;
    public float m_multiple = 2;
    //priva
    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("Sphere").GetComponent<Transform>();
        transform.position = sun.position;
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = new Vector3(Mathf.Lerp(-10, 10, Time.deltaTime), 0, Mathf.Lerp(-10, 10, Time.deltaTime)) * m_multiple;
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
    }
}
