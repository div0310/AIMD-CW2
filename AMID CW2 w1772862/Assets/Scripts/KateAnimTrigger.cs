using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KateAnimTrigger : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            anim.SetTrigger("Greet");
        }
    }
}
