namespace FindItems{
	public class Program(){
		public static SortedDictionary<string, long> itemDetails;
		
		public SortedDictionary<string,	long> FindItemDetails(long soldCount){
			SortedDictionary<string,long> foundItems = new SortedDictionary<string, long>();
			if(itemDetails.ContainsValue(soldCount)){
				foreach(var item in itemDetails){
					if(item.Value == soldCount){
						foundItems.Add(item.Key,item.Value);
					}
				}	
			}
			return foundItems;
		}

		public List<string> FindMinAndMaxSoldItems(){
			List<string> minAndMax = new List<string>();
			SortedList<long,string> sl = new SortedList<long,string>();
			foreach(var item in itemDetails){
				sl.Add(item.Value,item.Key);
			}
			int size = itemDetails.Count();
			minAndMax.Add(sl.GetValueAtIndex(0));
			minAndMax.Add(sl.GetValueAtIndex(size-1));
			return minAndMax;
		}

		public Dictionary<string,long> SortByCount(){
			SortedList<long,string> sl = new SortedList<long,string>();
			foreach(var item in itemDetails){
				sl.Add(item.Value,item.Key);
			}
			Dictionary<string,long> dict = new Dictionary<string,long>();
			foreach(var item in sl){
				dict.Add(item.Value,item.Key);
			}
			return dict;
		}

		public static void Main(string[] args){
			itemDetails = new SortedDictionary<string,long>();
			for(int i = 0;i<5;i++){
				Console.Write($"Enter Item number {i}'s Name in string: ");
				string name = Console.ReadLine();
				Console.Write($"Enter items sold quantity : ");
				long quantity = long.Parse(Console.ReadLine());
				itemDetails.Add(name,quantity);
 			}
			
			Program p = new Program();
			Console.Write("Enter the quantity to search : ");
			long toSearch = long.Parse(Console.ReadLine());
			SortedDictionary<string,long> ansDict = p.FindItemDetails(toSearch);
			foreach(var item in ansDict){
				Console.WriteLine($" Key : {item.Key} and Value : {item.Value} ");
			}

			Console.WriteLine("Finding Min and Max sold items min " + p.FindMinAndMaxSoldItems()[0] + "max : " + p.FindMinAndMaxSoldItems()[1]);
			
			Dictionary<string,long> sortedDict = p.SortByCount();
			foreach(var item in sortedDict){
				Console.WriteLine($" Key : {item.Key} and Value : {item.Value} ");
			}  
		}

		
	}
}