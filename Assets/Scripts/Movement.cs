
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {
    public Rigidbody rb;
    public float ff, rf;
    public Transform finish;
    float df = 100;
    public Text distance;
    int dist;
    // Use this for initialization
    void Start () {
        dist = (int)(finish.position.z - rb.position.z);
        distance.text = dist.ToString()+" m";
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        ff = 0; rf = 0;
        dist = (int)(finish.position.z - rb.position.z);
        rb.AddForce(rf, 0, ff);
        distance.text = (dist).ToString()+" m";
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.rf = df * Time.deltaTime;
            rb.AddForce(rf, 0, ff, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.rf = -df * Time.deltaTime;
            rb.AddForce(rf, 0, ff, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            this.ff = df * Time.deltaTime;
            rb.AddForce(rf, 0, ff, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            this.ff = -df * Time.deltaTime;
            rb.AddForce(rf, 0, ff, ForceMode.VelocityChange);
        }
        
    }
}
