using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Draw()
    {

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(transform.position, transform.position+transform.up*-3);
    }
}
