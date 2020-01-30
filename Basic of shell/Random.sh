#!/bin/bash
#process 1
for i in 'seq 10'
do
echo "$RANDOM"
done
#Random no generate process 2
echo "$(( $RANDOM % 10))"

