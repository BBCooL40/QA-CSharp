double bathWidth = double.Parse(Console.ReadLine());
double bathHeight = double.Parse(Console.ReadLine());
double tileWidth  = double.Parse(Console.ReadLine());
double tileHeight  = double.Parse(Console.ReadLine());

double bathArea = bathWidth * bathHeight;
bathArea = bathArea + 0.10 * bathArea;

double tileArea = tileWidth * tileHeight;

double countTiles = bathArea / tileArea;

Console.WriteLine(Math.Round(countTiles));