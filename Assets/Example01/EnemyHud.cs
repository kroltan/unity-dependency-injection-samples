using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Example01 {
	/// <summary>
	/// HUD para personagens não controlados pelo jogador.
	/// </summary>
	/// <remarks>
	/// Ela é mais simples que a HUD do jogador, pois o usuário
	/// não precisa necessariamente saber todos os dados do
	/// inimigo ou NPC.
	/// </remarks>
	public class EnemyHud : MonoBehaviour, IHud {

		[SerializeField]
		private Image _healthBar;

		[SerializeField]
		private TMP_Text _healthText;

		[SerializeField]
		private Image _staminaBar;

		[SerializeField]
		private TMP_Text _staminaText;

		[SerializeField]
		private TMP_Text _levelText;

		private ICharacter _character;

		public void CollectDependencies(Actor actor) {
			_character = actor.Character;
		}

		public void Redraw() {
			HudUtil.UpdateBar(_healthBar, _healthText, "{0:F0}/{1:F0} HP", _character.CurrentHealth, _character.MaxHealth);
			HudUtil.UpdateBar(_staminaBar, _staminaText, "{0:F0}/{1:F0}", _character.CurrentStamina, _character.MaxStamina);
			_levelText.text = _character.CombatLevel.ToString();
		}
	}
}