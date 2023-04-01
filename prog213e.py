from Cl213e import *


def main():
  try:
    wowie = []
    with open("data/prog213e.dat", 'r') as f:
      for line in f:
        person = int(line)
        print(person)
        if person != -999:
          groups = Cl213e(person)
          wowie.append(groups)
    for groups in wowie:
      groups.distribution(groups)
    
      
    Cl213e.display(groups)
    print()
    
    
  except Exception as e:
    print("Error:", e)

if __name__ == "__main__":
  main()