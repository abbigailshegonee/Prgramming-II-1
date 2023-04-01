import sys
sys.setrecursionlimit(5000)
def fact(n):
  if n == 3:
    return n
  return n + fact(n - 3)

def main():
  num = int(input("Enter a number: ")) * 3
  while num != 0:
    factn = fact(num)
    print(f"The sum of the first {int(num/3)} multiples of 3, from 3 to {int(num)} is {factn}")
    num = int(input("Enter a number: ")) * 3

if __name__ == "__main__":
  main()