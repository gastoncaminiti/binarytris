using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private float rayLenght;
    [SerializeField] LayerMask layermask;
    [SerializeField] AudioClip clickNumber;
    private AudioSource myAudioSource;
    // Update is called once per frame

    private void Start() {
        myAudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLenght,layermask))
            {
                if (hit.collider.tag == "Cube")
                {
                    
                   hit.collider.gameObject.GetComponent<SwitchCube>().MouseInputHandler(false);
                   playClickSFX();
                }
            }
        }

        if (Input.GetMouseButtonDown(1) )
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLenght,layermask))
            {
                if (hit.collider.tag == "Cube")
                {
                  hit.collider.gameObject.GetComponent<SwitchCube>().MouseInputHandler(true);
                  playClickSFX();
                }
            }
        }
    }

    void playClickSFX(){
        if(!myAudioSource.isPlaying){
            myAudioSource.PlayOneShot(clickNumber,1f);
        }
    }
}
