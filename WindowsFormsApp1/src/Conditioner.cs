using System;

namespace WindowsFormsApp1.src
{
    public class Conditioner : ICond
    {
        public enum CondMode
        {
            HOT,
            COLD,
            AIR
        }

        bool isPower = false;

        const int minT = 16;
        const int maxT = 28;

        private int temperature = minT;
        private int position = 0;

        private CondMode mode;

        public Conditioner()
        {
            this.mode = CondMode.COLD;
        }

        public bool power()
        {
            if (isPower) 
                isPower = false;
            else
                isPower = true;

            return isPower;
        }

        public void increaseT()
        {
            if (temperature + 1 <= maxT && isPower) {
                temperature += 1;
            }
        }

        public void decreaseT() {
            if (temperature - 1 >= minT && isPower)
            {
                temperature -= 1;
            }
        }

        public void openJalousie()
        {
            if (position + 10 <= 100 && isPower)
            {
                position += 10;
            }
        }

        public void closeJalousie()
        {
            if (position - 10 >= 0 && isPower)
            {
                position -= 10;
            }
        }

        public CondMode changeMode()
        {
            if (isPower)
            {
                int modeTmp = (int)this.mode + 1;

                if (Enum.GetValues(typeof(CondMode)).Length == modeTmp)
                {
                    modeTmp = 0;
                }

                this.mode = (CondMode)modeTmp;
            }

            return mode;
        }

        public int getTemperature() => temperature;
        public int getPosition() => position;
        public CondMode getMode() => mode;

        public bool getPower() => isPower;
    }
}
