class ClLP311:

  def __init__(self, dn, cg, dg, tt):
    self.design = dn
    self.code = cg
    self.debug = dg
    self.test = tt
    self.catagory = 0
    self.percernts = [0] * 4

  def _percent(self, number):
    return round((number / self.budget) * 100, 2)

  def calculate(self):
    self.budget = self.design + self.code + self.debug + self.test
    self.percents[0] = self._percent(self.design)
    self.percents[1] = self._percent(self.code)
    self.percents[2] = self._percent(self.debug)
    self.percents[3] = self._percent(self.test)

  def display():
    ptint()
