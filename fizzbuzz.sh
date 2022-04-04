#!/bin/bash

#INPUT [uncomment & modify if required]
a=0     #will be used for first number of fibonacci sequence
b=1     #will be used for second number of fibonacci sequence
s=0     #will be used for output initial value
sampleInput=0
read sampleInput

#write your Logic here:

#Find Fibonacci Number
for((i=0; i<(sampleInput-1); i++))
do
    fn=$((a+b))
    a=$b
    b=$fn
done


# Add the digits together
while [ $fn -gt 0 ]
do
    # get remainder
    k=$(( $fn % 10 ))

    # get next digit
    fn=$(( $fn / 10 ))

    # calculate sum of digits
    s=$(( $s + $k))
done

#OUTPUT [uncomment & modify if required]
echo $s