
using System.Collections.Concurrent;

namespace TestConsole
{
	class Program
	{
		private static void Main(string[] args)
		{
			Dictionary<int, string> dict = new Dictionary<int, string>();
			int[] arr = new int[] { 1, 2, 3, 4, 5 };
			Span<int> span = new Span<int>(new int[] { 1, 2, 3, 4, 5 });

			Span<int> arrSpan = arr.AsSpan<int>();

			Queue<int> queue = new Queue<int>();

			Stack<int> stack = new Stack<int>();

			stack.Push(1);
			stack.Pop();

			HashSet<int> hashSet = new HashSet<int>();

			hashSet.Add(1);
			IEnumerable<int> hashSetEnum = hashSet.AsEnumerable<int>();

			queue.Append(1);

			Console.WriteLine(Add(1, 2).Equals(3).ToString() + 98342710294.ToString());
		}
		public static int Add(int a, int b)
		{
			return a + b;
		}
	}
}
