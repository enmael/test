using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class BarrageChase : MonoBehaviour
{

    public float speed = 1;
    public Rigidbody2D target; // ������ ���

    public Rigidbody2D rigid; // ������ Rigidbody2D ������Ʈ
    private SpriteRenderer sprite; // ������ SpriteRenderer ������Ʈ

    private bool hasChased = false; // �� ���� �����ߴ��� üũ

    private void Awake()
    {
        // ������Ʈ �ʱ�ȭ
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        // �� ���� ����
        if (hasChased == false)
        {
            barrage();
        }
    }

    public void barrage()
    {
        if (target == null)
            return;

        // �÷��̾� ��ġ�� ���ϴ� ���� ���� ���
        Vector2 dirVec = target.position - rigid.position;
        Vector2 nexVec = dirVec.normalized * speed * Time.fixedDeltaTime;

        rigid.MovePosition(rigid.position + nexVec);

        // ���Ͱ� �÷��̾ �����ϸ� ���� ����
        if (Vector2.Distance(rigid.position, target.position) < 0.1f)
        {
            hasChased = true; // ���� �Ϸ� ǥ��
        }
    }



}
