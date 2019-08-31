namespace Example01 {
	/// <summary>
	/// Marca um valor como contível pelo balde.
	/// </summary>
	/// <remarks>
	/// Isso permite com que o <see cref="Actor"/> tenha certeza
	/// que os scripts sob seus cuidados possam acessá-lo,
	/// sem ter que conhecer todos os scripts para
	/// chamar uma função potencialmente diferente em todos eles.
	/// </remarks>
	public interface IContained {
		/// <summary>
		/// Coleta os conteúdos necessários do balde para seu funcionamento
		/// </summary>
		/// <param name="actor">Um balde cheio</param>
		void CollectDependencies(Actor actor);
	}
}