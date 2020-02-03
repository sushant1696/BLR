#!/bin/bash/
echo enter stack,goal,and trial
read stack
read goal
read trial
bets=0
win=0
for((t=1;i<trial;t++))
do
    cash=$stack
    while(($cash>0 & $cash<$goal))
        do
          bets=$(($bets+1))
             rand=$(($Random%2))
                if(($rand<1))
                 then
                  cash=$(($cash+1))
                   else
                       cash=$(($cash-1))
               fi
        done
       if(($cash==$goal))
         then
            win=$(($win-1))
            fi
   done
printf " wins $win and  trials are $trial"
