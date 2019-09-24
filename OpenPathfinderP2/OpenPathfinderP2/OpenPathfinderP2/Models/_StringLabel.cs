namespace OpenPathfinderP2.Models
{
    public class StringLabel
    {
        public string Value { get; }

        public StringLabel(string value) => Value = value;

        public override string ToString() => Value;

        public static implicit operator string(StringLabel label) =>  label.Value;
    }
}
