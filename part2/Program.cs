using System.Xml.Linq;

class MyList<T>
{
    private T[] data;
    private int n;
    private int capacity;
    public T this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }

    public MyList()
    {
        this.data = new T[] { };
       this.n = 0;
    }
    public MyList(int count)
    {
        this.data = new T[count];
    }
    public MyList(T[] data, int n, int capacity)
    {
        this.data = data;
        this.n = n;
        this.capacity = capacity;
    }
    public int Length
    {
        get { return this.n; }
    }
    public void add(T elem)
    {
        if (n+1<=capacity) 
        {
            T[] new_arr = new T[this.n + 1];
            this.data.CopyTo(new_arr, 0);
            new_arr[this.n] = elem;
            this.data=new_arr;
            this.n ++;


        }
        else
        {
            T[] new_arr = new T[this.n + 1];
            this.data.CopyTo(new_arr, 0);
            new_arr[this.n] = elem;
            this.data = new_arr;
            this.n++;
            this.capacity = this.capacity * 2;

        }
    }
    public void print()
    {
        for (int i = 0; i < this.n; i++)
        {
            Console.Write(this.data[i] + " ");
        }
        Console.Write("\n");
        Console.WriteLine($"capacity: {this.capacity}");
        Console.Write("\n");
    }


}

namespace part3
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 ,5};
            MyList<int> ml = new(arr,5,8);
            ml.print();
            ml.add(6);
            ml.add(7);
            ml.add(8);
            ml.add(9);
            ml.print();

        }
    }
}