using UnityEngine;

namespace Example01 {
	public class Character : MonoBehaviour, ICharacter {
		public float CurrentHealth {
			get => _currentHealth;
			set {
				_currentHealth = Mathf.Clamp(value, 0, MaxHealth);
				_hud.Redraw();
			}
		}

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