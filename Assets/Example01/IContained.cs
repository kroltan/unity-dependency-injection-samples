namespace Example01 {
	public interface IContained {
		/// <summary>
		/// Coleta os conteúdos necessários do balde para seu funcionamento
		/// </summary>
		/// <param name="actor">Um balde cheio</param>
		void CollectDependencies(Actor actor);
	}
}