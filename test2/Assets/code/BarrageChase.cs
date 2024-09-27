using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class BarrageChase : MonoBehaviour
{

    public float speed = 1;
    public Rigidbody2D target; // 추적할 대상

    public Rigidbody2D rigid; // 몬스터의 Rigidbody2D 컴포넌트
    private SpriteRenderer sprite; // 몬스터의 SpriteRenderer 컴포넌트

    private bool hasChased = false; // 한 번만 추적했는지 체크

    private void Awake()
    {
        // 컴포넌트 초기화
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        // 한 번만 추적
        if (hasChased == false)
        {
            barrage();
        }
    }

    public void barrage()
    {
        if (target == null)
            return;

        // 플레이어 위치로 향하는 방향 벡터 계산
        Vector2 dirVec = target.position - rigid.position;
        Vector2 nexVec = dirVec.normalized * speed * Time.fixedDeltaTime;

        rigid.MovePosition(rigid.position + nexVec);

        // 몬스터가 플레이어에 도달하면 추적 종료
        if (Vector2.Distance(rigid.position, target.position) < 0.1f)
        {
            hasChased = true; // 추적 완료 표시
        }
    }



}
