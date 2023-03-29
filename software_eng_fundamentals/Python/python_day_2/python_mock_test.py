"""
Get the input and calculate the exponetional value
[Hint :Using exponent operator left operand raised to the power of right. The exponentiation operator is
denoted by a double asterisk ** symbol. You can use it as a shortcut to calculate the exponential value.
Example 2**3 Here 2 is multiplied by itself 3 times, i.e., 2*2*2. Here the 2 is the base, and 3 is an
exponent.]
"""

base = int(input('Enter the base: '))
power = int(input('Enter the power: '))

value = base ** power
print(f"The base {base} with power {power} equals to {value}")

"""
Use python standard library and use lower() and upper() . call both the methods and print the object.
"""

obj_1 = "This need to be Upper"
obj_2 = 'This need to be Lower'

print(obj_1.upper())
print(obj_2.lower())

"""
Get the semester average of a student and the final exam mark. If the avg>90 and final exam mark >90
then A grade.
"""
semester_average = float(input("Enter your semester average: "))
final_exam_mark = float(input("Enter your final exam mark: "))

if semester_average > 90 and final_exam_mark > 90:
    print("Congratulations you got A")
    
else:
    print("sorry you didn't got A")