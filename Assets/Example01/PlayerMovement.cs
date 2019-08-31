using UnityEngine;

namespace Example01 {
	public class PlayerMovement : MonoBehaviour, IMovement {
		public bool CanMove { get; set; }

		[SerializeField, Tooltip("Velocidade para 0 de agilidade (m/s)")]
		private float _baseSpeed;

		[SerializeField, Tooltip("Metros por segundo extra para cada ponto de agilidade")]
		private float _speedPerAgility;

		private ICharacter _character;

		public void CollectDependencies(Actor actor) {
			_character = actor.Character;
		}

		private void Update() {
			if (!CanMove) {
				return;
			}

			// Pega a direção que o jogador está apertando
			// como um Vector2, lembrando que deve estar
			// normalizada para que movimentos diagonais
			// tenham a mesma velocidade que os retos.
			var direction = new Vector3(
				Input.GetAxis("Horizontal"),
				Input.GetAxis("Vertical")
			).normalized;

			// A velocidade aumenta com a agilidade do personagem.
			var speed = _baseSpeed + _speedPerAgility * _character.Agility;
			transform.position += direction * speed;
		}
	}
}