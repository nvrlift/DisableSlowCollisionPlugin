using AssettoServer.Server.Plugin;
using Autofac;

namespace SoftAutoModerationPlugin;

public class SoftAutoModerationModule : AssettoServerModule<AutoModerationConfiguration>
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<SoftAutoModerationPlugin>().AsSelf().As<IAssettoServerAutostart>().SingleInstance();
        builder.RegisterType<EntryCarAutoModeration>().AsSelf();
    }
}
