using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyCounter
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
            Checkpoint,
            GlobalReset,
            GlobalCheckpoint
        }

        public int actionValue { get; set; }

        public static KeyAction[] UsesActionValue { get; private set; } = new KeyAction[] { KeyAction.Increment, KeyAction.Decrement };

        public KeyTrigger trigger { get; set; }

        public enum KeyTrigger
        {
            KeyDown,
            KeyHeld,
            KeyUp,
            Legacy
        }

        public Key()
        {
            keyChar = Keys.None;
            action = KeyAction.Increment;
            trigger = KeyTrigger.KeyDown;
        }

        public Key(Keys keyChar, KeyAction action, int actionValue)
        {
            this.keyChar = keyChar;
            this.action = action;
            this.actionValue = actionValue;
        }

        public Key(Keys keyChar, KeyAction action) : this(keyChar, action, 1)
        {

        }

        public Key Clone()
        {
            return new Key(keyChar, action, actionValue);
        }
    }
}
