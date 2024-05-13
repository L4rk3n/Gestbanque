using System.Runtime.CompilerServices;

namespace Models {

    public class Personne
    {
        public string Nom { get; set;}
        public string Prenom { get; set;}
        public DateTime Datenaiss { get; set;}
    }

    public class Courant
    {
        private double _ldc;
        public string Numero { get; set;}
        public Personne Titulaire { get; set;}  
        public double Solde { get; private set; }
        public double LigneDeCredit
        {
            get
            {
                return _ldc;
            }
            set
            {
                if (value >= 0)
                    { 
                        _ldc = value;
                    }
            }
        }
        public void Retrait(double Montant)
        {
            if (Montant<=0) return;
            if (Montant > (Solde + LigneDeCredit)) return;
            Solde -= Montant;
        }
        public void Depot(double Montant)
        {
            if (Montant <= 0) return; //return va a l accolade fermante sans executer le reste des lignes.
            Solde += Montant;
        }
    }
}
