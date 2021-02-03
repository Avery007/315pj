using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicScript : MonoBehaviour
{
    public Vector3 rotation = new Vector3(0, 3.0f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.R))
        {
            this.GetComponent<Transform>().Rotate(rotation);
        }

    }
}
