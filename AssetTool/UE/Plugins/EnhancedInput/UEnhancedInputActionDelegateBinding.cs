namespace AssetTool
{
    public class UEnhancedInputActionDelegateBinding : UInputDelegateBinding
    {
        public const string TypeName = "EnhancedInputActionDelegateBinding";
    }

    public static class UEnhancedInputActionDelegateBindingExt
    {
        public static void Write(this BinaryWriter writer, UEnhancedInputActionDelegateBinding item)
        {
            writer.Write((UInputDelegateBinding)item);
        }

        public static UEnhancedInputActionDelegateBinding Read(this BinaryReader reader, UEnhancedInputActionDelegateBinding item)
        {
            reader.Read((UInputDelegateBinding)item);
            return item;
        }
    }
}
