using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
 {
    public float speed = 100.0f;
    public GameObject myGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myGameObject.transform.Rotate(1, speed, Time.deltaTime,0);
        
    }
}
