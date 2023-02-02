num1 = int(input("Enter first positive number: "))
num2 = int(input("Enter second positive number: "))
temp = 1
while (temp > 0):
  temp = num1 % num2
  num1 = num2
  num2 = temp

print("The GCD is", str(num1))