using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBubble : MonoBehaviour
{
    public Color bubbleColor;
    private Vector3 positionOnCollision;

    private void OnCollisionEnter(Collision collision)
    {
        positionOnCollision = gameObject.transform.position;
        Bubble bubble = collision.gameObject.GetComponent<Bubble>();
        if (bubble != null && !bubble.bubbleIsBullet)
        {
            // Know if bubble has the same color
            if (bubble.bubbleColor.Equals(bubbleColor))
            {
                // Try to destroy
                bubble.destroy = true;

                // Add Physics
                collision.gameObject.AddComponent<Rigidbody>();
                //Rigidbody gameObjectsRigidBody = myGameObject.AddComponent<Rigidbody>();
            }
            else
            {
                //SphereCollider sphereCollider = collision.gameObject.GetComponent<SphereCollider>();
               // Transform bubbleTransform = collision.gameObject.transform;
               // gameObject.transform.position = new Vector3(positionOnCollision.x + sphereCollider.radius, positionOnCollision.y + sphereCollider.radius, positionOnCollision.z + sphereCollider.radius);
                Destroy(gameObject.GetComponent<Rigidbody>());
                Destroy(gameObject.GetComponent<BulletBubble>());

                // Put the same color as Bubble
                Bubble newBubble = gameObject.AddComponent<Bubble>();
                newBubble.setBubble(false, false, bubbleColor);
                //Debug.Log(bubbleColor);
            }

        }

    }

   
    private void Start()
    {
        Destroy(gameObject, 15.0f);
    }

}
