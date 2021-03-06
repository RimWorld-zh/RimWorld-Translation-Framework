﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Verse;

namespace RimWorld {
    /// <summary>
    /// For vanilla shuffled name
    /// Class RimWorld.NameBank
    /// Database: RimWorld.PawnNameDatabaseShuffled
    /// </summary>
    public class ShuffledNameDef : Def {

        #region Fields

        public PawnNameSlot slot;

        public Gender gender;

        public List<string> shuffledNames = new List<string>();

        #endregion

        [DebuggerHidden]
        public override IEnumerable<string> ConfigErrors() {
            if (this.shuffledNames == null || this.shuffledNames.Count == 0) {
                yield return "the field 'shuffledNames' cannot be null or empty.";
            }
        }

        public override string ToString() {
            return $"{GetType().Name} '{this.defName}'";
        }
    }
}
