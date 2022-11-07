namespace Gr44_MVC_Project.Models
{
    public class Doctor
    {
        public readonly Temperature Temperature;

        public Doctor(Temperature temperature)
        {

            Temperature = temperature;

        }
        public string Diagnose()
        {
            if (Temperature.Celsius < 37)
                return "Too cold";
            else if (Temperature.Celsius > 37)
                return "Too hot";
            else
                return "Perfect";

        }

        
    }

    public enum TemperatureScale
    {
        Celsius,
        Fahrenheit,
        Kelvin
    }

    public class Temperature
    {
        private readonly decimal KelvinConst = 273.15m;
        public readonly decimal Celsius;
        public readonly decimal Fahrenheit;
        public readonly decimal Kelvin;

        public readonly TemperatureScale _scale;
        public readonly decimal _temp;

        public Temperature(decimal temperature, TemperatureScale scale)
        {
            _scale = scale;
            _temp = temperature;

            switch (scale)
            {
                case TemperatureScale.Celsius:
                    Celsius = temperature;
                    Fahrenheit = Celsius * 9 / 5 + 32;
                    Kelvin = Celsius + KelvinConst;
                    break;

                case TemperatureScale.Fahrenheit:
                    Fahrenheit = temperature;
                    Celsius = (Fahrenheit - 32) * 5 / 9;
                    Kelvin = Celsius + KelvinConst;
                    break;

                case TemperatureScale.Kelvin:
                    Kelvin = temperature;
                    Celsius = Kelvin - KelvinConst;
                    Fahrenheit = Celsius * 9 / 5 + 32; 
                    break;

                default:
                    throw new Exception("90+23485726523480+2");
                    
            }

            if (Kelvin < 0)
            {
                throw new Exception("0238947234");
            }

        }

        public override string ToString()
        {
            return $"{_temp}°{_scale.ToString()[0]}";
        }


    }



}
