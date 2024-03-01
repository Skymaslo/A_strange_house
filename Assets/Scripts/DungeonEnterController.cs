using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class DungeonEnterController : MonoBehaviour
{
    bool inTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

     
    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
        print("� �������� ����� " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
        print("�� �������� �����" + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        print("� ��������� ������� " + other.gameObject.name);
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && inTrigger == true)
        {
            SceneManager.LoadScene("Dangeon");
        }
    }
}
