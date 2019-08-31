using UnityEngine;

namespace Example01 {
	/// <summary>
	/// Contém todos os scripts necessários para gerenciar um personagem
	/// </summary>
	public class Actor : MonoBehaviour {
		public IHud Hud { get; set; }
		public ICharacter Character { get; set; }
		public IMovement Movement { get; set; }

		private void Awake() {
			Hud = GetComponent<IHud>();
			Character = GetComponent<ICharacter>();
			Movement = GetComponent<IMovement>();

			Debug.Log(name);
			Debug.Log($"{nameof(Hud)}: {Hud}");
			Debug.Log($"{nameof(Character)}: {Character}");
			Debug.Log($"{nameof(Movement)}: {Movement}");

			Hud.CollectDependencies(this);
			Character.CollectDependencies(this);
			Movement.CollectDependencies(this);
		}
	}
}