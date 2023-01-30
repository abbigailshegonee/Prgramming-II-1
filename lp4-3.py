eggs = int(input("Enter number of eggs: "))
price = 0.0
if eggs > 0 and eggs < 48:
  price = 0.50
elif eggs >= 48 and eggs < 72:
  price = 0.45
elif eggs >= 72 and eggs < 132:
  price = 0.40
elif eggs >= 132:
  price = 0.35
dozen = eggs%12
dozenPrice = dozen * price
eggPrice = (eggs - (dozen*12)) * (price / 12)
total = dozenPrice + eggPrice
print("The bill is equal to: $" + str(round(total, 2)))