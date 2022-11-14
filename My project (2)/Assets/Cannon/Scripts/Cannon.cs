using UnityEngine;

public class Cannon : MonoBehaviour
{

	public GameObject objetoAInstanciar;
	public GameObject objetoAInstanciarV;
	public GameObject balas2;
	public GameObject balas3;
	public GameObject balas4;
	public Transform Lugar;
	public float damage;
	private void Start(){
		Shoot();
	}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
		if (Input.GetKeyDown(KeyCode.K))
		{
			Shoot2();
			
		}
		if (Input.GetKeyDown(KeyCode.L))
		{
			Shoot3();
		}
		if (Input.GetKeyDown(KeyCode.J))
		{
			Shoot4();

		}
    }
	private void Shoot()
	{
		Instantiate(objetoAInstanciar, Lugar.position, transform.rotation);
	}
	private void Shoot2()
	{
		Instantiate(balas2, Lugar.position, transform.rotation);
	}
	private void Shoot3()
	{
		Instantiate(balas3, Lugar.position, transform.rotation);
	}
	
	private void Shoot4()
	{
		Instantiate(balas4, Lugar.position, transform.rotation);
	}
}
