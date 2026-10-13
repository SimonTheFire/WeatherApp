namespace Library
{
    public class Station
    {
        private double? distance;
        private double? latitude;
        private double? longitude;
        private int? useCount;
        private string id;
        private string name;
        private int? quality;
        private double? contribution;

        // Constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        public Station() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        // Properties for each field

        public double? Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public double? Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public double? Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public int? UseCount
        {
            get { return useCount; }
            set { useCount = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public double? Contribution
        {
            get { return contribution; }
            set { contribution = value; }
        }
    }

}
