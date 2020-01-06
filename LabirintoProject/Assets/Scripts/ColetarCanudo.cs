using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetarCanudo : MonoBehaviour
{
    private int pontos;
    public TextMesh pontuacao;
	
	public GameObject textoFinal;
	public bool terminouJogo;
	
	
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
		
		textoFinal.SetActive(false);
		terminouJogo = false;
    }

    // Update is called once per frame
    void Update()
    {
        pontuacao.text = "SCORE: " + pontos;
		
    }

    void OnCollisionEnter2D(Collision2D collision){
        GameObject collider = collision.collider.gameObject;
        if(collider.tag == "Canudo"){
            GameObject.Destroy(collider);
            pontos++;
        }
		if(pontos >= 10 && collider.tag == "passagem"){
			GameObject.Destroy(collider);
		}
		if(collider.tag == "espinho"){
			Restart();
		}
		if(collider.tag == "bau"){
			Time.timeScale = 0;
			fimDeJogo();
		}
		
		
    }

    void OnTriggerEnter2d(Collider2D collider){
        if(collider.tag == "Canudo"){
            GameObject.Destroy(collider.gameObject);
        }
		if(pontos >= 10 && collider.tag == "passagem"){
			GameObject.Destroy(collider.gameObject);
		}
		if(collider.tag == "espinho"){
			Restart();
		}		
		if(collider.tag == "bau"){
			Time.timeScale = 0;
			fimDeJogo();	
		}
		
    }
	
	void fimDeJogo(){
		textoFinal.SetActive(true);
		terminouJogo = true;
	}
	
		
	public void Exit(){
		Time.timeScale = 1;
		Application.Quit();
	}
	
	public void Restart(){
		Time.timeScale = 1;
		Application.LoadLevel("Cena1");
	}
}
