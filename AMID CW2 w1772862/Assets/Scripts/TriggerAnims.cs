using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnims : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public string[] aTriggers = { "Talk 1a", "Talk 1b", "Talk 1c" };
    private KeyCode[] keyCodes =
    {
        KeyCode.Alpha1,
        KeyCode.Alpha2,
        KeyCode.Alpha3
    };

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       for(int i = 0; i < keyCodes.Length; i++)
        {
            if (Input.GetKeyDown(keyCodes[i]))
            {
                int numberPressed = i + 1;
                Debug.Log(numberPressed);
                string animtoPlay = aTriggers[numberPressed-1];
                anim.SetTrigger(animtoPlay);
            }
        } 
    }
}
