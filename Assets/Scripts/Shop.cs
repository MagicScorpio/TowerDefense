using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    void Start() {
        buildManager = BuildManager.instance;
    }






    public void PurchaseStandartTurret() {
        Debug.Log("Standart Turret Selected");
        buildManager.SetTurretToBuild(buildManager.standartTurretPrefab);
    }


    public void PurchaseAnotherTurret() {
        Debug.Log("Another Turret Selected");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }




}
