using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateTest : MonoBehaviour
{
    private Vector3 currentPos;
    private Vector3 targetPos;
    bool jump = false;
    private float distance;
    private float jump_distance = 5f;
    // Start is called before the first frame update
    void Start()
    {
        jump = true;
    }

    // Update is called once per frame
    void Update()
    {
        Jump(jump);
    }
    void Jump(bool jump)
    {
        if(jump)
        {
            jump = false;
            currentPos = transform.position;
            targetPos  = new Vector3(currentPos.x, (currentPos.y + jump_distance), currentPos.z);

        }
        distance = (targetPos - transform.position).magnitude;
        Debug.Log("Now Distance is " + distance);
        if (distance < 2.5)
        {
            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime);
        }
    }
}
