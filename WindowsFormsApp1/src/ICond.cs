using static WindowsFormsApp1.src.Conditioner;

namespace WindowsFormsApp1.src
{
    public interface ICond
    {
        bool power();
        void increaseT();
        void decreaseT();
        void openJalousie();
        void closeJalousie();
        CondMode changeMode();
        int getTemperature();
        int getPosition();
        CondMode getMode();
        bool getPower();
    }
}
