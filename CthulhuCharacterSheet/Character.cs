using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CthulhuCharacterSheet
{
    internal class Character
    {

        private string Name = "";
        private string Birthplace = "";
        private string Pronoun = "";
        private string Occupation = "";
        private string Residence = "";
        private int Age = 0;

        private int Str = 0;
        private int Con = 0;
        private int Dex = 0;
        private int Int = 0;
        private int Siz = 0;
        private int Pow = 0;
        private int App = 0;
        private int Edu = 0;
        private int HitPoints = 0;
        private int MagicPoints = 0;
        private int Luck = 0;
        private int Sanity = 100;

        private int MaxSanity = 100;
        private bool TempInsane = false;
        private bool IndefInsane = false;
        private bool MajWounded = false;
        private bool Unconcious = false;
        private bool Dying = false;

        private int Accounting = 0;
        private bool AccountingProf = false;
        private int Anthropology = 0;
        private bool AnthropologyProf = false;
        private int Appraise = 0;
        private bool AppraiseProf = false;
        private int Archaeology = 0;
        private bool ArchaeologyProf = false;
        private int Art = 0;
        private bool ArtProf = false;
        private int Charm = 0;
        private bool CharmProf = false;
        private int Climb = 0;
        private bool ClimbProf = false;
        private int Credit = 0;
        private int Cthulhu = 0;
        private int Disguise = 0;
        private bool DisguiseProf = false;
        private int Dodge = 0;
        private bool DodgeProf = false;
        private int Drive = 0;
        private bool DriveProf = false;
        private int Elec = 0;
        private bool ElecProf = false;
        private int FastTalk = 0;
        private bool FastTalkProf = false;
        private int Brawl = 0;
        private bool BrawlProf = false;
        private int Fighting = 0;
        private bool FightingProf = false;
        private int Handgun = 0;
        private bool HandgunProf = false;
        private int Rifle = 0;
        private bool RifleProf = false;
        private int Firearms = 0;
        private bool FirearmsProf = false;
        private int FirstAid = 0;
        private bool FirstAidProf = false;
        private int History = 0;
        private bool HistoryProf = false;
        private int Intimidate = 0;
        private bool IntimidateProf = false;
        private int Jump = 0;
        private bool JumpProf = false;
        private String LanguageOther = "";
        private bool LanguageOther1Prof = false;
        private String LanguageOwn = "";
        private bool LanguageOwn1Prof = false;
        private int Law = 0;
        private bool LawProf = false;
        private int Library = 0;
        private bool LibraryProf = false;
        private int Listen = 0;
        private bool ListenProf = false;
        private int Locksmith = 0;
        private bool LocksmithProf = false;
        private int Mech = 0;
        private bool MechProf = false;
        private int Medicine = 0;
        private bool MedicineProf = false;
        private int Nature = 0;
        private bool NatureProf = false;
        private int Navigate = 0;
        private bool NavigateProf = false;
        private int Occult = 0;
        private bool OccultProf = false;
        private int Persuade = 0;
        private bool PersuadeProf = false;
        private int Pilot = 0;
        private bool Pilot1Prof = false;
        private int Psychoanalysis = 0;
        private bool PsychoanalysisProf = false;
        private int Psychology = 0;
        private bool PsychologyProf = false;
        private int Ride = 0;
        private bool RideProf = false;
        private int Science = 0;
        private bool ScienceProf = false;
        private int Hand = 0;
        private bool HandProf = false;
        private int Spot = 0;
        private bool SpotProf = false;
        private int Stealth = 0;
        private bool StealthProf = false;
        private int Survival = 0;
        private bool SurvivalProf = false;
        private int Swim = 0;
        private bool SwimProf = false;
        private int Throw = 0;
        private bool ThrowProf = false;
        private int Track = 0;
        private bool TrackProf = false;
        private int Custom = 0;
        private bool CustomProf = false;

        private int Move = 0;
        private int Build = 0;
        private int DodgeCombat = 0;
        private int DamageBonus = 0;


        public static int ClampToPercentage(int input)
        {
            if (input > 100)
            {
                return 100;
            }
            if (input < 0)
            {
                return 0;
            }

            return input;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Birthplace1 { get => Birthplace; set => Birthplace = value; }
        public string Pronoun1 { get => Pronoun; set => Pronoun = value; }
        public string Occupation1 { get => Occupation; set => Occupation = value; }
        public string Residence1 { get => Residence; set => Residence = value; }
        public int Age1 { get => Age; set => Age = value; }
        public int Str1 { get => Str; set => Str = value; }
        public int Con1 { get => Con; set => Con = value; }
        public int Dex1 { get => Dex; set => Dex = value; }
        public int Int1 { get => Int; set => Int = value; }
        public int Siz1 { get => Siz; set => Siz = value; }
        public int Pow1 { get => Pow; set => Pow = value; }
        public int App1 { get => App; set => App = value; }
        public int Edu1 { get => Edu; set => Edu = value; }
        public int HitPoints1 { get => HitPoints; set => HitPoints = value; }
        public int MagicPoints1 { get => MagicPoints; set => MagicPoints = value; }
        public int Luck1 { get => Luck; set => Luck = value; }
        public int Sanity1 { get => Sanity; set => Sanity = value; }
        public int MaxSanity1 { get => MaxSanity; set => MaxSanity = value; }
        public bool TempInsane1 { get => TempInsane; set => TempInsane = value; }
        public bool IndefInsane1 { get => IndefInsane; set => IndefInsane = value; }
        public bool MajWounded1 { get => MajWounded; set => MajWounded = value; }
        public bool Unconcious1 { get => Unconcious; set => Unconcious = value; }
        public bool Dying1 { get => Dying; set => Dying = value; }
        public int Accounting1 { get => Accounting; set => Accounting = value; }
        public bool AccountingProf1 { get => AccountingProf; set => AccountingProf = value; }
        public int Anthropology1 { get => Anthropology; set => Anthropology = value; }
        public bool AnthropologyProf1 { get => AnthropologyProf; set => AnthropologyProf = value; }
        public int Appraise1 { get => Appraise; set => Appraise = value; }
        public bool AppraiseProf1 { get => AppraiseProf; set => AppraiseProf = value; }
        public int Archaeology1 { get => Archaeology; set => Archaeology = value; }
        public bool ArchaeologyProf1 { get => ArchaeologyProf; set => ArchaeologyProf = value; }
        public int Art1 { get => Art; set => Art = value; }
        public bool ArtProf1 { get => ArtProf; set => ArtProf = value; }
        public int Charm1 { get => Charm; set => Charm = value; }
        public bool CharmProf1 { get => CharmProf; set => CharmProf = value; }
        public int Climb1 { get => Climb; set => Climb = value; }
        public bool ClimbProf1 { get => ClimbProf; set => ClimbProf = value; }
        public int Credit1 { get => Credit; set => Credit = value; }
        public int Cthulhu1 { get => Cthulhu; set => Cthulhu = value; }
        public int Disguise1 { get => Disguise; set => Disguise = value; }
        public bool DisguiseProf1 { get => DisguiseProf; set => DisguiseProf = value; }
        public int Dodge1 { get => Dodge; set => Dodge = value; }
        public bool DodgeProf1 { get => DodgeProf; set => DodgeProf = value; }
        public int Drive1 { get => Drive; set => Drive = value; }
        public bool DriveProf1 { get => DriveProf; set => DriveProf = value; }
        public int Elec1 { get => Elec; set => Elec = value; }
        public bool ElecProf1 { get => ElecProf; set => ElecProf = value; }
        public int FastTalk1 { get => FastTalk; set => FastTalk = value; }
        public bool FastTalkProf1 { get => FastTalkProf; set => FastTalkProf = value; }
        public int Brawl1 { get => Brawl; set => Brawl = value; }
        public bool BrawlProf1 { get => BrawlProf; set => BrawlProf = value; }
        public int Fighting1 { get => Fighting; set => Fighting = value; }
        public bool FightingProf1 { get => FightingProf; set => FightingProf = value; }
        public int Handgun1 { get => Handgun; set => Handgun = value; }
        public bool HandgunProf1 { get => HandgunProf; set => HandgunProf = value; }
        public int Rifle1 { get => Rifle; set => Rifle = value; }
        public bool RifleProf1 { get => RifleProf; set => RifleProf = value; }
        public int Firearms1 { get => Firearms; set => Firearms = value; }
        public bool FirearmsProf1 { get => FirearmsProf; set => FirearmsProf = value; }
        public int FirstAid1 { get => FirstAid; set => FirstAid = value; }
        public bool FirstAidProf1 { get => FirstAidProf; set => FirstAidProf = value; }
        public int History1 { get => History; set => History = value; }
        public bool HistoryProf1 { get => HistoryProf; set => HistoryProf = value; }
        public int Intimidate1 { get => Intimidate; set => Intimidate = value; }
        public bool IntimidateProf1 { get => IntimidateProf; set => IntimidateProf = value; }
        public int Jump1 { get => Jump; set => Jump = value; }
        public bool JumpProf1 { get => JumpProf; set => JumpProf = value; }
        public string LanguageOther1 { get => LanguageOther; set => LanguageOther = value; }
        public bool LanguageOther1Prof1 { get => LanguageOther1Prof; set => LanguageOther1Prof = value; }
        public string LanguageOwn1 { get => LanguageOwn; set => LanguageOwn = value; }
        public bool LanguageOwn1Prof1 { get => LanguageOwn1Prof; set => LanguageOwn1Prof = value; }
        public int Law1 { get => Law; set => Law = value; }
        public bool LawProf1 { get => LawProf; set => LawProf = value; }
        public int Library1 { get => Library; set => Library = value; }
        public bool LibraryProf1 { get => LibraryProf; set => LibraryProf = value; }
        public int Listen1 { get => Listen; set => Listen = value; }
        public bool ListenProf1 { get => ListenProf; set => ListenProf = value; }
        public int Locksmith1 { get => Locksmith; set => Locksmith = value; }
        public bool LocksmithProf1 { get => LocksmithProf; set => LocksmithProf = value; }
        public int Mech1 { get => Mech; set => Mech = value; }
        public bool MechProf1 { get => MechProf; set => MechProf = value; }
        public int Medicine1 { get => Medicine; set => Medicine = value; }
        public bool MedicineProf1 { get => MedicineProf; set => MedicineProf = value; }
        public int Nature1 { get => Nature; set => Nature = value; }
        public bool NatureProf1 { get => NatureProf; set => NatureProf = value; }
        public int Navigate1 { get => Navigate; set => Navigate = value; }
        public bool NavigateProf1 { get => NavigateProf; set => NavigateProf = value; }
        public int Occult1 { get => Occult; set => Occult = value; }
        public bool OccultProf1 { get => OccultProf; set => OccultProf = value; }
        public int Persuade1 { get => Persuade; set => Persuade = value; }
        public bool PersuadeProf1 { get => PersuadeProf; set => PersuadeProf = value; }
        public int Pilot1 { get => Pilot; set => Pilot = value; }
        public bool Pilot1Prof1 { get => Pilot1Prof; set => Pilot1Prof = value; }
        public int Psychoanalysis1 { get => Psychoanalysis; set => Psychoanalysis = value; }
        public bool PsychoanalysisProf1 { get => PsychoanalysisProf; set => PsychoanalysisProf = value; }
        public int Psychology1 { get => Psychology; set => Psychology = value; }
        public bool PsychologyProf1 { get => PsychologyProf; set => PsychologyProf = value; }
        public int Ride1 { get => Ride; set => Ride = value; }
        public bool RideProf1 { get => RideProf; set => RideProf = value; }
        public int Science1 { get => Science; set => Science = value; }
        public bool ScienceProf1 { get => ScienceProf; set => ScienceProf = value; }
        public int Hand1 { get => Hand; set => Hand = value; }
        public bool HandProf1 { get => HandProf; set => HandProf = value; }
        public int Spot1 { get => Spot; set => Spot = value; }
        public bool SpotProf1 { get => SpotProf; set => SpotProf = value; }
        public int Stealth1 { get => Stealth; set => Stealth = value; }
        public bool StealthProf1 { get => StealthProf; set => StealthProf = value; }
        public int Survival1 { get => Survival; set => Survival = value; }
        public bool SurvivalProf1 { get => SurvivalProf; set => SurvivalProf = value; }
        public int Swim1 { get => Swim; set => Swim = value; }
        public bool SwimProf1 { get => SwimProf; set => SwimProf = value; }
        public int Throw1 { get => Throw; set => Throw = value; }
        public bool ThrowProf1 { get => ThrowProf; set => ThrowProf = value; }
        public int Track1 { get => Track; set => Track = value; }
        public bool TrackProf1 { get => TrackProf; set => TrackProf = value; }
        public int Custom1 { get => Custom; set => Custom = value; }
        public bool CustomProf1 { get => CustomProf; set => CustomProf = value; }
        public int Move1 { get => Move; set => Move = value; }
        public int Build1 { get => Build; set => Build = value; }
        public int DodgeCombat1 { get => DodgeCombat; set => DodgeCombat = value; }
        public int DamageBonus1 { get => DamageBonus; set => DamageBonus = value; }
    }//class
}//namespace
