import random
compNum = random.randrange(1, 21)
playerNum = int(input("Enter a number between 1 and 20: "))
print("Computer's number:", str(compNum))
print("Player's number", str(playerNum))
if compNum == playerNum:
  print("You won!")
else:
  print("Better luck next time.")
  