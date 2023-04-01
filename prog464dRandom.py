import random
import numpy as np


def transposeMatrices(mat1):
  rows = len(mat1)
  cols = len(mat1[0])
  mOut = np.empty((rows, cols), dtype='int')
  for r in range(rows):
    for c in range(cols):
      mOut[r][c] = mat1[c][r]
  return mOut



def printMatrix(mat):
  for row in mat:
    for num in row:
      print(f"{num:3d} ", end="")
    print()


def main():
  mat1 = []
  for r in range(5):
    row1 = []
    for c in range(5):
      rnd1 = random.randint(-50, 99)
      row1.append(rnd1)
    mat1.append(row1)

  print("\nOriginal Matrix:")
  printMatrix(mat1)

  reverse = transposeMatrices(mat1)
  print("\nTranspose:")
  printMatrix(reverse)


if __name__ == "__main__":
  main()  # Run "pip install numpy" first