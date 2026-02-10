using UnityEngine;

public class HomeDoorScript : MonoBehaviour
{
    bool nearDoor = false;


    void OnTriggerEnter2D(Collider2D collision)
    {
        nearDoor = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        nearDoor = false;
    }

    void Update()
    {
        if (nearDoor && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interact with door");
        }
    }
}
