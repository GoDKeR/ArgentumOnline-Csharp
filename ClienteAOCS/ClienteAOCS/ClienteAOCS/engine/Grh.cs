using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteAOCS.engine.Data;

namespace ClienteAOCS.engine
{
    public class Grh : GrhData
    {
        public short GrhIndex;
        public Single FrameCounter, Speed;
        public byte Started;
        public short loops;

        public Grh()
        {
            this.GrhIndex = 0;
            this.FrameCounter = 0;
            this.Speed = 0.0f;
            this.Started = 0;
            this.loops = 0;
        }

        public Grh(int GrhIndex, byte Started = 2)
        {
            this.GrhIndex = (short)GrhIndex;

            if (Started == 2)
            {
                if (GrhDat[this.GrhIndex].NumFrames > 1)
                {
                    this.Started = 1;
                }
                else
                {
                    this.Started = 0;
                }
            }
            else
            {
                if (GrhDat[this.GrhIndex].NumFrames == 1)
                    Started = 0;

                this.Started = Started;
            }

            if (this.Started > 0)
                this.loops = -1; //INFINITE_LOOPS
            else
                this.loops = 0;

            this.FrameCounter = 1.0f;
            this.Speed = GrhDat[this.GrhIndex].Speed;
        }
    }
}
