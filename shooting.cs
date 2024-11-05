using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
                enemy.TakeDamage(damage);
        }
    }
}
