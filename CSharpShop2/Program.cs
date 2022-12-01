// See https://aka.ms/new-console-template for more information

using CSharpShop2;

Acqua acqua1 = new Acqua(2,50,0.6,10,"italia");
CiboInScatola tonno = new CiboInScatola(3, 50, 200);

List<string> listaDellaFrutta = new List<string>()
{
    "Banana",
    "Mela",
    "kiwi",
    "Pera",
    "Papaya",
    "banana",
    "banana"
};

SacchettoDiFrutta sacchettoFrutta1 = new SacchettoDiFrutta(2, 50, listaDellaFrutta);

sacchettoFrutta1.StampaProdotto();

