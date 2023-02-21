class Shape:
  # Constructor: set up class data
  def __init__(self, length, width):
    self.length = length
    self.width = width
    self._area = 0  # _ prefix basically means 'private'
    self._perim = 0  # so it sould only be called in the class

  # Mutator/Setter: modifies class data
  def calculate(self):
    self._area = self.length * self.width
    self._perim = 2 * (self.length + self.width)

  def setLength(self, length):
    self.length = length
    
  # Accessor?Getters: return class data
  def getArea(self):
    return self._area

  def getPerim(self):
    return self._perim


def main():
  len = int(input("Enter length: "))
  wid = int(input("Enter width: "))
  shape = Shape(len, wid)  # Call "Shape" constructor
  # self.setLength(5)
  shape.calculate()
  print("Area:", shape._area)
  print("Perimeter:", shape.getPerim())

if __name__ == "__main__":
  main()