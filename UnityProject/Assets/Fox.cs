using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0, 40)]
    public float speed = 10;
    private Rigidbody2D rig;
    private SpriteRenderer spr;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        Moving();
    }
    private void Moving()
    {
        float hor = Input.GetAxis("Horizontal");
        print(hor);
        if (hor < 0)
        {
            spr.flipX = true;
        }
        else
        {
            spr.flipX = false;
        }
        rig.AddForce(new Vector2(hor * speed, 0));
    }
}
