using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour

{
    [SerializeField] Door _currentDoor;
    [SerializeField] int _totalLights = 2;
    [SerializeField] public int _currentLights = 0;
    [SerializeField] Light light1;
    [SerializeField] Light light2;

    /*public delegate void OpenDoor();
    public static event OpenDoor openDoor;


    // Start is called before the first frame update
    void Start()
    {
        
        _currentDoor.setOpen(false);
        GameObject[] lightObjects = GameObject.FindGameObjectsWithTag("Light");
        lights = new Light[lightObjects.Length];
        _totalLights = lightObjects.Length;
        for (int i = 0; i<lightObjects.Length; i++)
        {
            lights[i] = lightObjects[i].GetComponent<Light>();
            Debug.Log("added" + i +"is"+ lightObjects[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentLights >= _totalLights)
        {
            _currentDoor.setOpen(true);
            Debug.Log("yes!");
            return;
        }
        else
        {
            _currentLights = 0;
            for (int i = 0; i < lights.Length; i++)
            {
                if(lights[i].isOn)
                {
                    _currentLights++;
                }
            }
        }
    */

    void Start()
    {
        _currentLights = 0;
        _totalLights = 2;
        _currentDoor = GameObject.Find("Door").GetComponent<Door>();
        light1 = GameObject.Find("Light").GetComponent<Light>();
        light2 = GameObject.Find("Light2").GetComponent<Light>();
    }

    void Update()
    {
        if (light1.isOn && light2.isOn)
        {
            _currentDoor.setOpen(true);
            Debug.Log("yes!");
            return;
        }
    }

}
