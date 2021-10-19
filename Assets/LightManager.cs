using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour

{
    [SerializeField] Door _currentDoor;
    [SerializeField] int _totalLights;
    // Start is called before the first frame update
    void Start()
    {
        _currentDoor = GameObject.Find("Door").GetComponent<Door>();
        Debug.Log(_currentDoor.ToString());
        _currentDoor.setOpen(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
