using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire.Metier
{
    public enum Sexe
    {
        Femelle,
        Male,
        Hermaphrodite
    }

    public enum EtatConsultation
    { 
        EnCours,
        SaisieTerminee,
        FactureGeneree
    }

    public enum TypeActe
    {
        CONS,
        VACC,
        GYCA,
        CHIR,
        TATO,
        DIVE
    }
}