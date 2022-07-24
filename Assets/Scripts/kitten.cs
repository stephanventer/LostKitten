using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kitten : MonoBehaviour
{
    private Animator _animator;
    public float rotation = 0.5f;
    public float speed = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("walking", Input.GetKey(KeyCode.UpArrow));
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * (Time.deltaTime * speed));
        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            // this.transform.Translate(Vector3.back * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -rotation);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, rotation);  
        }  
    }
}
