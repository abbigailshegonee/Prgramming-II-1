from Cl701g import *

def main():
  try:
    people = []
    with open("data/prog701g.dat", 'r') as f:
      num = int(f.readline())
      while num != 99:
        fn = f.readline()
        ln = f.readline()
        if num == 1:
          gpa = float(f.readline())
          p = Student(fn, ln, gpa)
          people.append(p)
        elif num == 2:
          numStu = int(f.readline())
          p = Teacher(fn, ln, numStu)
          people.append(p)
        elif num == 3:
          favW = f.readline().strip()
          p = Admin(fn, ln, favW)
          people.append(p)
        num = int(f.readline())

      tot = 0.0
      cnt = 0
      totstus = 0
      large = ""
      small = "rtjythlksdrkjtgndgewroijgerjosedgvewsdjgewgpdrsogperopgblkjdxljvpewpgfhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh"

      for person in people:
        if isinstance(person, student):
          tot += person.gpa
          cnt += 1
        if isinstance(person, Teacher):
          totstus += person.numStudents
        if isinstance(person, Admin):
          favW = person.favWord
          if len(favW) > len(large):
            large = favW
          if len(favW) < len(small):
            small = favW
      print("Average student GPA:", round(tot/cnt, 2))
      print("Total number of students taught:", totstus)
      print("Smallest favporite admin word:", small)
      print("largest favorite Admin word:", large)
  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()