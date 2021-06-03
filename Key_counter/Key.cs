using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Key_counter
{
    public class Key
    {
        public Keys keyChar { get; set; }
        
        public KeyAction action { get; set; }

        public enum KeyAction
        {
            Increment,
            Decrement,
            Reset,
            Exit,
            Checkpoint
        }

        public Key()
        {
            keyChar = Keys.None;
            action = KeyAction.Increment;
        }

        public Key(Keys keyChar, KeyAction action)
        {
            this.keyChar = keyChar;
            this.action = action;
        }
    }
}
