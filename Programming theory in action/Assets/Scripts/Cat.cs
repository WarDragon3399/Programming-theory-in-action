using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
    [SerializeField] private AudioClip myclip;
    // POLYMORPHISM
    protected override void Talk()
    {
        Debug.Log("Meow");
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = myclip;
        this.GetComponent<AudioSource>().Play();
    }
}
