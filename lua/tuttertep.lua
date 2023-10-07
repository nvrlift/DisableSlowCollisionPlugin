

for cars
if crashed/slow
disable collision
else
enable collision

if ac.getCar(0).speedKmh<100 then
  ac.disableCarCollisions(0,true)
else
  ac.disableCarCollisions(0,false)
end
