using AssettoServer.Server.Configuration;
using JetBrains.Annotations;
using YamlDotNet.Serialization;

namespace SoftAutoModerationPlugin;

[UsedImplicitly(ImplicitUseKindFlags.Assign, ImplicitUseTargetFlags.WithMembers)]
public class SoftAutoModerationConfiguration : IValidateConfiguration<SoftAutoModerationConfigurationValidator>
{
    public WrongWayPitsConfiguration WrongWayPits { get; init; } = new();
    public NoLightsPitsConfiguration NoLightsPits { get; init; } = new();
    public BlockingRoadPitsConfiguration BlockingRoadPits { get; init; } = new();
}

[UsedImplicitly(ImplicitUseKindFlags.Assign, ImplicitUseTargetFlags.WithMembers)]
public class WrongWayPitsConfiguration
{
    public bool Enabled { get; set; } = false;
    public int DurationSeconds { get; set; } = 20;
    public int MinimumSpeedKph { get; set; } = 20;

    [YamlIgnore] public float MinimumSpeedMs => MinimumSpeedKph / 3.6f;
}

[UsedImplicitly(ImplicitUseKindFlags.Assign, ImplicitUseTargetFlags.WithMembers)]
public class NoLightsPitsConfiguration
{
    public bool Enabled { get; set; } = false;
    public int DurationSeconds { get; set; } = 60;
    public int MinimumSpeedKph { get; set; } = 20;
    
    [YamlIgnore] public float MinimumSpeedMs => MinimumSpeedKph / 3.6f;
}

[UsedImplicitly(ImplicitUseKindFlags.Assign, ImplicitUseTargetFlags.WithMembers)]
public class BlockingRoadPitsConfiguration
{
    public bool Enabled { get; set; } = false;
    public int DurationSeconds { get; set; } = 30;
    public int MaximumSpeedKph { get; set; } = 5;
    
    [YamlIgnore] public float MaximumSpeedMs => MaximumSpeedKph / 3.6f;
}

[UsedImplicitly(ImplicitUseKindFlags.Assign, ImplicitUseTargetFlags.WithMembers)]
public class SlowCollisionConfiguration
{
    public bool Enabled { get; set; } = false;
    public int MaximumSpeedKph { get; set; } = 5;
    
    [YamlIgnore] public float MaximumSpeedMs => MaximumSpeedKph / 3.6f;
}
