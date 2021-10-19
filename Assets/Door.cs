using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] string _nextLevel;
    [SerializeField] public bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isOpen)
        {
            Debug.Log("collison!");
            SceneManager.LoadScene(_nextLevel, LoadSceneMode.Single);
        }
    }

    public void setOpen(bool isOpen)
    {
        this.isOpen = isOpen;
    }



}
