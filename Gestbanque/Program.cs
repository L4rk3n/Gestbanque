using Models;

Personne p1= new Personne();
p1.Nom = "Bouvier";
p1.Prenom = "Cédric";
p1.Datenaiss = new DateTime(1980, 12, 22);

Personne p2 = new Personne()
{
    Nom = "Morre",
    Prenom = "Thierry",
    Datenaiss = new DateTime(1970, 1, 1)
};

Console.WriteLine($"identité {p1.Nom} {p1.Prenom}, né le {p1.Datenaiss}");
Console.WriteLine($"identité {p2.Nom} {p2.Prenom}, né le {p2.Datenaiss}");

Courant c1 = new Courant()
{
    Numero = "BE01",
    LigneDeCredit = 200,
    Titulaire = p1
};

c1.Depot(20_000);
Console.WriteLine($"Le compte courant : {c1.Numero} du titulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}");
Console.WriteLine($"Né le  {c1.Titulaire.Datenaiss}");
Console.WriteLine($"Le solde est de : {c1.Solde} et la ligne de crédit de : {c1.LigneDeCredit}");

c1.Retrait(21000);
