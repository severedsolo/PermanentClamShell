using System;
using UnityEngine;

namespace PermanentClamShell
{
    public class PermanentClamshell : PartModule
    {
        [KSPField(isPersistant = true, guiActive = false)]
        bool firstSet = false;

        void Start()
        {
            Debug.Log("PermanentClamsShell:Start");
            if (firstSet) return;
            ModuleProceduralFairing fairing = part.FindModuleImplementing<ModuleProceduralFairing>();
            fairing.useClamshell = true;
            firstSet = true;
            Debug.Log("[PermanentClamshell]: Set Fairing successfully");
        }
    }
}
