using System;

namespace OpenPathfinderP2.Models
{
    public class CharacterAttribute
    {
        public StringLabel Label { get; }
        public float Value { get; }
        public float Modifier
        {
            get => UseModifierMapping ? valueModifierMapping(Value) : modifier;
            set => modifier = UseModifierMapping ? valueModifierMapping(Value) : value;
        }
        public bool UseModifierMapping { get; set; }

        private float modifier;
        private readonly Func<float, float> valueModifierMapping;

        private CharacterAttribute(StringLabel label, float value, float modifier)
        {
            Label = label;
            Value = value;
            Modifier = modifier;
            valueModifierMapping = v => modifier;
        }

        private CharacterAttribute(StringLabel label, float value, Func<float,float> valueModifierMapping)
        {
            UseModifierMapping = true;
            Label = label;
            Value = value;
            this.valueModifierMapping = valueModifierMapping;
        }

        public static CharacterAttribute NewCharacterAttribute(StringLabel label, float value, float modifier) => 
            new CharacterAttribute(label, value, modifier);

        public static CharacterAttribute NewCharacterAttribute(string label, float value, float modifier) => 
            new CharacterAttribute(new StringLabel(label), value, modifier);

        public static CharacterAttribute NewCharacterAttribute(StringLabel label, float value, Func<float, float> valueModifierMapping) => 
            new CharacterAttribute(label, value, valueModifierMapping);

        public static CharacterAttribute NewCharacterAttribute(string label, float value, Func<float, float> valueModifierMapping) => 
            new CharacterAttribute(new StringLabel(label), value, valueModifierMapping);
    }
}
