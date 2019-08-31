namespace Example01 {
	/// <summary>
	/// Contém todos os atributos primários e derivados de um personagem
	/// </summary>
	public interface ICharacter : IContained {
		// Aqui utilizamos propriedades ao invés de campos para
		// proteger valores que não devem ser escritos por outros
		// scripts. Por exemplo a vida máxima vai ser calculada
		// com base na constituição, então não tem por que ninguém
		// precisar alterar a vida em si.

		// Simplifiquei a quantidade de atributos aqui para ficar
		// mais fácil de ilustrar

		float CurrentHealth { get; set; }
		float MaxHealth { get; }

		float CurrentStamina { get; set; }
		float MaxStamina { get; }

		int Constitution { get; }
		int Agility { get; }

		int Attack { get; set; }
		int Defense { get; set; }

		int CombatLevel { get; }
		int Cash { get; set; }
	}
}