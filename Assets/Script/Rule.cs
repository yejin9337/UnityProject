using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    Subject,
    Verb,
    Complement
}

public class Rule : MonoBehaviour
{
    public static RuleManager Manager { get; set; }


    public Type Type { get; set; }

    public Rule Down { get; set; }
    public Rule Right { get; set; }

    void OnEnable()
    {
        if (Type == Type.Subject)
        {
            Manager.AddSubject(this);
        }
    }

    public void CheckRule()
    {
        if (Right.Type == Type.Verb && Right.Right.Type == Type.Complement
            || Right.Type == Type.Verb && Right.Right.Type == Type.Subject)
        {
            Manager.ActivateFlag(RuleFlag.BabaIsWin);
        }

        if (Down.Type == Type.Verb && Down.Down.Type == Type.Complement
            || Down.Type == Type.Verb && Down.Down.Type == Type.Subject)
        {
            Manager.ActivateFlag(RuleFlag.BabaIsWin);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Rule rule = collision.collider.GetComponent<Rule>();
        if (rule != null)
        {
            // 충돌 방향에 따라서 Up, Down, Left, Right를 세팅

            return;
        }
    }

    //void OnDisable()
    //{
    //    Manager.RemoveSubject(this);
    //    // Remove
    //}
}