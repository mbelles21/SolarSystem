using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float yawDegreesPerSec = 45f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = GetComponent<Transform>();
        transform.Rotate(new Vector3(0f, yawDegreesPerSec * Time.deltaTime, 0f), Space.World);
    }
}
