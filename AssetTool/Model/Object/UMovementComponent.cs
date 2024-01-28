namespace AssetTool.Model
{
    public class UMovementComponent : UActorComponent
    {
    }

    public static class UMovementComponentExt
    {
        public static void Write(this BinaryWriter writer, UMovementComponent item)
        {
            writer.Write((UActorComponent)item);
        }

        public static UMovementComponent Read(this BinaryReader reader, UMovementComponent item)
        {
            reader.Read((UActorComponent)item);
            return item;
        }
    }
}
