using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Light : MonoBehaviour
{
    [SerializeField] public bool isOn;
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color(0, 0, 0, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("yes!");
        isOn = !isOn;
        if(isOn)
        {
           sprite.color = new Color(255, 255, 255, 255);
        } else
        {
            sprite.color = new Color(0, 0, 0, 255);
        }
 
        
    }




}
