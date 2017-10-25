using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    public Text countText;
    public Text winText;
    private int count;

	void Start () {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "Coins Collected:" + count;
        winText.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float horiInput = Input.GetAxis("Horizontal");
        float vertiInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horiInput, 0, vertiInput);

        rb.AddForce(movement * speed);
	}
     void OnTriggerEnter(Collider other)
    {
            other.gameObject.SetActive(false);
            count++;
            countText.text = "Coins Collected:" + count;
        if (count == 9)
        {
            winText.text = "You Win !!!";

        }
        
    }
}
