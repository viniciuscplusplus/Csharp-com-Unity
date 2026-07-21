using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float base_speed;
    float move_speed;
    void Start()
    {
        move_speed = base_speed;
    }

    // Update is called once per frame
    void Update()
    {
        WASDMove();
    }

    void WASDMove(){

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2 (horizontal * move_speed, vertical * move_speed));

        if ( (horizontal > 0 || horizontal < 0) && (vertical > 0 || vertical < 0) )
        { 
            move_speed = base_speed*0.66f; 
        }

        else
        {
            move_speed = base_speed ;
        }

    }


}
