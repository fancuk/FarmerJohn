using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.Model
{
    public class PlanetItem
    {
        private int _nowPlanet;
        private int _nowStage;
        public int NowPlanet { get => _nowPlanet; set => _nowPlanet = value; }
        public int NowStage { get => _nowStage; set => _nowStage = value; }
    }
}
