using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
   // public GameObject walks;
    
    public Animator anim;

    public void Walk(bool moveWalk)
    {

        anim.SetBool("IsWalk", moveWalk);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
