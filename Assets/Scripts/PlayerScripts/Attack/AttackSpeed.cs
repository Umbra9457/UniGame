using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpeed : MonoBehaviour
{

    public float goalTime;

    public float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    //sets the speed on how long the attack is active for, making this faster means a smaller window to deal damage with
    void Update()
    {
        float endTime;

        endTime = startTime + goalTime;

        if (Time.time >= endTime)
        {
            Destroy(gameObject);
        }
    }
}
