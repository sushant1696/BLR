#!/bin/bash
declare -a arr
arr=(a b c d e f g h i j k l m n o p q r s t u v wx y z A B C
D E F G H I J K L M N O P Q R S T U V W X Y Z 1 2 3 4 5 6 7 8 9 0)
len=${#arr[@]}
for((j=0;j<$len/7;j++))
do
#Random%62 because total element of array is 62
random=$(($RANDOM%62))
rand=${arr[$random]}
printf $rand
echo
done

