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
			// Coletar os scripts com base na interface que eles implementam,
			// ao invés do script diretamente, permite-nos anexar scripts
			// diferentes ao objeto desde que cumpram as funções definidas
			// na interface.
			Hud = GetComponent<IHud>();
			Character = GetComponent<ICharacter>();
			Movement = GetComponent<IMovement>();

			// Depois que temos tudo em mãos, passamos o balde para todos
			// os scripts, isso permite que eles tenham acesso uns aos
			// outros, sem depender dos detalhes de implementação dos mesmos.
			Hud.CollectDependencies(this);
			Character.CollectDependencies(this);
			Movement.CollectDependencies(this);
		}
	}
}