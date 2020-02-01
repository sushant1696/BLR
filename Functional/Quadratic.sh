#!/bin/bash
echo "enter the value of a"
read a
echo "enter the value of b"
read b
echo "enter the value of c"
read c
delta=$(echo "$a" "$b""c" | awk '{print(($2*$2)-4*($1*$3))}')
   x1=$(echo "$a" "$b" "$delta" | awk '{print (-$2+$sqrt($3))/2*$1}')
echo "x1 value is:$x1"
x2=$(echo "$a" "$b" "$delta" | awk '{print (-$2-$sqrt($3))/2*$1}')
echo "x2 value is :$x2"

