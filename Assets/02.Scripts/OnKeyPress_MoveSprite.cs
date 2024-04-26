using UnityEngine;

public class OnKeyPress_MoveSprite : MonoBehaviour
{
    #region �����ڵ�
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
        //���蹮���� ��� 2�� �� �� �˾ƾ� ��.
        //�̵����1
        //this.transform.Translate(vx/50, vy/50, 0);

        //�̵����2
        rbody.velocity = new Vector2(vx, vy);
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }*/
    #endregion

    #region �������ڵ�
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
