using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Jogo : MonoBehaviour
{
    [SerializeField] private Player player;
    //Tela de morte
    [SerializeField] private GameObject TelaDaMorte;
    private GameObject [] Moeda;
    [SerializeField] public TextMeshProUGUI pontos;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        TelaDaMorte.SetActive(false);
        pontos = GameObject.Find("Pontos").GetComponent<TextMeshProUGUI>();
        Moeda = GameObject.FindGameObjectsWithTag("Moeda");
        

    }

    // Update is called once per frame
    void Update()
    {
        if (!player.VerificaSePlayerEstaVivo())
        {
           TelaDaMorte.SetActive(true);
        }
        pontos.text = player.ContagemPontos().ToString();

        

        
    }
    public void replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        Application.Quit();
    }
 
    

}
