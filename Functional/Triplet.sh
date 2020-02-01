#!/bin/bash/
clear
arr=()
echo "enter the lenth of array"
read lt
echo "enter the element"
for((i=0;i<$lt;i++))
do
read arr[$i]
done
echo "the element are"
for((j=0;j<$lt;j++))
do
printf "${arr[$j]}"
done
for((i=0;i<$lt-2;i++))
 do
  for((j=0;j<$lt-1;j++))
   do
for((k=0;k<$lt;k++))


