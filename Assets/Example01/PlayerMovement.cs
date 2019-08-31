using UnityEngine;

namespace Example01 {
	public class PlayerMovement : MonoBehaviour, IMovement {
		[SerializeField]
		private float _baseSpeed;

		[SerializeField]
		private float _speedPerAgility;

		private ICharacter _character;

		public void CollectDependencies(Actor actor) {
			_character = actor.Character;
		}

		private void Update() {
			var direction = new Vector3(
				Input.GetAxis("Horizontal"),
				Input.GetAxis("Vertical")
			).normalized;

			var speed = _baseSpeed + _speedPerAgility * _character.Agility;
			transform.position += direction * speed;
		}
	}
}