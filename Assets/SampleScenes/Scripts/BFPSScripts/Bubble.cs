using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour {


    public bool destroy;
    public bool bubbleIsBullet; // bubbleIsBullet can be deleted if we consider that any BulletBubble are Bubbles
    public Color bubbleColor;
 
    private void Update()
    {
        //TODO When object is quiet more than 10 seconds destroy it
        if (destroy) { 
            Destroy(gameObject);
        }
    }

    public void setBubble(bool destroy, bool bubbleIsBullet, Color bubbleColor)
    {
        this.destroy = destroy;
        this.bubbleIsBullet = bubbleIsBullet;
        this.bubbleColor = bubbleColor;
        // Change color material
        gameObject.GetComponent<Renderer>().material.color = bubbleColor;
    }

 


}
