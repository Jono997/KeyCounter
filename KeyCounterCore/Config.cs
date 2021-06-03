using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCounter
{
    public class Config
    {
        public CounterConfigBase[] configs { get; set; }
        public int polling_rate { get; set; }
        public double counter_opacity { get; set; }

        public Config()
        {
            configs = new CounterConfigBase[] { new KeyCounterConfig() };
            polling_rate = 50;
            counter_opacity = 1;
        }

        public Config(KeyCounterConfig[] configs) : this()
        {
            this.configs = new CounterConfigBase[configs.Length];
            Array.Copy(configs, this.configs, configs.Length);
        }

        public bool hasExit()
        {
            foreach (KeyCounterConfig counterConfig in configs)
                foreach (Key key in counterConfig.keys)
                    if (key.action == Key.KeyAction.Exit)
                        return true;
            return false;
        }
    }
}
