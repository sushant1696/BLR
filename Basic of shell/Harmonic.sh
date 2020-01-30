#!/bin/bash/
# harmonic number
echo "enter the value of n"
read n
r=1
hp=0
for((i=1;i<=$n;i++))
do
hp=$( echo "1" "$i" "$hp"| awk '{print $3 + ($1 / $2) }')
echo "temp : $temp"
#hp=$(echo "$hp" "$temp" | awk '{print $1 + $2}')
#echo "hp : $hp"
done
echo "result is =$hp"
