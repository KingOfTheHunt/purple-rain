using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PurpleRain.Model.Services
{
    class RainService
    {
        private DrawService _drawService = new DrawService();
        private Random _random = new Random();
        public List<Drop> Rain { get; set; } = new List<Drop>();
        public Form Form { get; set; }

        public RainService(Form form)
        {
            Form = form;
        }

        public void Start()
        {
            AddDrops();
        }

        public void Update()
        {
            while (true)
            {
                foreach (var drop in Rain)
                {
                    drop.Fall();
                    _drawService.Draw(Rain, Form);

                    if (drop.Y > Form.Height)
                    {
                        drop.DefaultValues(_random.Next(-200, -100), _random.Next(4, 10));
                    }
                }
            }
        }

        private void AddDrops()
        {
            for (int i = 0; i < 100; i++)
            {
                Drop d = new Drop(_random.Next(0, Form.Width), _random.Next(-200, -100), _random.Next(4, 10));
                Rain.Add(d);
            }
        }
    }
}
