
#Gets a number from user
read -p "Your Number " number

#Checks to see if number is between 1 and 20
while  test $number -lt 1 || test $number -gt 20 
do
    read -p "Please choose a number between 1 and 20: " number
done



#Prints FizzBuzz 
if test $((number % 3)) -eq 0
then
    printf fizz
fi
if test $((number % 5)) -eq 0
then
    printf buzz
fi
