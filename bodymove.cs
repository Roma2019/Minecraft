using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodymove : MonoBehaviour
{
    Transform body;
    void Start()
    {
        body = GetComponent<Transform>();
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        body.Translate(0,0.5f,0);
    }
}
