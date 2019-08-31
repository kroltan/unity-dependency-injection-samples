using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Example01 {
	/// <summary>
	/// Move o ator aleatoriamente pelo cenário.
	/// </summary>
	public class EnemyMovement : MonoBehaviour, IMovement {
		public bool CanMove { get; set; }

		[SerializeField, Tooltip("Velocidade de movimento")]
		private float _baseSpeed;

		[SerializeField, Range(0, 1), Tooltip("Porcentagem de variação de direção máxima por frame")]
		private float _directionDeviation;

		private Vector3 _direction;

		public void CollectDependencies(Actor actor) {
			// Não preciso de nada, inimigos andam a uma velocidade constante
			// No seu jogo pode ser diferente, claro, mas só queria
			// ilustrar como implementações diferentes podem ser usadas.
		}

		private void Start() {
			_direction = Random.insideUnitCircle;
		}

		private void Update() {
			if (!CanMove) {
				return;
			}

			// Faço isso para fazer o inimigo mudar de direção bem pouco a
			// cada frame, isso faz com que ele ande erraticamente mas mantenha
			// uma direção estável (ao invés de ficar chacoalhando arbitrariamente.
			_direction += (Vector3) Random.insideUnitCircle * _directionDeviation;

			// Uma direção deve ser sempre um vetor de tamanho 1, senão o inimigo
			// iria acelerar ou freiar com o tempo, que não é desejado.
			_direction.Normalize();

			transform.position += _direction * _baseSpeed;
		}
	}
}