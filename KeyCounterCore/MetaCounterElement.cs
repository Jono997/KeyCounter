using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KeyCounter
{
    [XmlInclude(typeof(MetaCounterValueElement))]
    [XmlInclude(typeof(MetaCounterCalculateElement))]
    public abstract class MetaCounterElement
    {
        public abstract int getValue();
    }

    /// <summary>
    /// A MetaCounter element representing a fixed value
    /// </summary>
    public class MetaCounterValueElement : MetaCounterElement
    {
        public int value;

        public override int getValue()
        {
            return value;
        }

        public MetaCounterValueElement()
        {
            value = 0;
        }
    }

    /// <summary>
    /// A MetaCounter element representing a calculation of other MetaCounter elements
    /// </summary>
    public class MetaCounterCalculateElement : MetaCounterElement
    {
        public enum Operand
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public List<MetaCounterElement> elements;

        public Operand operand;

        public override int getValue()
        {
            int retVal = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                MetaCounterElement e = elements[i];
                switch (operand)
                {
                    case Operand.Add:
                        retVal += e.getValue();
                        break;
                    case Operand.Subtract:
                        retVal -= e.getValue();
                        break;
                    case Operand.Multiply:
                        retVal *= e.getValue();
                        break;
                    case Operand.Divide:
                        retVal /= e.getValue();
                        break;
                }
            }
            return retVal;
        }

        public MetaCounterCalculateElement()
        {
            elements = new List<MetaCounterElement>();
            operand = Operand.Add;
        }
    }
}
