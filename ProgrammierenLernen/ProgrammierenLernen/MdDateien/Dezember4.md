**Variablen Erstellen**

//bool boolean => True/False
//char character => einen zeichen mit 'z'
//datentyp variableName = wertMitGleichenTypWieDatentyp;
int meinName = 1234567;

Console.WriteLine(meinName);

bool istEinenString = meinName.GetType() == typeof(int);

Console.WriteLine(istEinenString);