
class Program
{

    static void Main()
    {
        CaseStudy1();

        CaseStudy2();


    }

    private static void CaseStudy2()
    {
        int[] ageLIst = { 10, 20, 40, 22 };
        UpdateAgeListItemsToZero(ageLIst);
        foreach (var age in ageLIst)
        {
            Console.WriteLine("Age after aclling UpateAgeListItemsToZero:" + age);
        }
    }

    private static void UpdateAgeListItemsToZero(int[] myAgeLIst)
    {
        for (int i = 0; i < myAgeLIst.Length; i++)
        {
            myAgeLIst[i] = 0;
        }
    }

    private static void CaseStudy1()
    {
        int age = 30;
        UpdateAgeToZero(age);
        Console.WriteLine($"Age is: {age}");

    }

    private static void UpdateAgeToZero(int age)
    {
        age = 0;
    }
}
