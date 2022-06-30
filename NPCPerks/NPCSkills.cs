using System;

namespace NPCPerks
{
    [Flags]
    enum NPCSkills
    {
        Stealth = 1,
        Combat = 2,
        Lockpick = 4,
        Luck = 8 
    }
}