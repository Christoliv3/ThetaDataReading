using System.Collections;

using (FileStream fs = File.Open("C:\\Users\\christoliv3\\source\\repos\\ThetaDataReading\\ThetaDataReading\\weather.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
using (BufferedStream bs = new BufferedStream(fs))
using (StreamReader sr = new StreamReader(bs))
{
    int count = 0;
    while (count < 8)
    {
        sr.ReadLine();
        count++;
    }
    ArrayList tempdifferences = new ArrayList();
    int count2 = 0;
    while (count2 < 30)
    {
        
        var test = sr.ReadLine();
        string dayofmonth = test.Substring(2, 2);
        string maxtemp = test.Substring(6, 2);
        string mintemp = test.Substring(12, 2);
        int maxT = Int32.Parse(maxtemp);
        int minT = Int32.Parse(mintemp);
        int tempdiff = maxT - minT;
        tempdifferences.Add(tempdiff);
        Console.WriteLine();
        foreach (var item in tempdifferences)
        {
            Console.Write(item + ", ");
        }
        count2++;
        
    }

    int mindiff = (int)tempdifferences[0];
    
    int dayofM = 0;
    int mindiffdayofM = 0;
    foreach (int x in tempdifferences)
    {
        dayofM++;
        if (mindiff > x)
        {
            mindiff = x;
            mindiffdayofM = dayofM;
        }
    }
    
    Console.WriteLine();
    Console.WriteLine("Day of Month = " + mindiffdayofM);
    Console.WriteLine("Minimum Temparuture Difference = " + mindiff);

}
