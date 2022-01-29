using UnityEngine;

// INHERITANCE
public class Duck : Animal
{
    [SerializeField] private AudioClip myclip;
    // POLYMORPHISM
    protected override void Talk()
    {
        Debug.Log("Quack");
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.GetComponent<AudioSource>().Play();

    }
}
