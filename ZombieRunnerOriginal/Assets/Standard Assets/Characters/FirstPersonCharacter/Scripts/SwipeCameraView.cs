using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{

    public class SwipeCameraView
    {
        Touch initTouch;
        public Vector2 currentSwipe;
        public float up, down, left, right;
        public MouseLook mouseLook = new MouseLook();
        float deltaX, deltaY;
        public float xRot;
        public float yRot;

      

        public void Swipe()
        {

            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                   initTouch = touch;
                }
                else if (touch.phase == TouchPhase.Moved)
                {
                    deltaX = initTouch.position.x - touch.position.x;
                    deltaY = initTouch.position.y - touch.position.y;
                    xRot -= deltaY *  mouseLook.XSensitivity;
                    yRot += deltaX *  mouseLook.YSensitivity;
                    
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    initTouch = new Touch();
                }
            }

            
        }
    }
}


