#!/bin/bash
head=0
tail=0
for(( i=1;i<=10;i++ ))
do
 rand=$(( $RANDOM%2 ))
  if(( $rand > 0 ))
  then
    head=$(( $head+1 ))
 else
    tail=$(( $tail+1 ))
  fi
done
printf " no of head : $head and no of tail: $tail"

