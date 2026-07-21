using UnityEngine;
using UnityEngine.UI;
public class hud : MonoBehaviour
{
    public Slider hp_bar;
        EntityStats player_stats;
    
    
    
    void Start()
    {
        player_stats = GameObject.FindGameObjectWithTag("Player").GetComponent<EntityStats>();
    
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHP();
    }

    void PlayerHP()
    {
        hp_bar.maxValue = player_stats.max_hp;
        hp_bar.value = player_stats.hp;

    }
}
