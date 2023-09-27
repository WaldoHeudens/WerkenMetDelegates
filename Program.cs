// Werken met delegates:
//    Creëer een delegate-type (zie onderaan) 
//    Ken aan een "variabele" van dat delegate-type vervolgens methoden toe die voldoen
//    aan de beschrijving van dit delegate-type

TemperatuurConversie conv1 = new TemperatuurConversie(FahrenheitNaarCelcius);
TemperatuurConversie conv2 = new TemperatuurConversie(CelciusNaarFahrenheit);
TemperatuurConversie conv3 = conv2 + new TemperatuurConversie(CelciusNaarKelvin);
Console.WriteLine("Conv1(100) = ");
conv1(100);
Console.WriteLine("Conv2(25) = ");
conv2(25);
Console.WriteLine("Conv3(50) = ");
conv3(50);
conv2 = new TemperatuurConversie(KelvinNaarCelcius);
Console.WriteLine("Conv3(150) = ");
conv3(150);


void FahrenheitNaarCelcius(double temp)
{
    double tempInCelcius = Math.Round((temp - 32) * 5 / 9, 1);
    Console.WriteLine( "    " + temp + "°F is " + tempInCelcius + "°C");
}

void CelciusNaarFahrenheit(double temp)
{
    double tempInFahrenheit = Math.Round((temp * 9 / 5) + 32, 1);
    Console.WriteLine("    " + temp + "°C is " + tempInFahrenheit + "°F");
}

void CelciusNaarKelvin(double tempInCelcius)
{
    double tempInKelvin = tempInCelcius + 273.15;
    Console.WriteLine("    " + tempInCelcius + "°C is " + tempInKelvin + "°K");
}

void KelvinNaarCelcius(double tempInKelvin)
{
    double tempInCelcius = tempInKelvin - 273.15;
    Console.WriteLine("    " + tempInKelvin + "°K is " + tempInCelcius + "°C");
}

delegate void TemperatuurConversie(double temperatuur);
