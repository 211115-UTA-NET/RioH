#!/usr/bin/bash


mkdir ./testfolder


touch ./testfolder/newfile.txt


echo "today is wednesday at 10:17am > ./testfolder/newfile.txt


for i in {2..20..2}
do

	nums+=$i
	if(($i<20))
	then
		nums+=", "
	fi
done

echo $nums >> ./testfolder/newfile.txt







