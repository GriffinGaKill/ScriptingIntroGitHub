using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angle : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float startAngle;
    public float endAngle;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 angle = this.transform.eulerAngles;
        angle.z = startAngle;
        this.transform.eulerAngles = angle;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempAngle = this.transform.eulerAngles;
        tempAngle.z = tempAngle.z * rotationSpeed * Time.deltaTime;
        this.transform.eulerAngles = tempAngle;
    }
}
