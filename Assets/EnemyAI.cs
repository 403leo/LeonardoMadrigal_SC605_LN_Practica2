using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;  // Referencia al jugador
    private NavMeshAgent agent;
    
    public float attackRange = 2.0f;  // Rango de ataque
    public int damage = 10;  // Daño de ataque
    private float distanceToPlayer;

    void Start()
    {
        // Obtiene el componente NavMeshAgent
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Calcula la distancia entre el enemigo y el jugador
        distanceToPlayer = Vector3.Distance(player.position, transform.position);

        // Si el jugador está dentro del rango de ataque, atacar
        if (distanceToPlayer <= attackRange)
        {
            AttackPlayer();
        }
        else
        {
            // Si el jugador está fuera del rango de ataque, seguirlo
            agent.SetDestination(player.position);  // Seguir al jugador
        }
    }

    // Método para atacar al jugador
    void AttackPlayer()
    {
        // Aquí puedes implementar el código para dañar al jugador
        Debug.Log("Atacando al jugador!");
    }
}