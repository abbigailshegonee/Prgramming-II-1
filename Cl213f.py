class Cl213f:
  def __init__(self, kwh):
    self.kwh = kwh
    self.cost = 0.0

  def calc(self):
    if self.kwh <= 2000:
      self.cost = self.kwh * 0.07
    elif self.kwh > 2000 and self.kwh <=10000:
      self.cost = 140 + ((self.kwh - 2000) * 0.05)
    elif self.kwh > 10000:
      self.cost = 540 + ((self.kwh - 10000) * 0.04)
    

  def __str__(self):
    return f"The cost of {self.kwh} kilowatt hours is ${round(self.cost, 2)}"