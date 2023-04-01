def fact(n):
  if n == 1:
    return n  # Base / ending case
  return n * fact(n-1)  # Recursive case

def main():
  num = int(input("Enter a number: "))
  while num != 0:
    factn = fact(num)
    print(f"{num}! = {factn}")
    num = int(input("Enter a number: "))

if __name__ == "__main__":
  main()