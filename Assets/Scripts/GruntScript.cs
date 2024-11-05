using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject Jorge;
    private float LastShot;
    private int Health = 3;
    void Update()
    {
        if (Jorge == null) return;
        Vector3 diretion = Jorge.transform.position - transform.position;
        if (diretion.x >= 0.0f) transform.localScale = new Vector3(1, 1, 1);
        else transform.localScale = new Vector3(-1, 1, 1);
        float distance = Mathf.Abs(Jorge.transform.position.x - transform.position.x);

        if (distance < 1.0f && Time.time > LastShot + 0.25f)
        {
            Shoot();
            LastShot = Time.time;
        }
    }
    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;

        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().SetDirection(direction);
    }
    public void Hit()
    {
        Health = Health - 1;
        if (Health == 0) Destroy(gameObject);
    }
}
