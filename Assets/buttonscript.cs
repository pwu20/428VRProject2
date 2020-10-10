using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class buttonscript : MonoBehaviour
{
	
	public GameObject vnBtn;
	public Animator animation;
	public AudioSource recording;
	public AudioSource typing;
    // Start is called before the first frame update
    void Start()
    {
        vnBtn = GameObject.Find("VirtualButton");
		vnBtn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
		animation.GetComponent<Animator>();
		typing.Play();
	
    }
	
	public void OnButtonPressed(VirtualButtonBehaviour vh){
		typing.Stop();
		animation.Play("sad");
		recording.Play();
		Debug.Log("button pressed");
		typing.Play();
	}


    // Update is called once per frame
    void Update()
    {
        
    }
}
