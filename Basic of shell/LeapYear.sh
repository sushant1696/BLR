echo "enter the year"
read year
if($year%4==0||$year%400==0)
then
  echo "this is a leapyear"
else
  echo "this is not a leapyear"
fi
