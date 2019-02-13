using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Vuforia;

public class vbScript : MonoBehaviour {
    int health = 0;
    //private GameObject vbButtonObject;
    //private GameObject monster;
    private Animation animate;
    // Use this for initialization
    void Start () {
        animate = GetComponent<Animation>();
        
        //CrossPlatformInputManager.GetButton("Attack");
        //monster = GameObject.Find("StoneMonster");
        //vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

    void Update()
    {
        
        bool Attack = CrossPlatformInputManager.GetButton("Button");
        if (Attack.Equals(true))
        {
            health++;
            animate.Play("Anim_Attack");
        }
        else
        {
            //if (health >= 3)
            //{
            //    animate.Play("Anim_Death");
            //    Debug.Log(health + "health");
            //}
            //else
            //{
                animate.Play("Anim_Idle");
            

        }
    }
    
    //void FixedUpdate()
    //{
    //    bool Attack = CrossPlatformInputManager.GetButton("Button");
    //    if (Attack.Equals(true))
    //    {
    //        anim.Play("Anim_Attack");
    //    }
    //}
}
