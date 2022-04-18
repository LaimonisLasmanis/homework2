// Homework week 2.


// --------------- 1.------------------- Name
Console.WriteLine("Lūdzu ievadiet savu vārdu : ");
string userName = Console.ReadLine();

Console.WriteLine("Sveicināts " + userName );


Console.WriteLine();
Console.WriteLine("=========================================");
Console.WriteLine();

// --------------- 2.------------------- Age 
Console.WriteLine("Lūdzu ievadi savu vecumu : ? ");
string userageString = Console.ReadLine();
int UserAge = int.Parse(userageString);

int byOneLarger = UserAge + 1;
Console.WriteLine("Nākošgad tu paliec par gadiņu vecāks , tev būs : " + byOneLarger);

Console.WriteLine();
Console.WriteLine("=========================================");
Console.WriteLine();

// --------------- 3.------------------- Math.Max

Console.WriteLine("Ievadiet lūdzu 2 skaitļus, pēc jūsu izvēles?");
string numbminstring = Console.ReadLine();
string numbmaxstring2 = Console.ReadLine();
int numbmin = int.Parse(numbminstring);
int numbmax = int.Parse(numbmaxstring2);    


int largerNumber = Math.Max(numbmin , numbmax);

Console.WriteLine("Lielākais skaitlis ko jūs ievadījāt: " + largerNumber);



Console.WriteLine();
Console.WriteLine("=========================================");
Console.WriteLine();

// --------------- 4.------------------- Min numb
Console.WriteLine("Ievadiet lūdzu 2 skaitļus, pēc jūsu izvēles?");
string numbiminstring = Console.ReadLine();
string numbimaxstring2 = Console.ReadLine();
int numbimin = int.Parse(numbiminstring);
int numbimax = int.Parse(numbimaxstring2);


int smallerNumber = Math.Min(numbimin, numbimax);

Console.WriteLine("Mazākais skaitlis ko jūs ievadījāt: " + smallerNumber);



Console.WriteLine();
Console.WriteLine("=========================================");
Console.WriteLine();

// --------------- 5.------------------- Procenti

Console.WriteLine("Procenti : Lūdzu ievadi pirmo skaitli");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());

int result = firstNumber % secondNumber;
Console.WriteLine("Procentuālais rezultāts  : " + result);




Console.WriteLine();
Console.WriteLine("=========================================");
Console.WriteLine();

// --------------- 6.------------------- Odd / Even

Console.WriteLine("Ievadi jebkādu skaitli, tas būs pāra vai nepāra?");
int Oddevennumb= int.Parse(Console.ReadLine());
bool isEven = Oddevennumb % 2 == 0;
Console.WriteLine("Skaitlis ir pāra skaitlis: " + isEven);





Console.WriteLine();
Console.WriteLine("=========================================");
Console.WriteLine();

// --------------- 7.------------------- reizinājums

Console.WriteLine("Lūdzu, ievadi Taisnstūra malas garumu, paskatīsimies kādu platību tas sastāda");
int pirmamala = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi Taisnstūra otras malas garumu");
int otramala = int.Parse(Console.ReadLine());

int laukums = pirmamala * otramala ;
Console.WriteLine("Taisnstūrisir burvīgs , tā laukums sastāda : " + laukums);



Console.WriteLine();
Console.WriteLine("=========================================");
Console.WriteLine();

// --------------- 8.-------------------  Trijstūris

Console.WriteLine("Lūdzu, ievadi Taisnleņķa trijstūra malas garumu");
int trijsturis = int.Parse(Console.ReadLine());

int tLaukums = trijsturis * trijsturis / 2;
Console.WriteLine("Trijstūra laukums sastāda " + tLaukums);


Console.WriteLine();
Console.WriteLine("=========================================");
Console.WriteLine();

// --------------- 9.------------------- Interpolācija


Console.WriteLine($"Sveiks {userName}, tavs vecums ir {UserAge}.");
Console.WriteLine($"Atgādinu ka lielākais skaitlis ko tu ievadīji ir {largerNumber} , savukārt mazākais - {smallerNumber}");
Console.WriteLine($" Tava taisnstūra laukums sastādija {laukums}, bet trijstūra laukums {tLaukums}");

Console.WriteLine($"Liels Paldies Par uzmanību , uz drīzu tikšanos, Ar cieņu L.L.");


Console.WriteLine();
Console.WriteLine("=========================================");
Console.WriteLine();



