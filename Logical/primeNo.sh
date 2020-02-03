#!/bin/bash
for((i=2;i<100;i++))
do
for((j=2;j<=i;j++))
do
if((i%j==0))
then
count=$(($count+1))
 fi
done
if(($count==2))
then
printf "$[i]"
fi
done
