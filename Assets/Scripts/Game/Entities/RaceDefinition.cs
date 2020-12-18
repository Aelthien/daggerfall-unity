// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2020 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using System;
using System.Collections.Generic;
using System.IO;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using FullSerializer;
using UnityEngine;

namespace DaggerfallWorkshop.Game.Entity
{
    /// <summary>
    /// Every race is defined by a common template.
    /// </summary>
    [Serializable]
    [fsObject]
    public class RaceDefinition
    {
        public int ID;                                          // A unique id for this race. Default race IDs match colour picker index on TAMRIEL2.IMG
        public string Name;                                     // Name of this race in singular, e.g. "Dark Elf"
        public int DescriptionID;                               // TEXT.RSC ID text to display on race selection
        public int ClipID;                                      // DAGGER.SND clip ID to play at race selection

        public string DollBG;                      // IMG filename of paper doll background

        public string DollMaleNude;               // IMG filename of male paper doll body - unclothed
        public string DollMale;                 // IMG filename of male paper doll body - clothed
        public string DollFemaleNude;             // IMG filename of female paper doll body - unclothed
        public string DollFemale;               // IMG filename of female paper doll body - clothed

        public string PaperDollHeadsMale;                       // CIF filename of male head selection
        public string PaperDollHeadsFemale;                     // CIF filename of female head selection

        public DFCareer.EffectFlags ResistanceFlags;            // Racial resistances
        public DFCareer.EffectFlags ImmunityFlags;              // Racial immunity
        public DFCareer.EffectFlags LowToleranceFlags;          // Racial low tolerance
        public DFCareer.EffectFlags CriticalWeaknessFlags;      // Racial critical weakness
        public DFCareer.SpecialAbilityFlags SpecialAbilities;   // Racial special abilities

        /// <summary>
        /// Clones this race template.
        /// </summary>
        /// <returns>Cloned RaceTemplate reference.</returns>
        public RaceDefinition Clone()
        {
            RaceDefinition clone = new RaceDefinition();
            clone.ID = ID;
            clone.Name = Name;
            clone.DescriptionID = DescriptionID;
            clone.ClipID = ClipID;
            clone.DollBG = DollBG;
            clone.DollMaleNude = DollMaleNude;
            clone.DollMale = DollMale;
            clone.DollFemaleNude = DollFemaleNude;
            clone.DollFemale = DollFemale;
            clone.PaperDollHeadsMale = PaperDollHeadsMale;
            clone.PaperDollHeadsFemale = PaperDollHeadsFemale;
            clone.ResistanceFlags = ResistanceFlags;
            clone.ImmunityFlags = ImmunityFlags;
            clone.LowToleranceFlags = LowToleranceFlags;
            clone.CriticalWeaknessFlags = CriticalWeaknessFlags;
            clone.SpecialAbilities = SpecialAbilities;

            return clone;
        }

        public static string GetRaceDefinitionsPath()
        {
            return Path.Combine(Application.dataPath, "StreamingAssets", "Races", "RaceDefinitions.json");
        }

         public static List<RaceDefinition> LoadRaceDefinition(int index)
         {
            fsSerializer serializer = new fsSerializer();

            string json = File.ReadAllText(GetRaceDefinitionsPath());
            object deserialised = null;
            fsData data = fsJsonParser.Parse(json);
            
            serializer.TryDeserialize(data, typeof(List<RaceDefinition>), ref deserialised).AssertSuccessWithoutWarnings();

            return (List<RaceDefinition>) deserialised;
         }

        /// <summary>
        /// Populates a race dictionary with standard RaceTemplate definitions.
        /// This is only temporary until loading race definitions from file is implemented.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, RaceDefinition> GetRaceDictionary()
        {
            Dictionary<int, RaceDefinition> raceDict = new Dictionary<int, RaceDefinition>();

            // Instantiate race templates
            Breton breton = new Breton();
            Redguard redguard = new Redguard();
            Nord nord = new Nord();
            DarkElf darkElf = new DarkElf();
            HighElf highElf = new HighElf();
            WoodElf woodElf = new WoodElf();
            Khajiit khajiit = new Khajiit();
            Argonian argonian = new Argonian();

            // Populate dictionary
            raceDict.Add(breton.ID, breton);
            raceDict.Add(redguard.ID, redguard);
            raceDict.Add(nord.ID, nord);
            raceDict.Add(darkElf.ID, darkElf);
            raceDict.Add(highElf.ID, highElf);
            raceDict.Add(woodElf.ID, woodElf);
            raceDict.Add(khajiit.ID, khajiit);
            raceDict.Add(argonian.ID, argonian);

            return raceDict;
        }

