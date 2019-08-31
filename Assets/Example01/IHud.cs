namespace Example01 {
	public interface IHud : IContained {
		/// <summary>
		/// Atualiza os valores mostrados na HUD
		/// </summary>
		/// <remarks>
		/// Deve ser chamado sempre que algum valor do personagem muda
		/// </remarks>
		void Redraw();
	}
}