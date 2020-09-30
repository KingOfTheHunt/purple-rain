namespace PurpleRain.Model
{
    class Drop
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Speed { get; set; }

        public Drop(float x, float y, float speed)
        {
            X = x;
            Y = y;
            Speed = speed;
        }

        public void Fall()
        {
            Y += Speed;
            Speed += 0.2f;
        }

        public void DefaultValues(float y, float speed)
        {
            Y = y;
            Speed = speed;
        } 
    }
}
