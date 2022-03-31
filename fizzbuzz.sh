read -p "Your Number " number

if test $number -gt 0 && test $number -lt 21
then
    if test $((number % 3)) -eq 0
    then
        printf fizz
    fi
    if test $((number % 5)) -eq 0
    then
        printf buzz
     fi

fi