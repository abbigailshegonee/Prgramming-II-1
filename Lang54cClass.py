class Circle:
  def __init__(self, radius):
    self.radius = radius
    self.pi = 3.14159
    self._area = 0
    self._perim = 0
    
  def calculate(self):
    self._area = round((self.radius ** 2) * self.pi, 3)
    self._perim = round(self.radius * self.pi * 2, 3)
    
def main():
  rad = int(input("Enter Radius: "))
  circle = Circle(rad)
  
  circle.calculate()
  print("Area:", circle._area)
  print("Perimeter:", circle._perim)

if __name__ == "__main__":
  main()