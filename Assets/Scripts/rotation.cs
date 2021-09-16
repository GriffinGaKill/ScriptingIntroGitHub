using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationSpeed = 1;
    public Vector3 startAngle;
    public Vector3 endAngle;
    Vector3 curVel = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.eulerAngles = startAngle;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.eulerAngles = Vector3.SmoothDamp(this.transform.eulerAngles, endAngle, ref curVel, rotationSpeed);
    }
}
