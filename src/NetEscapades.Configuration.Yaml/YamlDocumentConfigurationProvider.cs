using System;
using Microsoft.Extensions.Configuration;
using YamlDotNet.Core;

namespace NetEscapades.Configuration.Yaml
{
	public class YamlDocumentConfigurationProvider : ConfigurationProvider
	{
		private readonly YamlDocumentConfigurationSource _configurationSource;

		public YamlDocumentConfigurationProvider(YamlDocumentConfigurationSource configurationSource)
		{
			this._configurationSource = configurationSource;
		}
        
		public override void Load()
		{
			var parser = new YamlConfigurationFileParser();
			try
			{
				this.Data = parser.Parse(this._configurationSource.Document);
			}
			catch (YamlException e)
			{
				throw new FormatException(Resources.FormatError_YamlParseError(e.Message), e);
			}
		}
	}
}