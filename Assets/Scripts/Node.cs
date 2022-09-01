using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public Color startColor;

    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;

    private Renderer rend;

    BuildManager buildManager;


    void Start() {

        rend = GetComponent<Renderer>();
        buildManager = BuildManager.instance;

    }


    public Vector3 GetBuildPosition() {
        return transform.position + positionOffset;
    }



    void OnMouseDown() {
        
        if (EventSystem.current.IsPointerOverGameObject()) {
            return;
        }

        if (!buildManager.CanBuild){
            return;
        }

        if (turret != null) {

            Debug.Log("Can't build there - TODO: Display on screen.");
            return;
        }

        buildManager.BuildTurretOn(this);

    }






        void OnMouseEnter() {

        if (EventSystem.current.IsPointerOverGameObject()) {
            return;
        }


        if (!buildManager.CanBuild) {
            return;
        }

        if(buildManager.HasMoney == true) {
            rend.material.color = hoverColor;
        }
        else {
            rend.material.color = Color.red;
        }


        
        }

        void OnMouseExit() {

            rend.material.color = startColor;


        }





    }