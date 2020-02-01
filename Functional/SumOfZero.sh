 #!/bin/bash/
 declare -a arr
echo "enter array size"
read size
echo "enter the array element"
for(( i=0;i<$size;i++ ))
do
read arr[$i]
done
for(( i=0;i<(( $size-2 ));i++ ))
do
 for(( j=i+1;j<(( $size-1 ));j++ ))
  do
   for(( k=j+1;k<$size;k++ ))
    do
     if(( arr[$i]+arr[$j]+arr[$k]==0 ))
      then
        echo "output are"
        printf  "${arr[$i]}  ${arr[$j]}  ${arr[$k]}"
      echo
     fi
   done
 done
done

