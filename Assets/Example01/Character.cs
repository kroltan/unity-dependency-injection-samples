using UnityEngine;

namespace Example01 {
	public class Character : MonoBehaviour, ICharacter {
		// Não se se você já conhecia propriedades, mas elas
		// são uma maneira de proteger o acesso a variáveis
		// dos scripts, seja fazendo alguma validação ou
		// limitando quem que pode escrevê-las.

		// Nesse caso estou usando para 2 coisas:
		// a) Garantir que a vida e estamina não estejam maiores
		//    que o valor máximo delas;
		// b) Atualizar a HUD cada vez que um valor muda, dessa
		//    maneira não precisamos atualizar a HUD a cada
		//    Update, que seria desperdício de processamento.

		public float CurrentHealth {
			get => _currentHealth;
			set {
				_currentHealth = Mathf.Clamp(value, 0, MaxHealth);
				_hud.Redraw();
			}
		}

		// Essa é a sintaxe simplificada para quando você
		// tem uma propriedade que o valor depende de outros
		// valores, e não pode ser escrita.
		public float MaxHealth => Constitution * 10;

		public float CurrentStamina {
			get => _currentStamina;
			set {
				_currentStamina = Mathf.Clamp(value, 0, MaxStamina);
				_hud.Redraw();
			}
		}

		public float MaxStamina => Agility * 10;

		public int Constitution => (Attack + Defense) / 3;

		public int Agility => (Attack + Defense) / 3;

		public int Attack {
			get => _attack;
			set {
				_attack = value;
				_hud.Redraw();
			}
		}

		public int Defense {
			get => _defense;
			set {
				_defense = value;
				_hud.Redraw();
			}
		}

		public int CombatLevel => (Attack + Defense) / 3;

		public int Cash {
			get => _cash;
			set {
				_cash = value;
				_hud.Redraw();
			}
		}

		[SerializeField]
		private float _currentHealth;

		[SerializeField]
		private float _currentStamina;

		[SerializeField]
		private int _attack;

		[SerializeField]
		private int _defense;

		[SerializeField]
		private int _cash;

		private IHud _hud;

		public void CollectDependencies(Actor actor) {
			_hud = actor.Hud;
		}

		private void Start() {
			// Esse truque permite que você crie cenas
			// com personagens que começam com valores de vida
			// diferentes da máxima. Por exemplo você poderia
			// ter uma fase em que o vilão começa com metade da
			// vida, é só digitar o quanto de vida ele vai ter
			// no inspetor.

			// Se deixar em 0, ele começa com a vida máxima por padrão.

			if (CurrentHealth <= 0) {
				CurrentHealth = MaxHealth;
			}

			if (CurrentStamina <= 0) {
				CurrentStamina = MaxStamina;
			}
		}

		private void Update() {
			// Aqui você colocaria sua lógica de fome/sede.
		}
	}
}