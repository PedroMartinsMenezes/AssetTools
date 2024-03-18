namespace AssetTool
{
    public class UEnhancedInputActionDelegateBinding : UInputDelegateBinding
    {
        public const string TypeName = "EnhancedInputActionDelegateBinding";

        public new UEnhancedInputActionDelegateBinding Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
