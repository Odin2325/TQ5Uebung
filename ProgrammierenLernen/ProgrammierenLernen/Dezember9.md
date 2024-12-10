**Beispiel Logische Operatoren**

//== Vergleich
//!= Ungleich
// > groesser
// < kleiner
// >= groesser gleich
// <= kleiner gleich

int x = 30;
Console.WriteLine(x<10 || x<5);


//Der einzige Weg in dem einen && operator true zurueckliefern kann, ist wenn beide seiten True sind.
//Der einzige Weg in dem ein || operator false zurueckliefern kann, ist wenn beide seiten falsch sind.
bool istValide = false;