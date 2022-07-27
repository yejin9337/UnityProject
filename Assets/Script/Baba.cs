using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baba : SubjectWord
{
    private PlayerInput _input;
    public Animator _animator;

    void Start()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void Update()
    {
        if()
            IsYou();
        if()
            IsStop();
        if ()
            IsPush();
        if ()
            IsWin();
    }

    public override void IsYou()
    {
        GetComponent<Collider2D>().isTrigger = false;
        transform.Translate(new Vector2(_input.xInput, _input.yInput));
        if(_input.xInput > 0 )
            _animator.Play("babaright");
        if(_input.xInput < 0)
            _animator.Play("babaleft");
        if(_input.yInput > 0)
            _animator.Play("babaup");
        if(_input.yInput > 0)
            _animator.Play("babadown");
    }

    public override void IsStop()
    {
        GetComponent<Collider2D>().isTrigger = false;
    }

    public override void IsPush()
    {
        GetComponent<Collider2D>().isTrigger = false;
    }

    public override void IsWin()
    {
        //_animator.Play("bright");
    }
}
