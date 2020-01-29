using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giftFall : MonoBehaviour
{
    public float fallSpeed = 0.50f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed/2 * Time.deltaTime, Space.World);
    }
}
