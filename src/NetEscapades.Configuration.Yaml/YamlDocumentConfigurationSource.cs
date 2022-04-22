using Microsoft.Extensions.Configuration;
using YamlDotNet.RepresentationModel;

namespace NetEscapades.Configuration.Yaml
{
	/// <summary>
	/// A YAML file based <see cref="FileConfigurationSource"/>.
	/// </summary>
	public class YamlDocumentConfigurationSource : IConfigurationSource
	{
		public YamlDocument Document { get;set; }

		public IConfigurationProvider Build(IConfigurationBuilder builder)
		{
			return new YamlDocumentConfigurationProvider( this );
		}
	}
}