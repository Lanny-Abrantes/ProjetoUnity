using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{
    public float velocidade = 10.0f;
    public float horizontal;
    public float vertical;
    public Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
         rigidbody = GetComponent <Rigidbody2D>();    

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector2(velocidade*horizontal,velocidade*vertical);
    }
}
