namespace StreamBuzz
{
    public class Program
    {
        public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();

        public void RegisterCreator(CreatorStats record)
        {
            EngagementBoard.Add(record);
            System.Console.WriteLine("Creator Registered Successfully");
        }

        public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (CreatorStats creator in records)
            {
                int weeks = 0;
                foreach (double likes in creator.WeeklyLikes)
                {
                    if (likes >= likeThreshold)
                    {
                        weeks++;
                    }
                }
                if (weeks > 0)
                {
                    dict.Add(creator.CreatorName, weeks);
                }
            }
            return dict;
        }

        public double CalculateAverageLikes()
        {
            int count = 0;
            double sum = 0;
            foreach (CreatorStats creator in EngagementBoard)
            {
                foreach (double likes in creator.WeeklyLikes)
                {
                    count++;
                    sum += likes;
                }
            }
            return sum / count;
        }
        public static void Main(string[] args)
        {
            Program p = new Program();

            while (true)
            {
                System.Console.WriteLine("=========Stream Buzz==========");
                System.Console.WriteLine("1. Register Creator");
                System.Console.WriteLine("2. Get Top Post Count");
                System.Console.WriteLine("3. Overall Weekly Likes");
                System.Console.WriteLine("4. Exit");
                System.Console.Write("Enter your input : ");
                int input = Int32.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        {
                            CreatorStats creator = new CreatorStats();
                            System.Console.Write("Enter the Creator name : ");
                            string name = Console.ReadLine();

                            System.Console.Write("Enter the Week 1 Likes : ");
                            double likes1 = double.Parse(Console.ReadLine());
                            System.Console.Write("Enter the Week 2 Likes : ");
                            double likes2 = double.Parse(Console.ReadLine());
                            System.Console.Write("Enter the Week 3 Likes : ");
                            double likes3 = double.Parse(Console.ReadLine());
                            System.Console.Write("Enter the Week 4 Likes : ");
                            double likes4 = double.Parse(Console.ReadLine());

                            creator.CreatorName = name;
                            creator.WeeklyLikes = [likes1, likes2, likes3, likes4];

                            p.RegisterCreator(creator);


                            break;
                        }
                    case 2:
                        {
                            System.Console.Write("Enter the Threshold Likes: ");
                            double threshold = double.Parse(Console.ReadLine());
                            Dictionary<string, int> dict = p.GetTopPostCounts(EngagementBoard, threshold);
                            if (dict.Count == 0)
                            {
                                System.Console.WriteLine("No top-performing posts this week");
                            }
                            foreach (var dic in dict)
                            {
                                System.Console.WriteLine($"Creator : {dic.Key} and Likes : {dic.Value}");
                            }
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Average Weekly Likes " + p.CalculateAverageLikes());
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                            return;
                        }
                    default:
                        {
                            break;
                        }
                }

            }

        }
    }
}