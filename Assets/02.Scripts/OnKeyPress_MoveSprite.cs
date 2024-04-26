using UnityEngine;

public class OnKeyPress_MoveSprite : MonoBehaviour
{
    #region 기존코드
    /*public float speed = 5;
    private float vx = 0;
    private float vy = 0;

    private bool leftFlag = false;

    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 8;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        vx = vy = 0;
        if (Input.GetKey("right")) {
            vx = speed;
            leftFlag = false;
        }
        if (Input.GetKey("left")) {
            vx = -speed;
            leftFlag = true;
        }
        if (Input.GetKey("up")) {
            vy = speed;
        }
        if (Input.GetKey("down")) {
            vy = -speed;
        }
    }
    void FixedUpdate()
    {
        //시험문제임 방법 2개 쓸 줄 알아야 함.
        //이동방법1
        //this.transform.Translate(vx/50, vy/50, 0);

        //이동방법2
        rbody.velocity = new Vector2(vx, vy);
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }*/
    #endregion

    #region 수정된코드
    public float speed = 5;

    public float vx { get; private set; }
    public float vy { get; private set; }
    private bool leftFlag = false;
    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }


    void Update()
    {
        vx = vy = 0;

        if (Input.GetKey("right"))
        {
            vx = speed;
           
        }

        if (Input.GetKey("left"))
        {
            vx = -speed;
            
        }

        if (Input.GetKey("up"))
        {
            vy = speed;
        }

        if (Input.GetKey("down"))
        {
            vy = -speed;
        }

    }

    void FixedUpdate()
    {
        rbody.velocity = new Vector2(vx, vy);
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }

   


    #endregion





}
