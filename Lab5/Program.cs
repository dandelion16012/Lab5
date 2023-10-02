class mymatrix
{
    private int n;
    private int m;
    private double[,] arr;

    public mymatrix() { }
    public mymatrix(int n, int m, int max, int min)
    {
        Random rand = new Random();
        this.n = n;
        this.m = m;
        arr = new double[n, m];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                arr[i, j] = rand.Next(min, max);

    }
    public void Fill()
    {
        Random rand = new Random();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                this.arr[i, j] = rand.Next();
    }
    public double this[int n, int m]
    {
        get
        {
            return arr[n, m];
        }
        set
        {
            arr[n, m] = value;
        }
    }
    public void ChangeSize(int n, int m, int _i, int _j )
    {
       double[,] rez = new double[n, m];
        Random rand = new Random();
        for (int i = _i;i < n; i++)
        {
            for (int j = _j; j < m; j++)
            {
                if (i<this.n && j < this.m)
                {
                    this.arr[i-_i,j-_j] = arr[i,j];
                }
                else
                {
                    rez[i, j] = rand.Next(10,20);
                }
                
            }
        }
        this.n=n;
        this.m=m;
    
        
    }

    public void ShowPartialy(int start_n,int end_n, int start_m, int end_m)
    {
        for (int i = start_n; i <= end_n; i++)
        {
            for (int j = start_m; j <= end_m; j++)
            {
                Console.Write(this.arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public void print()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(this.arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

namespace part1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы: строки ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размерность матрицы: столбцы ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите max ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите min");
            int min = Convert.ToInt32(Console.ReadLine());
            mymatrix A = new mymatrix(n, m, max, min);
            A.print();
            A.ChangeSize(6,6,2,2 );
            Console.WriteLine();
            A.print();
            Console.WriteLine();
            Console.WriteLine();
            A.ShowPartialy(0, 3, 2, 5);
            Console.WriteLine();
            Console.WriteLine();
            A.Fill();
            A.print();





        }
    }
}