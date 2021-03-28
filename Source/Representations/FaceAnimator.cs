using UnityEngine;

namespace MultiplayerMod.Source.Representations
{
    public class FaceAnimator
    {
        public enum FaceState : int
        {
            Idleers = 0,
            Happyers = 1,
            Confusedders = 2,
            Sadders = 3,
            goggers = 4,
            Angryers = 5
        }

        public float faceTime;
        public FaceState faceState;
        public Animator animator;

        public void Update()
        {
            //0 - Idle
            //1 - Happy
            //2 - Confused
            //3 - Sad
            //4 - Pog
            //5 - Angry
            if (faceTime <= 0)
            {
                faceState = (FaceState)Mathf.RoundToInt(Random.Range(-0.1f, 5.1f));
                if (faceState <= 0)
                {
                    faceState = FaceState.Idle;
                    faceTime = Random.Range(15, 30);
                }
                else
                {
                    switch (faceState)
                    {
                        case FaceState.Happy:
                            faceTime = Random.Range(15, 30);
                            break;
                        case FaceState.Confused:
                            faceTime = Random.Range(10, 15);
                            break;
                        case FaceState.Sad:
                            faceTime = Random.Range(5, 15);
                            break;
                        case FaceState.Pog:
                            faceTime = Random.Range(1, 2);
                            break;
                        case FaceState.Angry:
                            faceTime = Random.Range(10, 15);
                            break;
                        default:
                            faceTime = Random.Range(1, 2);
                            break;
                    }
                }

                animator.SetInteger("State", (int)faceState);
            }
            else
            {
                faceTime -= Time.unscaledDeltaTime;
                if (animator.GetInteger("State") != (int)faceState)
                {
                    animator.SetInteger("State", (int)faceState);
                }
            }
        }
    }
}
