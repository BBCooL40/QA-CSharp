
double pensPrice = 5.80;
double markersPrice = 7.20;
double boardCleanerPricePerLiter = 1.20;

int numberOfPensPackages = int.Parse(Console.ReadLine());
int numberOfMarkersPackages = int.Parse(Console.ReadLine());
int LitersOfBoardCleaner = int.Parse(Console.ReadLine());
int discount =  int.Parse(Console.ReadLine());
double discountPercentage = discount / 100.0;

double costOfPens = pensPrice * numberOfPensPackages;
double costOfMarkers = markersPrice * numberOfMarkersPackages;
double costOfBoardCleaner = boardCleanerPricePerLiter * LitersOfBoardCleaner;
double costOfMaterials = costOfPens +  costOfMarkers + costOfBoardCleaner;
double finalCost = costOfMaterials * (1 - discountPercentage);
Console.WriteLine(finalCost);