using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextManagerScript : MonoBehaviour
{
   // https://www.youtube.com/watch?v=l8yI_97vjZs
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public GameObject textBox;
    public Text text;


    public void Chat(int choice)
    {
        switch (choice)
        {
            case 1:
                Debug.Log("1");
                break;
            case 2:
                Debug.Log("2");
                break;
        }
    }

    public void Yes()
    {
        Chat(1);
    }
    public void No()
    {
        Chat(2);
    }

    public void Intro()
    {
        
    }
}
