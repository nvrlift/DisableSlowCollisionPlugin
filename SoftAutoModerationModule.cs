using AssettoServer.Server.Plugin;
using Autofac;

namespace DisableSlowCollisionPlugin;

public class DisableSlowCollisionModule : AssettoServerModule<AutoModerationConfiguration>
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<DisableSlowCollisionPlugin>().AsSelf().As<IAssettoServerAutostart>().SingleInstance();
        builder.RegisterType<EntryCarAutoModeration>().AsSelf();
    }
}
