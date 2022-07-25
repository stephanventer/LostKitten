using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking_forward : MonoBehaviour
{
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>(cat1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Walking Forward");
            anim.Play("cat_armature|walk");
        }
    }
}
