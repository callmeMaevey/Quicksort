// See https://aka.ms/new-console-template for more information


Random random = new Random();

List<int> nums = new List<int>();
while (nums.Count() < 20) {
    nums.Add(random.Next(0, 100));
}
quicksort(nums).ForEach(i => Console.Write(i+", "));





List<int> quicksort(List<int> list) {
	if(list.Count <= 1) { return list; }//recursive escape clause
	List<int> output = new();
	List<int> left = new();
	List<int> right = new();
	foreach(int i in list) {
		if (i < list[0]) { left.Add(i); }
		if (i > list[0]) { right.Add(i); }
    }
	left = quicksort(left);
	right = quicksort(right);

	//assemble final out
	left.ForEach(i => output.Add(i));
	output.Add(list[0]);
	right.ForEach(i => output.Add(i));
	return output;
}
