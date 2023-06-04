
using KontrollimTesti;

var kandidatet = new Kandidatet();
var grupet = new Grupet();
var emrat = new Emrat();

var lista = kandidatet.GjeneroListen();


emrat.GjeneroListen(lista, "samples/lista_e_Kandidateve.txt");
grupet.Grupo(lista, "samples/grupet_e_Kandidateve.txt");

