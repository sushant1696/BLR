#!/bin/bash/
VendingMachin(){
       notes=0
       amount=173
         printf "the amount is +$aount"
           if(($amount==0)
            then
             return

                  if(( $amount>=100))
                     then
                          notes=$notes+$amount/100
                            printf " the no of 100 rupese note4s is +$notes"
                   if(($amount==0))
                    return
                      else
               VendingMachin($amount%100)
                     fi

}
