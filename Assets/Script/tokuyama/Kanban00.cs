using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanban00 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag=="Human")
        {
            Destroy(this.gameObject);
        }
    }
}
