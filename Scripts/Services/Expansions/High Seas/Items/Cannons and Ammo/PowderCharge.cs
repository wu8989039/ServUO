using System;
using Server;

namespace Server.Items
{
    public class PowderCharge : Item, ICommodity
    {
        public override int LabelNumber { get { return 1116160; } }

        TextDefinition ICommodity.Description { get { return LabelNumber; } }
        bool ICommodity.IsDeedable { get { return true; } }

        [Constructable]
        public PowderCharge() : this(1)
        {
        }

        [Constructable]
        public PowderCharge(int amount)
            : base(0xA2BE)
        {
            Stackable = true;
            Amount = amount;
        }

        public PowderCharge(Serial serial) : base(serial) { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class LightPowderCharge : Item, ICommodity
    {
        public override int LabelNumber { get { return 1116159; } }

        TextDefinition ICommodity.Description { get { return LabelNumber; } }
        bool ICommodity.IsDeedable { get { return true; } }

        [Constructable]
        public LightPowderCharge() : this(1)
        {
        }
        
        [Constructable]
        public LightPowderCharge(int amount) :  base(16932)
        {
            Hue = 2031;
            Stackable = true;
            Amount = amount;
        }


        public LightPowderCharge(Serial serial) : base(serial) { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (Core.EJ)
            {
                Replacer.Replace(this, new PowderCharge());
            }
        }
    }

    public class HeavyPowderCharge : Item, ICommodity
    {
        public override int LabelNumber { get { return 1116160; } }

        TextDefinition ICommodity.Description { get { return LabelNumber; } }
        bool ICommodity.IsDeedable { get { return true; } }

        [Constructable]
        public HeavyPowderCharge() : this(1)
        {
        }

        [Constructable]
        public HeavyPowderCharge(int amount)
            : base(16932)
        {
            Hue = 2031;
            Stackable = true;
            Amount = amount;
        }

        public HeavyPowderCharge(Serial serial) : base(serial) { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (Core.EJ)
            {
                Replacer.Replace(this, new PowderCharge());
            }
        }
    }
}
