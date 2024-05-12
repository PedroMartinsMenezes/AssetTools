namespace AssetTool
{
    public class UDynamicBlueprintBinding : UObject
    {
        public UDynamicBlueprintBinding Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);
        }
    }
}
