using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;

class MyDictionary<TKey, TValue>
{
    private int n;
    private TKey[] keys;
    private TValue[] values;
    public MyDictionary()
    {
        this.keys = new TKey[] { };
        this.values = new TValue[]{ };
        this.n = 0;
    }
    public MyDictionary(int n)
    {
        keys = new TKey[n];
        values = new TValue[n];
    }
    public MyDictionary( TKey[] keys, TValue[] values ) 
    {
        this.n = keys.Length;
        this.keys = keys;
    }
    public int Count
    {
        get
        {
            return n;
        }
    }
    public void Add(TKey x, TValue y)
    {
        bool ad = false;
        TKey[] _keys = new TKey [n + 1];
        TValue[] _values = new TValue [n + 1];

        for (int i = 0; i < n; i++)
        {
            if (keys[i].Equals(x))
            {
                values[i] = y;
                _values[i] = values[i];
                ad = true;
            }
            else
            {
                _values[i] = values[i];
                _keys[i] = keys[i];
            }
        }

        if (!ad)
        {
            _keys[_keys.Length] = x;
            _values[_values.Length] = y;
            n++;
        }
        keys = _keys;
        values = _values;
    }
    public TValue this[TKey key]
    {
        get
        {
            int i = 0;
            foreach (var pos in keys)
            {
                if (pos.Equals(key))
                {
                    return values[i];
                }
                i++;
            }
            throw new KeyNotFoundException("Key does not exist.");
        }
    }

    public IEnumerator<TKey> GetEnumerator()
    {
        for (int i = 0; i < n; i++)
        {
            yield return keys[i];
        }
    }
    public void print()
    {
        int i = 0;
        foreach (var pos in keys)
        {
            Console.WriteLine($"[{pos}] : {values[i]}");
            i++;
        }
        Console.WriteLine();
    }

}

class Program
{
    public static void Main()
    {
        MyDictionary<int, int> md = new MyDictionary<int, int>();
        md.Add(7, 2);
        md.Add(5, 11);
        md.print();
        md.Add(7, 8);
        md.print();

    }
}