using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateTest : MonoBehaviour
{
    private Vector3 currentPos;
    private Vector3 targetPos;
    bool jump = false;
    public float distance = 5;
    // Start is called before the first frame update
    void Start()
    {
        jump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (jump)
        {
            currentPos = transform.position;
            targetPos = new Vector3(currentPos.x, currentPos.y + 10, currentPos.z);
            distance = (targetPos - currentPos).magnitude;
            transform.position = Vector3.Lerp(currentPos, targetPos, Time.deltaTime);
        }
        if (distance > 2.5)
        {
            jump = false;
        }

    }
}
