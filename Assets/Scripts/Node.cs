using UnityEngine;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public Color startColor;

    public Vector3 positionOffset;


    private GameObject turret;



    private Renderer rend;



    void Start() {

        rend = GetComponent<Renderer>();


    }

    void OnMouseDown() {
        if (turret != null) {

            Debug.Log("Can't build there - TODO: Display on screen.");
            return;
        }


        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);







    }






        void OnMouseEnter() {
            rend.material.color = hoverColor;
        }

        void OnMouseExit() {

            rend.material.color = startColor;


        }





    }