        /// <summary>
        /// Get the entity race corresponding to that read from FACTION.TXT. Only
        /// default races are supported.
        /// </summary>
        /// <param name="factionRace">The faction race</param>
        /// <returns>The corresponding entity race.</returns>
        public static Races GetRaceFromFactionRace(FactionFile.FactionRaces factionRace)
        {
            switch (factionRace)
            {
                case FactionFile.FactionRaces.None:
                    return Races.None;
                case FactionFile.FactionRaces.Nord:
                    return Races.Nord;
                case FactionFile.FactionRaces.Khajiit:
                    return Races.Khajiit;
                case FactionFile.FactionRaces.Redguard:
                    return Races.Redguard;
                case FactionFile.FactionRaces.Breton:
                    return Races.Breton;
                case FactionFile.FactionRaces.Argonian:
                    return Races.Argonian;
                case FactionFile.FactionRaces.WoodElf:
                    return Races.WoodElf;
                case FactionFile.FactionRaces.HighElf:
                    return Races.HighElf;
                case FactionFile.FactionRaces.DarkElf:
                    return Races.DarkElf;
            }

            return Races.None;
        }

        /// <summary>
        /// Get the FACTION.TXT race ID corresponding to an entity race. Only
        /// default races are supported.
        /// </summary>
        /// <param name="race">The entity race</param>
        /// <returns>The corresponding faction race.</returns>
        public static FactionFile.FactionRaces GetFactionRaceFromRace(Races race)
        {
            switch (race)
            {
                case Races.None:
                    return FactionFile.FactionRaces.None;
                case Races.Nord:
                    return FactionFile.FactionRaces.Nord;
                case Races.Khajiit:
                    return FactionFile.FactionRaces.Khajiit;
                case Races.Redguard:
                    return FactionFile.FactionRaces.Redguard;
                case Races.Breton:
                    return FactionFile.FactionRaces.Breton;
                case Races.Argonian:
                    return FactionFile.FactionRaces.Argonian;
                case Races.WoodElf:
                    return FactionFile.FactionRaces.WoodElf;
                case Races.HighElf:
                    return FactionFile.FactionRaces.HighElf;
                case Races.DarkElf:
                    return FactionFile.FactionRaces.DarkElf;
            }

            return FactionFile.FactionRaces.None;
        }
    }

    #region Default Race Templates

    public class Breton : RaceDefinition
    {
        public Breton()
        {
            ID = (int)Races.Breton;
            Name = TextManager.Instance.GetLocalizedText("breton");
            DescriptionID = 2003;
            ClipID = 209;

            DollBG = "SCBG00I0.IMG";

            DollMaleNude = "BODY00I0.IMG";
            DollMale = "BODY00I1.IMG";
            DollFemaleNude = "BODY10I0.IMG";
            DollFemale = "BODY10I1.IMG";

            PaperDollHeadsMale = "FACE00I0.CIF";
            PaperDollHeadsFemale = "FACE10I0.CIF";
        }
    }

    public class Redguard : RaceDefinition
    {
        public Redguard()
        {
            ID = (int)Races.Redguard;
            Name = TextManager.Instance.GetLocalizedText("redguard");
            DescriptionID = 2002;
            ClipID = 210;

            DollBG = "SCBG01I0.IMG";

            DollMaleNude = "BODY01I0.IMG";
            DollMale = "BODY01I1.IMG";
            DollFemaleNude = "BODY11I0.IMG";
            DollFemale = "BODY11I1.IMG";

            PaperDollHeadsMale = "FACE01I0.CIF";
            PaperDollHeadsFemale = "FACE11I0.CIF";
        }
    }

