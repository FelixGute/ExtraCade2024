using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainGui : MonoBehaviour
{
    public Damagable PlrDamagable;

    UIDocument UIDOC;
    Label healthdisplay;
    Label pointsdisplay;


    private void Awake()
    {
        UIDOC = GetComponent<UIDocument>();
        healthdisplay = UIDOC.rootVisualElement.Q<Label>("healthdisplay");
        pointsdisplay = UIDOC.rootVisualElement.Q("pointsdisplay") as Label;

    }
    void Start()
    {
        
    }

    void Update()
    {
        healthdisplay.text = PlrDamagable.health.ToString();

        pointsdisplay.text = "0";
    }
}
