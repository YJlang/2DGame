// BulletCollision ��ũ��Ʈ
using UnityEngine;

public class BulletPower : MonoBehaviour
{
    //�Ѿ� ȸ�� ���ǵ�
    public float speed = 1f;

    // ���ݷ��� ��Ÿ���� ������
    public enum AttackPower
    {
        Normal,
        Super
    }

    // ���� ���ݷ� ����
    public AttackPower currentPower = AttackPower.Normal;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ������Ʈ�� �±װ� "Respawn"�� ���
        if (collision.gameObject.CompareTag("Respawn"))
        {
            // �浹�� ������Ʈ�� RespawnObject ��ũ��Ʈ ��������
            Obake_HP respawnObject = collision.gameObject.GetComponent<Obake_HP>();

            // RespawnObject ��ũ��Ʈ�� �����ϴ� ���
            if (respawnObject != null)
            {
                // ���� ���ݷ¿� ���� ������Ʈ �ı� �Ǵ� ü�� ����
                if (currentPower == AttackPower.Super)
                {
                    // Super ������ ���� �� ���� �浹�� ������Ʈ �ı�
                    respawnObject.DestroyObject();
                }
                else
                {
                    // Normal ������ ���� ü�� ����
                    respawnObject.DecreaseHealth();
                }
            }

            // �Ѿ� ������Ʈ �ı�
            Destroy(gameObject);
        }
    }


    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, speed * 10f);
    }
}