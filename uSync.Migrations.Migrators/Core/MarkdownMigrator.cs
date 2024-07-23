using Umbraco.Cms.Core.PropertyEditors;
using uSync.Migrations.Core.Extensions;

namespace uSync.Migrations.Migrators.Core;

[SyncMigrator(UmbEditors.Aliases.MarkdownEditor, typeof(MarkdownConfiguration), IsDefaultAlias = true)]
public class MarkdownMigrator : SyncPropertyMigratorBase
{
    public override object? GetConfigValues(SyncMigrationDataTypeProperty dataTypeProperty, SyncMigrationContext context)
    {
        var config = new MarkdownConfiguration {
            DefaultValue = dataTypeProperty.PreValues.GetPreValueOrDefault("defaultValue", ValueTypes.String),
            DisplayLivePreview = dataTypeProperty.PreValues.GetPreValueOrDefault("preview", false),
            OverlaySize = "small"
        };
        return config;
    }
}