using System;
using Enums;
using UnityEngine;
using EventHandler = Events.EventHandler.EventHandler;

namespace Animation
{
    public class MovementAnimationParameterControl : MonoBehaviour
    {
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void OnEnable()
        {
            EventHandler.MovementEvent += SetAnimationParameters;
        }

        private void OnDisable()
        {
            EventHandler.MovementEvent -= SetAnimationParameters;
        }

        private void SetAnimationParameters(float inputx, float inputy, bool iswalking, bool isrunning, bool isidle, bool iscarrying, ToolEffect tooleffect, bool isusingtoolright, bool isusingtoolleft, bool isusingtoolup, bool isusingtooldown, bool isliftingtoolright, bool isliftingtoolleft, bool isliftingtoolup, bool isliftingtooldown, bool ispickingright, bool ispickingleft, bool ispickingup, bool ispickingdown, bool isswingingtoolright, bool isswingingtoolleft, bool isswingingtoolup, bool isswingingtooldown, bool idleup, bool idledown, bool idleleft, bool idleright)
        {
            _animator.SetFloat(Settings.xInput, inputx);
            _animator.SetFloat(Settings.yInput, inputy);
            _animator.SetBool(Settings.isWalking, iswalking);
            _animator.SetBool(Settings.isRunning, isrunning);
            
            _animator.SetInteger(Settings.tooleffect, (int) tooleffect);
            
            if(isusingtoolright)
                _animator.SetTrigger(Settings.isUsingToolRight);
            if(isusingtoolleft)
                _animator.SetTrigger(Settings.isUsingToolLeft);
            if(isusingtoolup)
                _animator.SetTrigger(Settings.isUsingToolUp);
            if(isusingtooldown)
                _animator.SetTrigger(Settings.isUsingToolDown);
            
            if(isliftingtoolright)
                _animator.SetTrigger(Settings.isLiftingToolRight);
            if(isliftingtoolleft)
                _animator.SetTrigger(Settings.isLiftingToolLeft);
            if(isliftingtoolup)
                _animator.SetTrigger(Settings.isLiftingToolUp);
            if(isliftingtooldown)
                _animator.SetTrigger(Settings.isLiftingToolDown);
            
            if(ispickingright)
                _animator.SetTrigger(Settings.isPickingRight);
            if(ispickingleft)
                _animator.SetTrigger(Settings.isPickingLeft);
            if(ispickingup)
                _animator.SetTrigger(Settings.isPickingUp);
            if(ispickingdown)
                _animator.SetTrigger(Settings.isPickingDown);
            
            if(isswingingtoolright)
                _animator.SetTrigger(Settings.isSwingingToolRight);
            if(isswingingtoolleft)
                _animator.SetTrigger(Settings.isSwingingToolLeft);
            if(isswingingtoolup)
                _animator.SetTrigger(Settings.isSwingingToolUp);
            if(isswingingtooldown)
                _animator.SetTrigger(Settings.isSwingingToolDown);
            
            if(idleup)
                _animator.SetTrigger(Settings.idleUp);
            if(idledown)
                _animator.SetTrigger(Settings.idleDown);
            if(idleleft)
                _animator.SetTrigger(Settings.idleLeft);
            if(idleright)
                _animator.SetTrigger(Settings.idleRight);
        }

        private void AnimationEventPlayFootstepSound()
        {
            
        }
    }
}
