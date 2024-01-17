using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation : MonoBehaviour
{
    Animator animator;
    private List<string> triggerList = new List<string>();

    private void Start()
    {
       
    }

    private void addOnTriggerList()
    {
        triggerList.Add("Wall1Trigger");
        triggerList.Add("Wall2Trigger");
        triggerList.Add("Wall3Trigger");
    }

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Wall1Trigger");
        Debug.Log("Hi!");
    }
}
