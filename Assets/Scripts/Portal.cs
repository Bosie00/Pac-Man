using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform portalBase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Vector3 position = collider.transform.position;
        position.x = portalBase.position.x;
        position.y = portalBase.position.y;
        collider.transform.position = position;
    }
}
