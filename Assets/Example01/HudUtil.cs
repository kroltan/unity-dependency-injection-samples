using TMPro;
using UnityEngine.UI;

namespace Example01
{
	public static class HudUtil
	{
		/// <summary>
		/// Atualiza a interface de uma barra
		/// </summary>
		/// <param name="bar">Preenchimento</param>
		/// <param name="label">Texto</param>
		/// <param name="format">Formato a exibir o texto, parâmetro 0 é <see cref="current"/>, 1 é <see cref="max"/></param>
		/// <param name="current">Valor atual do atributo</param>
		/// <param name="max">Valor máximo do atributo</param>
		public static void UpdateBar(Image bar, TMP_Text label, string format, float current, float max) {
			bar.fillAmount = current / max;
			label.text = string.Format(format, current, max);
		}
	}
}
