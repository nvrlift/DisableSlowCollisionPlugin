local autoModerationFlagEvent = ac.OnlineEvent({
    ac.StructItem.key("teleportToPits")
}, function (sender, message)
    if sender ~= nil then return end

    ac.tryToTeleportToPits()
end)

function script.update(dt)
    autoModerationFlagEvent{}
end 
