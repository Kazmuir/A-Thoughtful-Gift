using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenBg : MonoBehaviour
{
    // Awake is called during initialization before the game starts
    void Awake()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); //Grab the sprite renderer attached to the game object script is assigned to
        float cameraHeight = Camera.main.orthographicSize * 2; //orthographic view is flat and commonly used for 2d projects. This property is half viewport height so we multiply by 2.
        Vector2 cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight); //Here we are getting the width of the camera by taking its aspect ratio multiplied by height as first point, height as second point.
        Vector2 spriteSize = spriteRenderer.sprite.bounds.size; //Grab size of sprite

        Vector2 scale = transform.localScale; //this changes the size relative to parent it takes in x and y coords
        if (cameraSize.x >= cameraSize.y) //if the x coord is greater than the y coord, it is landscape view, otherwise it is portrait view.
        { // Landscape (or equal)
            scale *= cameraSize.x / spriteSize.x;
        }
        else
        { // Portrait
            scale *= cameraSize.y / spriteSize.y;
        }

        transform.position = Vector2.zero; //Make sure the position of the sprite is reset to 0 before setting the appropriate size
        transform.localScale = scale; //set the position of sprite to what was calculated above.
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
