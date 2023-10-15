﻿using FluentValidation;
using JetBrains.Annotations;

namespace SoftAutoModerationPlugin;

[UsedImplicitly]
public class SoftAutoModerationConfigurationValidator : AbstractValidator<SoftAutoModerationConfiguration>
{
    public SoftAutoModerationConfigurationValidator()
    {
        RuleFor(cfg => cfg.WrongWayPits).NotNull().ChildRules(wwp =>
        {
            wwp.RuleFor(w => w.DurationSeconds).GreaterThanOrEqualTo(0);
            wwp.RuleFor(w => w.MinimumSpeedKph).GreaterThanOrEqualTo(0);
        });
        RuleFor(cfg => cfg.NoLightsPits).NotNull().ChildRules(nlp =>
        {
            nlp.RuleFor(n => n.DurationSeconds).GreaterThanOrEqualTo(0);
            nlp.RuleFor(n => n.MinimumSpeedKph).GreaterThanOrEqualTo(0);
        });
        RuleFor(cfg => cfg.BlockingRoadPits).NotNull().ChildRules(brp =>
        {
            brp.RuleFor(b => b.DurationSeconds).GreaterThanOrEqualTo(0);
            brp.RuleFor(b => b.MaximumSpeedKph).GreaterThanOrEqualTo(0);
        });
    }
}
