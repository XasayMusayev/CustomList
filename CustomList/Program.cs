

using CustomList;

CustomList<string> customList = new CustomList<string>();



customList.Add("xasay");
customList.Add("musa");

foreach (var item in customList)
{
    Console.WriteLine(item);
}

customList.Find(x => x == "xasay");


