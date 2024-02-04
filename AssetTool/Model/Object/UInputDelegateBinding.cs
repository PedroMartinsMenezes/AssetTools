namespace AssetTool
{
    public class UInputDelegateBinding : UDynamicBlueprintBinding
    {
    }

    public static class UInputDelegateBindingExt
    {
        public static void Write(this BinaryWriter writer, UInputDelegateBinding item)
        {
            writer.Write((UDynamicBlueprintBinding)item);
        }

        public static UInputDelegateBinding Read(this BinaryReader reader, UInputDelegateBinding item)
        {
            reader.Read((UDynamicBlueprintBinding)item);
            return item;
        }
    }
}
