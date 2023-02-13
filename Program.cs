int totalCubes;
int rolls;

float testCount = 100000;
List<int> averageRolls = new List<int>();

// count how long it takes to reach 0 c ubes

bool isCubes = true;

var watch = System.Diagnostics.Stopwatch.StartNew();

Random rnd = new Random();

for (int j = 0; j < testCount; j++) {
    // Thread.Sleep(250);
    isCubes = true;
    totalCubes = 90;
    rolls = 0;
    while (isCubes) {
        for (int i = 0; i < totalCubes; i++)
        {
            int roll  = rnd.Next(0, 6);
            // Console.WriteLine(roll);
            if (roll == 1) {
                totalCubes--;
            }
        }
        rolls++;
        // Console.WriteLine(rolls);
        if (totalCubes == 0) {
            isCubes = false;
        }
        
    }

    averageRolls.Add(rolls);
    
}


watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;
double average = averageRolls.Average();
Console.WriteLine($"Average is {average}");
Console.WriteLine($"Elapsed Time: {elapsedMs/100}s");

Console.ReadKey();