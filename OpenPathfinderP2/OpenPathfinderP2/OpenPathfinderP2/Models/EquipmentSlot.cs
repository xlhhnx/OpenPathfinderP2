using OpenPathfinderP2.Interfaces;

namespace OpenPathfinderP2.Models
{
    public class EquipmentSlot
    {
        public StringLabel Label { get; set; }
        public IEquipable Equipment { get; set; }
        public bool Empty { get => Equipment is EmptyEquipment; }

        private EquipmentSlot(StringLabel label)
        {
            Label = label;
            Equipment = new EmptyEquipment();
        }

        public static EquipmentSlot NewEquipmentSlot(StringLabel label) => new EquipmentSlot(label);

        public static EquipmentSlot NewEquipmentSlot(string label) => new EquipmentSlot(new StringLabel(label));
    }
}