    public class Nord : RaceDefinition
    {
        public Nord()
        {
            ID = (int)Races.Nord;
            Name = TextManager.Instance.GetLocalizedText("nord");
            DescriptionID = 2000;
            ClipID = 211;

            DollBG = "SCBG02I0.IMG";

            DollMaleNude = "BODY02I0.IMG";
            DollMale = "BODY02I1.IMG";
            DollFemaleNude = "BODY12I0.IMG";
            DollFemale = "BODY12I1.IMG";

            PaperDollHeadsMale = "FACE02I0.CIF";
            PaperDollHeadsFemale = "FACE12I0.CIF";

            ResistanceFlags = DFCareer.EffectFlags.Frost;
        }
    }

    public class DarkElf : RaceDefinition
    {
        public DarkElf()
        {
            ID = (int)Races.DarkElf;
            Name = TextManager.Instance.GetLocalizedText("darkElf");
            DescriptionID = 2007;
            ClipID = 212;

            DollBG = "SCBG03I0.IMG";

            DollMaleNude = "BODY03I0.IMG";
            DollMale = "BODY03I1.IMG";
            DollFemaleNude = "BODY13I0.IMG";
            DollFemale = "BODY13I1.IMG";

            PaperDollHeadsMale = "FACE03I0.CIF";
            PaperDollHeadsFemale = "FACE13I0.CIF";
        }
    }

    public class HighElf : RaceDefinition
    {
        public HighElf()
        {
            ID = (int)Races.HighElf;
            Name = TextManager.Instance.GetLocalizedText("highElf");
            DescriptionID = 2006;
            ClipID = 213;

            DollBG = "SCBG04I0.IMG";

            DollMaleNude = "BODY04I0.IMG";
            DollMale = "BODY04I1.IMG";
            DollFemaleNude = "BODY14I0.IMG";
            DollFemale = "BODY14I1.IMG";

            PaperDollHeadsMale = "FACE04I0.CIF";
            PaperDollHeadsFemale = "FACE14I0.CIF";

            ImmunityFlags = DFCareer.EffectFlags.Paralysis;
        }
    }

    public class WoodElf : RaceDefinition
    {
        public WoodElf()
        {
            ID = (int)Races.WoodElf;
            Name = TextManager.Instance.GetLocalizedText("woodElf");
            DescriptionID = 2005;
            ClipID = 214;

            DollBG = "SCBG05I0.IMG";

            DollMaleNude = "BODY05I0.IMG";
            DollMale = "BODY05I1.IMG";
            DollFemaleNude = "BODY15I0.IMG";
            DollFemale = "BODY15I1.IMG";

            PaperDollHeadsMale = "FACE05I0.CIF";
            PaperDollHeadsFemale = "FACE15I0.CIF";
        }
    }

    public class Khajiit : RaceDefinition
    {
        public Khajiit()
        {
            ID = (int)Races.Khajiit;
            Name = TextManager.Instance.GetLocalizedText("khajiit");
            DescriptionID = 2001;
            ClipID = 215;

            DollBG = "SCBG06I0.IMG";

            DollMaleNude = "BODY06I0.IMG";
            DollMale = "BODY06I1.IMG";
            DollFemaleNude = "BODY16I0.IMG";
            DollFemale = "BODY16I1.IMG";

            PaperDollHeadsMale = "FACE06I0.CIF";
            PaperDollHeadsFemale = "FACE16I0.CIF";
        }
    }

    public class Argonian : RaceDefinition
    {
        public Argonian()
        {
            ID = (int)Races.Argonian;
            Name = TextManager.Instance.GetLocalizedText("argonian");
            DescriptionID = 2004;
            ClipID = 216;

            DollBG = "SCBG07I0.IMG";

            DollMaleNude = "BODY07I0.IMG";
            DollMale = "BODY07I1.IMG";
            DollFemaleNude = "BODY17I0.IMG";
            DollFemale = "BODY17I1.IMG";

            PaperDollHeadsMale = "FACE07I0.CIF";
            PaperDollHeadsFemale = "FACE17I0.CIF";
        }
    }

    #endregion
}
