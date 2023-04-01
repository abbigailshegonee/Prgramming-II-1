class ClLP311:
  def __init__(self, dn, cg, dg, tt):
    self.design = dn
    self.code = cg
    self.debug = dg
    self.test = tt
    self.catagory = 0
    self.percents = [0] * 4

  def _percent(self, number):
    return round((number / self.budget) * 100, 2)

  def calculate(self):
    self.budget = self.design + self.code + self.debug + self.test
    self.percents[0] = self._percent(self.design)
    self.percents[1] = self._percent(self.code)
    self.percents[2] = self._percent(self.debug)
    self.percents[3] = self._percent(self.test)

  def display(self):
    print("\nTask\t\t\t% Time")
    print(f"Design\t\t\t{self.percents[0]}%")
    print(f"Coding\t\t\t{self.percents[1]}%")
    print(f"Debugging\t\t{self.percents[2]}%")
    print(f"Testing\t\t\t{self.percents[3]}%")

def main():
  print("Enter the number of hours spent on each task: \n")
  design = float(input("Designing: "))
  code = float(input("Coding: "))
  debug = float(input("Debugging: "))
  test = float(input("Testing: "))

  percents = ClLP311(design, code, debug, test)
  percents.calculate()
  percents.display()

if __name__ == "__main__":
  main()