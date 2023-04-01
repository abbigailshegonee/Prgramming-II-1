class vehicle:
  def __init__(self, name, tires):
    self._name = name
    self._tires = tires

  def getName(self):
    return self._name


class Car(vehicle):
  def __init__(self, name, tires, value):
    super().__init__(name, tires)
    # or Person.__init__(fn, ln)
    self.value = value

class Truck(vehicle):
  def __init__(self, name, tires, miles):
    super().__init__(name, tires)
    self.miles = miles

class Bus(vehicle):
  def __init__(self, name, tires, city):
    super().__init__(name, tires)
    self.city = city