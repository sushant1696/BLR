#!/bin/bash/ -x
echo "enter the value of  num"
read num
sum=0
while(( $num > 0 ))
do
  rem=$(( $num%10 ))
  sum=$(( $sum+$rem ))
  num=$(( $num/10 ))
done
 echo $sum
