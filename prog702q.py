from Cl702q import *


def main():
  try:
    vehicles = []
    totTires = 0
    with open("data/prog702q.txt", 'r') as f:
      num = int(f.readline())
      while num != 99:
        name = f.readline()
        tires = int(f.readline())
        totTires += tires
        if num == 1:
          value = int(f.readline())
          p = Car(name, tires, value)
          vehicles.append(p)
        elif num == 2:
          miles = int(f.readline())
          p = Truck(name, tires, miles)
          vehicles.append(p)
        elif num == 3:
          city = f.readline()
          p = Bus(name, tires, city)
          vehicles.append(p)
        num = int(f.readline())

      carValue = 0.0
      totValue = 0.0
      milage = 0
      truckLeast = 231263426273805237052950240572
      cityLarge = ""

      for vehicle in vehicles:
        if isinstance(vehicle, Car):
          carValue += vehicle.value
          #totWheels += vehicle.tires
          totValue += vehicle.value
          
        if isinstance(vehicle, Truck):
          milage += vehicle.miles
          #totWheels += vehicle.tires
          if truckLeast > vehicle.miles:
            truckLeast = vehicle.miles

          totValue += 50000 - (vehicle.miles * 0.25)
            
        if isinstance(vehicle, Bus):
          city = vehicle.city
          #totWheels += vehicle.tires
          if len(city) > len(cityLarge):
            cityLarge = city

          totValue += 50000
          
      print("Number of vehicles:", len(vehicles))
      print("Value of all vehicles: $" + str(totValue))
      print("Value of all cars: $" + str(carValue) + "0")
      print("Lowest value truck:", truckLeast)
      print("Total number of tires:", totTires)
      print("Longest bus home destination name:", cityLarge)
  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()
