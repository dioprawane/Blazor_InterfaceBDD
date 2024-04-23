// Models/Dialogue.cs
using System;
using System.ComponentModel.DataAnnotations;
namespace InterfaceBDD.Models
{
    public class Dialogue
    {
        [Key]
        public int DCode { get; set; }
        public int DGCode { get; set; }
        public string DGMacroDesignation { get; set; } = string.Empty;
        public string DGNatureDuBesoin { get; set; } = string.Empty;
        public string DGCadreDachat { get; set; } = string.Empty;
        public string DGFournisseur { get; set; } = string.Empty;
        public int DGNTiers { get; set; }
        public string DGLibelleDuMarche { get; set; } = string.Empty;
        public string DGMasseBudgetaire { get; set; } = string.Empty;
        public string DGDA { get; set; } = string.Empty;
        public string DGaxeNational1 { get; set; } = string.Empty;
        public string DGGrandProjet { get; set; } = string.Empty;
        public string DGNomProjet { get; set; } = string.Empty;
        public string DGStatutProjetG2PI { get; set; } = string.Empty;
        public string DGCodeInitiativesDSI { get; set; } = string.Empty;
        public string DGObjectInitiative { get; set; } = string.Empty;
        public string DGComptesBudgetaires { get; set; } = string.Empty;
        public string DGComptesComptables { get; set; } = string.Empty;
        public string DGPortefeuille { get; set; } = string.Empty;
        public string DGSousPortefeuille { get; set; } = string.Empty;
        public string DGCaracteristiqueDuBesoin { get; set; } = string.Empty;
        public string DGCriticite { get; set; } = string.Empty;
        public decimal DGBudgetInitialDemande { get; set; }
        public decimal DGBudgetDG1Demande { get; set; }
        public decimal DGBudgetDG2Demande { get; set; }
        public decimal DGBudgetDG3Demande { get; set; }
        public decimal DGBudgetDG4Demande { get; set; }
        public decimal DGPlanBudgBiJanvier { get; set; } = 0;
        public decimal DGPlanBudgBr1Juillet { get; set; } = 0;
        public decimal DGPlanBudgBr2Novembre { get; set; } = 0;
        public string DGNumeroAB { get; set; } = string.Empty;
        public string DGNumeroDB { get; set; } = string.Empty;
        public decimal DGBIAutorise { get; set; }
        public decimal DGBR1Autorise { get; set; }
        public decimal DGBR2Autorise { get; set; }
        public string DGNCommande { get; set; } = string.Empty;
        public DateTime DGDateDeDebut { get; set; }
        public DateTime DGDateDeFin { get; set; }
        public decimal DGMontantCommande { get; set; }
        public decimal DGNEngagement { get; set; }
        public decimal DGMontantEngage { get; set; }
        public decimal DGRealise { get; set; }
        public string DGGA486AnneeN1 { get; set; } = string.Empty;
        public string DGGA486AnneeN2 { get; set; } = string.Empty;
        public string DGGA486AnneeN3 { get; set; } = string.Empty;
        public string DGGA486AnneeN4 { get; set; } = string.Empty;
        public decimal DGBudgPrevN1 { get; set; }
        public decimal DGBudgPrevN2 { get; set; }
        public decimal DGBudgPrevN3 { get; set; }
        public decimal DGBudgPrevN4 { get; set; }
        public string DGCommentaires { get; set; } = string.Empty;
        public int DGAnnee { get; set; }
        public string DGDialogue { get; set; } = string.Empty;
    }
}
