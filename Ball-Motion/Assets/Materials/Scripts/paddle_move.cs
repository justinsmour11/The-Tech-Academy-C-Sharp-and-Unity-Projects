using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
    }
}
