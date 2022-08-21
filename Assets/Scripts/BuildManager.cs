using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake() {

        if (instance != null) {
            Debug.LogError("More than one BuildManager in scene");
        }

        instance = this;
    }


    public GameObject standartTurretPrefab;

    void Start() {
        turretToBuild = standartTurretPrefab;
    }



    private GameObject turretToBuild;

    public GameObject GetTurretToBuild() {
        return turretToBuild;
    }















}




