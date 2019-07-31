namespace Proxy.Property.Models
{
    public class Creature
    {
        private Property<int> agility = new Property<int>();

        public Property<int> Agility
        {
            get => agility.Value;
            set => agility.Value = value;
        }
    }
}
