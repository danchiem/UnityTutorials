using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text WinText;
    private Rigidbody rb;

    private int count;

    void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCount();
        WinText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCount();

            if (count >= 9)
               WinText.text = "You Win!";
        }
    }

    void SetCount()
    {
        countText.text = "Count: " + count.ToString();

    }
}