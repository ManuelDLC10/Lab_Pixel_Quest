using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(prefab, bulletSpawn.position, Quaternion.identity);
            //bullet.transform.SetParent(bulletTrash);
        }
    }
}
