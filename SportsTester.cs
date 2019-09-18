using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsTester
{
    public class SportsTester
    {
        private static Team[] teamList;
        public Team[] TeamList { get; set; }

        public static Team[] BuildData()
        {
            teamList = new Team[20];
            for (int i = 0; i < 10; i++)
            {
                teamList[i] = new SubTeam($"teamName{i}", 24, $"coachName{i}", $"sportName{i}", true, 99, true);

            }

            for (int i = 10; i < 20; i++)
            {
                teamList[i] = new SubTeam2($"teamName{i}", 42, $"coachName{i}", $"sportName{i}", true,
                    $"nameMainSponsor", 77);

            }

            return teamList;

        }
    }
}

