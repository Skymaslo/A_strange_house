using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    bool inTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void ShowNote()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && inTrigger == true)
        {
            
        }
    }
}
