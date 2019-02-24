using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftbtn : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim,liftanim;
    //public Transform wpt, lift;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="player")
        {
            anim.enabled = true;
            liftanim.enabled = true;
           // lift.position = Vector3.MoveTowards(lift.position, wpt.position, 1f);
        }
    }
}
