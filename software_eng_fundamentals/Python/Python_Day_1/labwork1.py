def student_data(name, category, age, height, truth):
    print(f'my name is {name}')
    print(f'I am a {category}')
    print(f'my age is  {age}')
    print(f'my height is {height} ft')
    print(f'Registration Status: {truth}\n')


def phone_details(name, height, width):
    area = height * width
    perimeter = 2 * (height + width)
    
    print(f'Phone Name: {name}')
    print(f'Area: {area}')
    print(f'Perimeter: {perimeter}\n')

    
student_data('Viji','teacher', 23, 5.5, 4 > 5)
student_data('ujjwal', 'student', 19, 5.9, 5 < 6)
phone_details('iphone', 5, 4)
phone_details('samsung', 8, 6)