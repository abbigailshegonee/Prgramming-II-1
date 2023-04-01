class Cl213e:
  def __init__(self, person):
    self.person = person
    self.g20 = 0
    self.g39 = 0
    self.g59 = 0
    self.g79 = 0
    self.old = 0
    self.percents = [0] * 5

  
  def distribution(self, wowie):
    if wowie > 20:
      self.g20 += 1
    elif wowie >= 20 and wowie <= 39:
      self.g39 += 1
    elif wowie >= 40 and wowie <= 59:
      self.g59 += 1
    elif wowie >= 60 and wowie <= 79:
      self.g79 += 1
    elif wowie >= 79:
      self.old += 1
    

  def _percent(self, number):
    return round((number / 10) * 100, 2)

  def calc(self):
    self.e = self.g20 + self.g39 + self.g59 + self.g79 + self.old
    self.percents[0] = self._percent(self.g20)
    self.percents[1] = self._percent(self.g39)
    self.percents[2] = self._percent(self.g59)
    self.percents[3] = self._percent(self.g79)
    self.percents[4] = self._percent(self.old)
    
    

  def display(self):
    print("Age Group\tDistribution\tPercentages")
    print(f"<20\t\t\t{self.g20}\t\t\t\t{self.percents[0]}")
    print(f"20-39\t\t{self.g39}\t\t\t\t{self.percents[1]}")
    print(f"40-59\t\t{self.g59}\t\t\t\t{self.percents[2]}")
    print(f"60-79\t\t{self.g79}\t\t\t\t{self.percents[3]}")
    print(f">79\t\t\t{self.old}\t\t\t\t{self.percents[4]}")