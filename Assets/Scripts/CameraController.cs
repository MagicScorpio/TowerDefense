using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour {



    private bool doMovement = true;



    public float panSpeed = 40f;
    public float panBorderThickness = 10f;
    public float minX = -62.2f;
    public float maxX = 100f;

    public float maxZ = 3f;
    public float minZ = -100f;


    public float scrollSpeed = 1000f;
    public float horizontalRotate = 0.75f;
    public float minY = 10f;
    public float maxY = 80f;


    

    void Update() {

        // Lock camera movement
        if (Input.GetKeyDown(KeyCode.Escape)) {
            doMovement = !doMovement;
        }

        if (!doMovement) {
            return;
        }


        Vector3 pos = transform.position;








        // move
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness) {
            if(pos.z >= maxZ) {
                return;
            }
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
            
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness) {
            if(pos.z <= minZ) {
                return;
            }
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness) {
            if (pos.x <= minX) {
                return;
            }
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness) {
            if (pos.x >= maxX) {
                return;
            }
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }



        // scroll zoom

        //Scroll Up
        if (Input.GetAxis("Mouse ScrollWheel") > 0f && pos.y >= minY) {
            transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime, Space.World);
            transform.Rotate(-horizontalRotate, 0, 0, Space.World);
        }

        // Scroll Down
        if (Input.GetAxis("Mouse ScrollWheel") < 0f && pos.y <= maxY) {
            transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime, Space.World);
            transform.Rotate(horizontalRotate, 0, 0, Space.World);
        }
        

    }







}
