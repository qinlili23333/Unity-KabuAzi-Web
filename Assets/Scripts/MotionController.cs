﻿using Live2D.Cubism.Framework;
using UnityEngine;

public class MotionController : MonoBehaviour
{
    private Animator animator;
    private int totalAnimations;

    private CubismEyeBlinkController eyeBlinkControler;

    private int motionNum;

    // Start is called before the first frame update
    void Start()
    {
        // 动画机
        animator =
            this.GetComponent<Animator>();
        // 动画总数
        totalAnimations = animator.runtimeAnimatorController.animationClips.Length;

        // 自动眨眼
        eyeBlinkControler =
            this.GetComponent<CubismEyeBlinkController>();

        // 动画播放序号
        motionNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 播放动画
    public void motionNext()
    {
        motionNum += 1;
        if (motionNum > totalAnimations - 1)
        {
            motionNum = 0;
        }

        // 动画播放
        animator.SetInteger("motionNum", motionNum);
    }

    // 关闭自动眨眼
    public void disableBlink()
    {
        eyeBlinkControler.enabled = false;
    }

    // 开启自动眨眼
    public void enableBlink()
    {
        eyeBlinkControler.enabled = true;
    }

}
