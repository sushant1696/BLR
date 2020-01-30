#!/bin/bash/
#powere of two
echo "enter the no of n"
read n
r=1
for(( i=1;i<=$n;i++ ))
do
   r=$r+$(( 2*$r ))
done
echo "square of two is = $r"
