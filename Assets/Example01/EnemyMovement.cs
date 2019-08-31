using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Example01 {
	public class EnemyMovement : MonoBehaviour, IMovement {
		[SerializeField]
		private float _baseSpeed;

		[SerializeField]
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
			_direction += (Vector3) Random.insideUnitCircle * _directionDeviation;

			transform.position += _direction * _baseSpeed;
		}
	}
}
