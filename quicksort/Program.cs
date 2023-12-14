// Written dec 13th 2023 after I couldnt recall it off the top of my head :C
Random random = new Random();

List<int> nums = new List<int>();
while (nums.Count() < 50) {
    nums.Add(random.Next(0, 100));
}
quicksort(nums).ForEach(i => Console.Write(i+", "));


List<int> quicksort(List<int> list) {
    // builds a B tree that lives on the stack,
	if(list.Count <= 1) { return list; }//recursive escape clause
	List<int> left = new();
	List<int> right = new();
	foreach(int i in list) {
		if (i < list[0]) { left.Add(i); }
		if (i > list[0]) { right.Add(i); }
    }
	left = quicksort(left); 
	right = quicksort(right);

	//assemble final out
	List<int> output = new();
	left.ForEach(i => output.Add(i));
	output.Add(list[0]);//add the center
	right.ForEach(i => output.Add(i));
	return output;//should be in order
}

