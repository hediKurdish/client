namespace server.models
{
    public class PhoneDetail

    {
        public int Id { get; set; }
        //Launch
        public string? Announced { get; set; }
        public string? Status { get; set; }
        //display
        public string? Size_Type_Display { get; set; }
        public string? resolution_RefreshRate{ get; set; }
        //Build
        public string? OS_UI { get; set; }
        public string? Color { get; set; }
        public string? Dimensions { get; set; }
        public string? Weight { get; set; }
        public string? SIM { get; set; }
        

        //Memory
        public string? RAM { get; set; }
        public string? ROM { get; set; }
        public string? Card_Memory { get; set; }
        //Processor
        public string? CPU { get; set; }
        public string? GPU{ get; set; }
        public string? Chipset { get; set; }
        //Camera
        public string? Main { get; set; }
        public string? camera_Features { get; set; }
        public string? Front { get; set; }

        //features
        public string? FingerPrint { get; set; }
        public string? Stereo { get; set; }
        public string? AUX { get; set; }
        public string? ChargingPort { get; set; }
        //Battery
        public string? Battery_FastCharge { get; set; }
    }
}
