﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Example01 {
    public class PlayerHud : MonoBehaviour, IHud {
        [SerializeField]
        private Image _healthBar;

        [SerializeField]
        private TMP_Text _healthText;

        [SerializeField]
        private Image _staminaBar;

        [SerializeField]
        private TMP_Text _staminaText;

        [SerializeField]
        private TMP_Text _constitutionText;

        [SerializeField]
        private TMP_Text _agilityText;

        [SerializeField]
        private TMP_Text _attackText;

        [SerializeField]
        private TMP_Text _defenseText;
		
        [SerializeField]
        private TMP_Text _levelText;

        [SerializeField]
        private TMP_Text _cashText;

        private ICharacter _character;

        public void CollectDependencies(Actor actor) {
            _character = actor.Character;
        }

        public void Redraw() {
            HudUtil.UpdateBar(_healthBar, _healthText, "{0:F0}/{1:F0} HP", _character.CurrentHealth, _character.MaxHealth);
            HudUtil.UpdateBar(_staminaBar, _staminaText, "{0:F0}/{1:F0}", _character.CurrentStamina, _character.MaxStamina);
            _constitutionText.text = _character.Constitution.ToString();
            _agilityText.text = _character.Agility.ToString();
            _attackText.text = _character.Attack.ToString();
            _defenseText.text = _character.Defense.ToString();
            _levelText.text = _character.CombatLevel.ToString();
            _cashText.text = _character.Cash.ToString("C0");
        }
    }
}
