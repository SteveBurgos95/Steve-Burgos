
read -p "Your Number " number


if test $((number % 3)) -eq 0
then
    echo Divisibile by 3
fi

if test $((number % 5)) -eq 0
then
    echo Divisibile by 5
fi



