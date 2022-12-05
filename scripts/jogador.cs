using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    public float x;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Input.GetAxisRaw("Horizontal")* speed, 0, Input.GetAxisRaw("Vertical") * speed);

        x = Input.GetAxisRaw("Horizontal");
    }
}
