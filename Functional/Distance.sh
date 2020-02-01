 #!/bin/bash/
 echo "enter the value of x"
read x
echo "enter the value of y"
read y
distance=$(echo "$x" "$y" | awk '{print sqrt(($1*$1)+($2*$2))}')
echo "distance is: $distance"

