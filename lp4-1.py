copies = int(input("Enter number of copies: "))
price = 0
if copies > 0 and copies <= 99:
  price = 0.3
elif copies >=100 and copies <= 499:
  price = 0.28
elif copies >= 500 and copies <=749:
  price = 0.27
elif price >= 750 and copies <= 1000:
  price = 0.26
elif copies > 1000:
  price = 0.25
else:
  print("The number of copies is invalid")

print("price per copy is :$" + str(price))
print("Total cost is $" + str(price * copies))