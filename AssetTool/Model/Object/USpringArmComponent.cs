namespace AssetTool
{
    public class USpringArmComponent : USceneComponent
    {
        public new const string TypeName = "SpringArmComponent";
    }

    public static class USpringArmComponentExt
    {
        public static void Write(this BinaryWriter writer, USpringArmComponent item)
        {
            writer.Write((USceneComponent)item);
        }

        public static USpringArmComponent Read(this BinaryReader reader, USpringArmComponent item)
        {
            reader.Read((USceneComponent)item);
            return item;
        }
    }
}
