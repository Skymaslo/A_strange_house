using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NoteController : MonoBehaviour
{
    public GameObject note;
    bool inTrigger = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void ShowNote()
    {
        note.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CloseNote()
    {
        note.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && inTrigger == true)
        {
            ShowNote();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            inTrigger = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")
        {
            inTrigger = false;
        }

    }
}
