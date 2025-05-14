using UnityEngine;

public class Moeda : MonoBehaviour
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;
    public GameObject collected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player"){
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);
            Destroy(gameObject, 1f);
        }
    }
}


