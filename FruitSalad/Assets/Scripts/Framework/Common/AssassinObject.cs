using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Framework.Common
{
    class AssassinObject
    {
        public int HitPoints { get; set; }
        public int Points { get; set; }

        public AssassinObject()
        {
            this.HitPoints = 2;
            this.Points = 100;
        }
    }
}
