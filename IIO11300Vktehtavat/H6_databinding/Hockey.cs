﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6_databinding
{
    public class HockeyPlayer{ }

    public class HockeyTeam
    {
        #region PROPERTIES
        //HUOM public field ei kelpaa XAML bindauksessa, pitää olla Property!
        public string Name { get; set; }
        public string City { get; set; }
        #endregion
        #region COnSTRUCTORS
        public HockeyTeam()
        {
            Name = "";
            City = "none";
        }
        public HockeyTeam(string teamName, string city)
        {
            Name = teamName;
            City = city;
        }
        #endregion

        public override string ToString()
        {
            return Name + "@" + City;
        }
    }

    public class HockeyLeague
    {
        //perustetaan SMLiiga
        List<HockeyTeam> teams = new List<HockeyTeam>();
        public HockeyLeague()
        {
            teams.Add(new HockeyTeam("Ilves", "Tampere"));
            teams.Add(new HockeyTeam("Jyp", "Jyväskylä"));
            teams.Add(new HockeyTeam("HIFK", "Helsinki"));
            teams.Add(new HockeyTeam("Kärpät", "Oulu"));
            teams.Add(new HockeyTeam("Kalpa", "Kuopio"));
        }
        //metodi joka palauttaa liigan joukkueet
        public List<HockeyTeam> GetTeams()
        {
            return teams;
        }
    }
}
