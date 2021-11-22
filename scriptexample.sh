#!/usr/bin/bash  

for i in {2..20..2}
do

	nums+=$i
	if(($i<20))
	then
		nums+=", "
	fi
done

echo $nums >> /RioH/TestLoop.txt 

#filepath=" . 