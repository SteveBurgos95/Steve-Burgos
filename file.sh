
read -p "Your Number " number


if test $((number % 3)) -eq 0
then
    printf fizz
fi

if test $((number % 5)) -eq 0
then
    printf buzz
fi



