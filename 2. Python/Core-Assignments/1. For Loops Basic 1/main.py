"""
Basic - Print all integers from 0 to 150.


Multiples of Five - Print all the
multiples of 5 from 5 to 1,000


Counting, the Dojo Way - Print integers 1 to 100. If divisible by 5, print "Coding" instead.
If divisible by 10, print "Coding Dojo".

Whoa. That Sucker's Huge - Add odd integers from 0 to 500,000, and print the final sum.

Countdown by Fours - Print positive numbers starting at 2018, counting down by fours.

Flexible Counter - Set three variables: lowNum, highNum, mult.
Starting at lowNum and going through highNum, print only the integers that are a multiple of mult.
For example, if lowNum=2, highNum=9, and mult=3, the loop should print 3, 6, 9 (on successive lines)
"""

count = 0

for count in range(0, 151):
    print(count)

count = 0

for count in range(5, 1001):
    if count % 5 == 0:
        print(count)

count = 0

for count in range(1, 101):
    if count % 5 == 0:
        print("Coding")

    if count % 10 == 0:
        print("Codingdojo")

    print(count)

count = 0

sum = 0

for count in range(0, 500001):

    if count % 2 == 0:
        pass
    else:
        sum = sum + count

print(sum)

count = 2018
print(count)
for count in reversed(range(0, 2019, 4)):
    print(count)


lowNum = 2
highNum = 9
mult = 3
count = 3

for count in range(lowNum, highNum+1):
    if count%3==0:
        print(count)
    else:
        pass



