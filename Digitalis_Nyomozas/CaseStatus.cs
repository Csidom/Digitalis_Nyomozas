using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class CaseStatus
	{
        public enum CaseState
        {
            Nyitott,
            Folyamatban,
            Lezart
        }

        public CaseState CurrentState;

        public CaseStatus(CaseState currentState)
        {
            CurrentState = currentState;
        }

        public void ChangeStatus(CaseState newState)
        {
            if (CurrentState == CaseState.Lezart)
            {
                Console.WriteLine("Lezárt ügy, nem módosítható.");
                return;
            }

            CurrentState = newState;
        }
    }
}
