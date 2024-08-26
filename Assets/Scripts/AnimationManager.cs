using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    Animator animator;
    int horizontal;
    int vertical;



    private void Awake(){
        animator=GetComponent<Animator>();
        horizontal=Animator.StringToHash("Horizontal");
        vertical=Animator.StringToHash("Vertical");
    }
    public void UpdateAnimatorValues(float horizontalMovement, float verticalMovement){
        
        float snapHorizontal;
        float snapVertical;

        if(horizontalMovement>0 && horizontalMovement<0.55f){
            snapHorizontal=0.5f;
        }
        else if(horizontalMovement>0.55f){
            snapHorizontal=1;
        }
        else if(horizontalMovement<0 && horizontalMovement>-0.55f){
            snapHorizontal=-0.5f;
        }
        else if(horizontalMovement<-0.55f){
            snapHorizontal=-1;
        }
        else{
            snapHorizontal=0;
        }

        if(verticalMovement>0 && verticalMovement<0.55f){
            snapVertical=0.5f;
        }
        else if(verticalMovement>0.55f){
            snapVertical=1;
        }
        else if(verticalMovement<0 && verticalMovement>-0.55f){
            snapVertical=-0.5f;
        }
        else if(verticalMovement<-0.55f){
            snapVertical=-1;
        }
        else{
            snapVertical=0;
        }

        animator.SetFloat(horizontal,snapHorizontal, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical,snapVertical,0.1f, Time.deltaTime);
    }
}
