using UnityEngine;

public class ChikinTimer : MonoBehaviour
{
    public float timeLeft;
    private float seconds = 30f;
    [SerializeField] AudioSource metalPipe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeLeft = seconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            ActivateChickenTimer();
        }
    }

    private void ActivateChickenTimer()
    {
        //play sound
        print("playing");
        metalPipe.Play();
        //show chicken
        //reset timer AFTER player looks away and chicken goes down or after set time of chicken being up?
        timeLeft = seconds;
    }
}
