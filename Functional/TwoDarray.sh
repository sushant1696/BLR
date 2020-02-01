 #!/bin/bash/
clear
declare -A arr
 echo "enter the element of array"
 for((i<0;i<3;i++))
do
for((j=0;j<2;j++))
 do
 read arr[$i,$j]
done
done
 printf "print the array " "%d/n"
 for((i=0 ;i<3;i++))do
 for((j=0;j<2;j++))do
 printf "%d" "${arr[$i,$j]}"
done
echo 
done

