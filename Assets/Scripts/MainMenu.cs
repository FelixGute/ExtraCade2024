using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class MainMenu : MonoBehaviour
{
    UIDocument UIDOC;

    Button startbutton;
    Button quitbutton;


    private void Awake()
    {
        UIDOC = GetComponent<UIDocument>();
        startbutton = UIDOC.rootVisualElement.Q<Button>("Start-Button");
        quitbutton = UIDOC.rootVisualElement.Q<Button>("Quit-Button");
        startbutton.clicked += onstartbutton;
    }
    
    void onstartbutton() 
    {
        print("test");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
