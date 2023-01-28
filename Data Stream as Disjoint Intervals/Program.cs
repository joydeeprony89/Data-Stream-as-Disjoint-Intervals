// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// https://leetcode.com/problems/data-stream-as-disjoint-intervals/description/
// https://www.youtube.com/watch?v=yecVlAxiE5U

public class SummaryRanges
{
  SortedSet<int> set;
  public SummaryRanges()
  {
    set = new SortedSet<int>();
  }

  public void AddNum(int value)
  {
    set.Add(value);
  }

  public int[][] GetIntervals()
  {
    int left = -1; int right = -1;
    var internals = new List<int[]>();
    foreach (var key in set)
    {
      if (left < 0) left = right = key;
      else if (key == right + 1)
      {
        right = key;
      }
      else
      {
        internals.Add(new int[] { left, right });
        left = right = key;
      }
    }
    internals.Add(new int[] { left, right });
    return internals.ToArray();
  }
}

/**
 * Your SummaryRanges object will be instantiated and called as such:
 * SummaryRanges obj = new SummaryRanges();
 * obj.AddNum(value);
 * int[][] param_2 = obj.GetIntervals();
 */
