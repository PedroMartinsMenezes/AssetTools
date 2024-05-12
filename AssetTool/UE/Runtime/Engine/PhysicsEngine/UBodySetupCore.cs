namespace AssetTool
{
    public class UBodySetupCore : UObject
    {
        public UBodySetupCore Read(BinaryReader reader)
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
